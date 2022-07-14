
void setup() {
  pinMode(11, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(9, OUTPUT);
  Serial.begin(9600);
}

char dato='0';

void loop() {

// 9 Rojo   10 Verde    11 Azul
  if (Serial.available()==true) dato=Serial.read();

  if(dato=='1')
  {
  analogWrite(11, 0);   
  analogWrite(10, 255);
  analogWrite(9, 0);
  //Serial.println(1);//verde
  delay(1000);

  analogWrite(11, 0);   
  analogWrite(10, 0);
  analogWrite(9, 0);
  //Serial.println(1);//verde
  delay(500);

  analogWrite(11, 0);   
  analogWrite(10, 255);
  analogWrite(9, 0);
  //Serial.println(1);//verde
  delay(1000);

  analogWrite(11, 0);   
  analogWrite(10, 0);
  analogWrite(9, 0);
  //Serial.println(1);//verde
  delay(500);

  analogWrite(11, 0);   
  analogWrite(10, 255);
  analogWrite(9, 0);
 // Serial.println(1);//verde
  delay(1000);

  analogWrite(11, 0);   
  analogWrite(10, 0);
  analogWrite(9, 0);
  //Serial.println(1);//verde
  delay(500);

  analogWrite(11, 0);   
  analogWrite(10, 75);
  analogWrite(9, 255);
  //Serial.println(1);//amarillo
  delay(1000);

  analogWrite(11, 0);   
  analogWrite(10, 0);
  analogWrite(9, 0);
  //Serial.println(1);//amarillo
  delay(500);

  analogWrite(11, 0);   
  analogWrite(10, 0);
  analogWrite(9, 255);
  //Serial.println(1);//rojo
  delay(1500);

  analogWrite(11, 0);   
  analogWrite(10, 0);
  analogWrite(9, 0);
 // Serial.println(1);//rojo
  
  }

  if (dato=='2')
  {
  analogWrite(11, 0);   
  analogWrite(10, 0);
  analogWrite(9, 0);
  }
 
}
