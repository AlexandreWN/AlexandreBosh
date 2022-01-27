#include <Servo.h>
#define SERVO 10
Servo s;

void setup() {
  // put your setup code here, to run once:
  s.attach(SERVO);
  pinMode(A3,INPUT);
}
float x = 0;
void loop() {
  // put your main code here, to run repeatedly:
  x = analogRead(A3);
  x = x/4;
  s.write(x);
}
