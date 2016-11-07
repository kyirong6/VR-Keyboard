/*
  AnalogReadSerial
  Reads an analog input on pin 0, prints the result to the serial monitor.
  Graphical representation is available using serial plotter (Tools > Serial Plotter menu)
  Attach the center pin of a potentiometer to pin A0, and the outside pins to +5V and ground.

  This example code is in the public domain.
*/

// the setup routine runs once when you press reset:
void setup() {
  // initialize serial communication at 9600 bits per second:
  Serial.begin(9600);
}

// the loop routine runs over and over again forever:
void loop() {
  // read the input on analog pin 0:
   int sensorValue0 = analogRead(A0);
  // print out the value you read:
  //Serial.println(sensorValue0);
 // Serial.print("\t");

if(sensorValue0>600&&sensorValue0<750)
{
  Serial.write(7);
 // Serial.println("7");
  Serial.flush();
 // delay(300);
}
if(sensorValue0>750)
  {
    Serial.write(77);
   // Serial.println("77");
    Serial.flush(); 
  }


  delay(1);        // delay in between reads for stability

    int sensorValue1 = analogRead(A1);
  // print out the value you read:
  //Serial.print(sensorValue1);
 // Serial.print("\t");

  if(sensorValue1>550&&sensorValue1<700)
{
  Serial.write(8);
  Serial.flush();

}
if(sensorValue1>700)
  {
    Serial.write(88);
    Serial.flush(); 
  }

  delay(1);        // delay in between reads for stability

    int sensorValue2 = analogRead(A2);
  // print out the value you read:
  //Serial.print(sensorValue2);
 // Serial.print("\t");


  if(sensorValue2>700&&sensorValue2<800)
{
  Serial.write(19);
  Serial.flush();

}
if(sensorValue2>800)
  {
    Serial.write(99);
    Serial.flush(); 
  }

  delay(1);        // delay in between reads for stability

    int sensorValue3 = analogRead(A3);
  // print out the value you read:
 // Serial.print(sensorValue3);
//  Serial.print("\t");

  if(sensorValue3>550&&sensorValue3<725)
{
  Serial.write(4);
  Serial.flush();
}
if(sensorValue3>725)
  {
    Serial.write(44);
    Serial.flush(); 
  }

  delay(1);        // delay in between reads for stability

    int sensorValue4 = analogRead(A4);
  // print out the value you read:
 // Serial.print(sensorValue4);
 // Serial.print("\t");

  if(sensorValue4>775&&sensorValue4<900)
{
  Serial.write(5);
  Serial.flush();

}
if(sensorValue4>900)
  {
    Serial.write(55);
    Serial.flush(); 
  }

  delay(1);        // delay in between reads for stability

    int sensorValue5 = analogRead(A5);
  // print out the value you read:
 // Serial.print(sensorValue5);
 // Serial.print("\t");

  if(sensorValue5>520&&sensorValue5<725)
{
  Serial.write(6);
  Serial.flush();

}
if(sensorValue5>725)
  {
    Serial.write(66);
    Serial.flush(); 
  }

  delay(1);        // delay in between reads for stability

      int sensorValue6 = analogRead(A6);
  // print out the value you read:
 // Serial.print(sensorValue6);
//  Serial.print("\t");

  if(sensorValue6>625&&sensorValue6<775)
{
  Serial.write(1);
  Serial.flush();
}
if(sensorValue6>775)
  {
    Serial.write(11);
    Serial.flush(); 
  }

  delay(1);        // delay in between reads for stability

      int sensorValue7 = analogRead(A7);
  // print out the value you read:
 // Serial.print(sensorValue7);
// Serial.print("\t");

  if(sensorValue7>580&&sensorValue7<725)
{
  Serial.write(2);
  Serial.flush();

}
if(sensorValue7>725)
  {
    Serial.write(22);
    Serial.flush(); 
  }
    if (sensorValue7<580)

  delay(1);        // delay in between reads for stability

      int sensorValue8 = analogRead(A8);
  // print out the value you read:
 // Serial.println(sensorValue8);
 Serial.print("\t");

  if(sensorValue8>540&&sensorValue8<610)
{
  Serial.write(3);
  Serial.flush();

}
if(sensorValue8>610)
  {
    Serial.write(33);
    Serial.flush(); 
  }

    
  delay(5);        // delay in between reads for stability
}
