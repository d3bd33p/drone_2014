#include <Servo.h> 

Servo myservo;

int info = 0;
int val = 0;
int valtemp = 0;

void setup(){
  
Serial.begin(115200); //opens a serial connection at 115200 bps
myservo.attach(9, 1000, 2000);

}


 void loop() {

   if (Serial.available() > 0) {
   
   delay(10);
   
   info = 0;
   val = 0;
  
   info = Serial.read();
   info = info - 48; 
   
     if (info == 1) {
       
       val = Serial.read();
       val = val - 48;
       
     }
     
     if (info == 2){
       
       val = Serial.read();
       val = val - 48;
       val = val * 10;
       valtemp = Serial.read();
       valtemp = valtemp - 48;
       val = val + valtemp;
       
     }
     
     if (info == 3){
       
       val = Serial.read();
       val = val - 48;
       val = val * 100;
       valtemp = Serial.read();
       valtemp = valtemp - 48;
       valtemp = valtemp * 10;
       val = val + valtemp;
       valtemp = Serial.read();
       valtemp = valtemp - 48;
       val = val + valtemp;
       
     }
     
     myservo.write(val);
    
     
   }
   
   
 }
