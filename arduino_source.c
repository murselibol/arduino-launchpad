#include <SoftwareSerial.h>
#include <String.h>

int counter = 0;

void setup() {
  // init phase
  pinMode(10, OUTPUT);
  pinMode(7, INPUT);
  Serial.begin(9600);
  while(!Serial){
    ;
  }
}

void loop() {
    // each button has a specific range of voltage. (some calculations...)
    int btn_value = analogRead(buton);
    
    if(btn_value<1030 && btn_value>1000){
      delay(100);
      Serial.println("A1");
      delay(100);
    }
    if(btn_value<999 && btn_value>950){
      delay(100);
      Serial.println("A2");
      delay(100);
    }
    if(btn_value<949 && btn_value>900){
      delay(100);
      Serial.println("A3");
      delay(100);
    }
    if(btn_value<899 && btn_value>850){
      delay(100);
      Serial.println("A4");
      delay(100);
    }
    if(btn_value<849 && btn_value>800){
      delay(100);
      Serial.println("A5");
      delay(100);
    }
    if(btn_value<799 && btn_value>750){
      delay(100);
      Serial.println("A6");
      delay(100);
    }
}

void autoplay_loop() {
  // this loop works without buttons, for testing purposes.
  delay(100);
  Serial.print("A1\n");
  delay(300);
  Serial.print("A2\n");
  delay(300);
  Serial.print("A3\n");
  delay(300);
  Serial.print("A4\n");
  delay(300);
  Serial.print("A5\n");
  delay(300);
  Serial.print("A6\n");
  delay(300);
  Serial.print("A7\n");
  delay(300);
  Serial.print("A8\n");
  delay(300);
  Serial.print("A9\n");
  delay(300);
  Serial.print("A10\n");
  delay(300);;
  Serial.print("A11\n");
  delay(300);
  Serial.print("A12\n");
  delay(300);
  Serial.print("A13\n");
  delay(100);
  Serial.print("A14\n");
  delay(300);
  Serial.print("A15\n");
  delay(300);
  Serial.print("A16\n");
  delay(300);
  Serial.print("A17\n");
  delay(300);
  Serial.print("A18\n");
  delay(300);
  Serial.print("A19\n");
  delay(300);
  Serial.print("A20\n");
  delay(300);
  Serial.print("A21\n");
  delay(300);
  Serial.print("A22\n");
  delay(300);
  Serial.print("A23\n");
  delay(300);;
  Serial.print("A24\n");
  delay(300);
  Serial.print("A25\n");
  delay(300);
  Serial.print("A26\n");
  delay(100);
  Serial.print("A27\n");
  delay(300);
  Serial.print("A28\n");
  delay(300);
  Serial.print("A29\n");
  delay(300);
  Serial.print("A30\n");
  delay(300);
  Serial.print("A31\n");
  delay(300);
  Serial.print("A32\n");
  delay(1700);
  Serial.print("A33\n");
  delay(1700);
  Serial.print("A34\n");
  delay(1700);
  Serial.print("A35\n");
  delay(1700);
  Serial.print("A36\n");
  delay(1700);
  Serial.print("A37\n");
  delay(1700);
  Serial.print("A38\n");
  delay(1700);
  Serial.print("A39\n");
  delay(1700);
}