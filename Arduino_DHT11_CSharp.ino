#include "DHT.h"

#define DHTPIN 2
#define DHTTYPE DHT11
DHT dht(DHTPIN, DHTTYPE);


void setup() {
  // put your setup code here, to run once:
  
  Serial.begin(9600);
  dht.begin();
}

void loop() {
  // put your main code here, to run repeatedly:

  float t = dht.readTemperature();
  float h = dht.readHumidity();

  if(isnan(h) || isnan(t)) 
  {
    return;
  }

  //Gui du lieu len CSharp
  Serial.print("@");
  Serial.print(t);
  Serial.print("A");
  Serial.print(h);
  Serial.print("B");
  Serial.print("\n");

  delay(500);

}
