int Relay1 = 2;
int Relay2 = 3;
int Relay3 = 4;
int Relay4 = 5;
int Relay9 = 9;
int Relay10 = 10;
int Relay11 = 11;
int Relay12 = 12;
int value1;

void setup() 
{
  Serial.begin(9600);
  pinMode(Relay1, OUTPUT);
  digitalWrite(Relay1, HIGH);
  pinMode(Relay2, OUTPUT);
  digitalWrite(Relay2, HIGH);
  pinMode(Relay3, OUTPUT);
  digitalWrite(Relay3, HIGH);
  pinMode(Relay4, OUTPUT);
  digitalWrite(Relay4, HIGH);
  pinMode(Relay9, OUTPUT);
  digitalWrite(Relay9, HIGH);
  pinMode(Relay10, OUTPUT);
  digitalWrite(Relay10, HIGH);
  pinMode(Relay11, OUTPUT);
  digitalWrite(Relay11, HIGH);
  pinMode(Relay12, OUTPUT);
  digitalWrite(Relay12, HIGH);
}
void loop() 
{
  if (Serial.available() > 0)
  {
    value1 = Serial.read();
    
    if (value1 =='a')
    {
      digitalWrite(Relay1, HIGH);
    }
    if (value1 =='b')
    {
      digitalWrite(Relay1,LOW);
    }
    
    if (value1 =='c')
    {
      digitalWrite(Relay2, HIGH);
    }
    if (value1 =='d')
    {
      digitalWrite(Relay2,LOW);
    }
    if (value1 =='e')
    {
      digitalWrite(Relay3, HIGH);
    }
    if (value1 =='f')
    {
      digitalWrite(Relay3,LOW);
    }
    if (value1 =='g')
    {
      digitalWrite(Relay4, HIGH);
    }
    if (value1 =='h')
    {
      digitalWrite(Relay4,LOW);
    }
    
    if (value1 =='j')
    {
      digitalWrite(Relay9, HIGH);
      digitalWrite(Relay12,HIGH);
      digitalWrite(Relay10, LOW);
      digitalWrite(Relay11,LOW);
    }
    if (value1 =='k')
    {
      digitalWrite(Relay9, LOW);
      digitalWrite(Relay12,LOW);
      digitalWrite(Relay10, HIGH);
      digitalWrite(Relay11,HIGH);
    }


    /*int sensorValue = analogRead(A0);
    Serial.println(sensorValue);
    delay(500);
    /*digitalWrite(Relay, LOW);
    delay(1000);
    digitalWrite(Relay, HIGH);
    delay(1000);*/
}
}
 
