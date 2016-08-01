

//imports
import processing.serial.*; // for communication via Serial
import procontroll.*; // hacks into the ps3 controller feed
import java.io.*; // internal dependency for procontroll

Serial myPort; // for communication with Arduino

ControllIO controll; // abstraction of the controller object
ControllDevice device; // abstraction of the entire PS3 controller
ControllStick stick; // the analog stick on the PS3 controller
ControllButton xbutton; // the x button on the PS3 controller
ControllButton obutton; // the o button on the PS3 controller

void setup() {
  size(255, 255); // recommending not to change this size

  // initiation
  controll = ControllIO.getInstance(this); // used to instantiate the controll object
  device = controll.getDevice("PLAYSTATION(R)3 Controller"); // ask the controll object for the PS3 controller

  // print all available sticks, sliders and buttons of the PS3 Device
  device.printSticks();
  device.printSliders();
  device.printButtons();

  // set average tolerance, to reduce jerks
  device.setTolerance(0.05f);

  // initiating the x and y sliders which make up the left analog stick
  ControllSlider sliderX = device.getSlider("x");
  ControllSlider sliderY = device.getSlider("y");

  // initate the stick with the two sliders previously created
  stick = new ControllStick(sliderX, sliderY);

  // initiate the button objects
  xbutton = device.getButton("14");
  obutton = device.getButton("13");

  // initiate the Serial object to connect to the Arduino
  String portName = Serial.list()[4]; // Change depending on which Serial Port your Arduino is connected to
  myPort = new Serial(this, portName, 9600);
  println(Serial.list()); // can check which serial ports are being used and by what

  // Aesthetics
  fill(0); // makes the rectangle black
  rectMode(CENTER); // to ensure that the center of the rectangle represents the position of the stick
}

void draw() {
  background(255); // refresh

  // Analyse the input coming from the stick output
  // since the value is beween -1 and 1 scale it up to 128 and ensure it is an integer
  // by a cast. Since negative values are not accepted by servos, and there are 
  // serial communication issues, add 128 to the scaled value to get a 1 byte integer.
  int posX = 128+int(stick.getX()*128);
  int posY = 128+int(stick.getY()*128);

  // ensure that the rectangle does not leave the bounds of the canvas
  // as well as making sure that the servos don't go out of bounds
  posX = constrain(posX, 1, 254);
  posY = constrain(posY, 1, 254);
  
  // w -> fwd; s -> bkwd; a -> left; d -> right; e -> stop
  
  // send the signal if the stick indicates a turn to the left or right
  boolean turn = false; // to ensure that the stop signal is not sent if the car is supposed to turn
  try {
    // Turn Right
    if (posX >= 150){
      myPort.write("d");
      println("d");
      turn = true;
    }
    // Turn Left
    else if (posX <= 127){
      myPort.write("a");
      println("a");
      turn = true;
    }
  } 
  catch(Exception ex) {
    println("Exception has been reached");
  }
  
  // check for the x button to be pressed
  // Move Forward
  if (xbutton.pressed()) {
    fill(255, 0, 0); // if pressed change the color of the rectangle to red
    myPort.write("w");
    println("w");
  }
  // check for the o button to be pressed
  // Move Backward
  else if (obutton.pressed()){
    fill(0,0,255); // if pressed change the color of the rectangle to blue
    myPort.write("s");
    println("s");
  }
  // If no signal needs to be sent send the stop signal
  else if(!turn){
    fill(0); // otherwise let the rectangle be black
    myPort.write("e");
  }
  
  // position the rectangle using the information on the position of the stick on the PS3 controller
  rect(posX, posY, 20, 20);
}

