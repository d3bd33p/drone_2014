import processing.opengl.*;       //importing the openGL library
import procontroll.*;             //importing the pronControll lib

import net.java.games.input.*;

ControllIO myController;

//adding "RumblePad" as an object to controlldevice class    
ControllDevice RumblePad; 

ControllStick stick1;
ControllStick stick2;

float transX;
float transY;

void setup(){
   size(600,600,OPENGL);
   transX = width/2;
   transY = height/2;

   myController = ControllIO.getInstance(this);
 
  //defining the RumblePad
   RumblePad = myController.getDevice("Logitech RumblePad 2 USB"); 
   RumblePad.plug(this, "Movement", ControllIO.WHILE_PRESS, 0); 
 
   stick2 = RumblePad.getStick(0);
   stick2.setTolerance(0.06f);
   stick2.setMultiplier(0.05f); 
   } 

void Movement(final float i_x,final float i_y){
   transX += i_x;
   transY += i_y;
   } 

void draw(){
   background(0);
   fill(180,170,82);
   lights();
 
   //Limiting the sphere to stay in the 600*600 window
   if(transX<160){
     transX=160;
     }
   if(transX>440){
     transX=440;
     }
   if(transY<160){
     transY=160;
     }
   if(transY>440){
     transY=440;
     }
 
  //translation in X and Y axis
   translate(transX,transY,0);
 
  //rotation in X and Y direction
   rotateX(stick2.getTotalY());
   rotateY(stick2.getTotalX());
 
   sphere(140);
  }
