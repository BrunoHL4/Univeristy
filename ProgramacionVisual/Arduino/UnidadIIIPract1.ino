int led=13;
void setup() {
  // put your setup code here, to run once:
pinMode (13, OUTPUT);
Serial.begin(9600);
}
char dato='0';
void loop() {
  // put your main code here, to run repeated

if (Serial.available()==true) dato=Serial.read();
if (dato=='0')digitalWrite(led, LOW);
if (dato=='1')digitalWrite(led, HIGH);
  
}
