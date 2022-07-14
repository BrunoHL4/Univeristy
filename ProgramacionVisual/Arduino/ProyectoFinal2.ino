int laser=5;
int ldr=A0;
int buzzer=9;
int valor=0;
int num;

void setup() {
  Serial.begin(9600);
  pinMode (laser, OUTPUT);
}

char dato;

void loop() {

  if ( Serial.available()) {dato=Serial.read();}
     
           
    if (dato=='a')
    {  
     num=1;
     Serial.println(num);
    }

    if (dato=='d')
    { 
  num=2;
  Serial.println(num);
    }
switch(num){
  case 1:dato1();break;
  case 2:dato2();break;
  default:break;
}


    

}
void dato1()
{
      digitalWrite(laser,HIGH);
      valor=analogRead(ldr);
      Serial.println(valor);      
      delay(500);
      
        if (valor <= 50)
        {
          Serial.println("Normal");
           noTone(9); 
        }
        if (valor > 50)
        {
          Serial.println("Activado");
          tone(9,1000,1000);
          digitalWrite(laser,LOW);       
        }       
}
void dato2(){
      digitalWrite(laser, LOW);
      Serial.println ("Apagado");
      delay(50);
   }
