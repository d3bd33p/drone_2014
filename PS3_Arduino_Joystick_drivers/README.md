This is a small project I have been working on to control a few servo and DC motors and eventually a full blown drone from the computer via a joystick. It uses a PS3 joystick hooked up to a custom C# program which gets the axis and button values from it via directx directinput. The values are then scaled to 0 to 180 and sent out over serial to the arduino in much the same manner that my serial controlled stepper motor worked. When the arduino receives the instructions it then extracts the value and sets the motor to the value (speed). It can also work for a servo motor by simply changing the cable.

Keep in mind you have to download the directx SDK to get this code up and running.
Cheers !!!
