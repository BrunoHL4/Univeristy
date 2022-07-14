#include <Servo.h>

Servo servoMotor;
 
void setup() {
  
  Serial.begin(9600);
  servoMotor.attach(3);
}
char dato='0';
 
void loop() {
 
  if (Serial.available()==true) dato=Serial.read();
  
  if (dato=='0')
  servoMotor.write(0);
   
  if (dato=='1')
  servoMotor.write(45);
   
  if (dato=='2')
  servoMotor.write(90);
 
   if (dato=='3')
  servoMotor.write(135);
   
  if (dato=='4')
  servoMotor.write(180);
   
}
