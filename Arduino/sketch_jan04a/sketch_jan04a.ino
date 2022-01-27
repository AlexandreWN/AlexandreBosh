/*
int led = 3;
int potenciometro = 3;
int tempoDeEspera = 0;
void setup() {
  pinMode(led,OUTPUT);
}

void loop() {
  tempoDeEspera = analogRead(potenciometro);
  digitalWrite(led,HIGH);
  delay(tempoDeEspera);
  digitalWrite(led,LOW);
  delay(tempoDeEspera);
}
*/
/*
//Programa: Teste de Display LCD 16 x 2
//Autor: FILIPEFLOP
 
//Carrega a biblioteca LiquidCrystal
#include <LiquidCrystal.h>
 
//Define os pinos que serão utilizados para ligação ao display
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);
 
void setup()
{
  //Define o número de colunas e linhas do LCD
  lcd.begin(16, 2);
}
 
void loop()
{
  //Limpa a tela
  lcd.clear();
  //Posiciona o cursor na coluna 3, linha 0;
  lcd.setCursor(0, 0);
  //Envia o texto entre aspas para o LCD
  lcd.print("ALEXANDRE NIKITIN");
  delay(5000);
   
  //Rolagem para a esquerda
  for (int posicao = 0; posicao < 19; posicao++)
  {
    lcd.scrollDisplayLeft();
    delay(300);
  }
  
}*/

int led1 = 3;
int led2 = 5;
int led3 = 6;
int potenciometro = 0;
void setup() {
  pinMode(led1,OUTPUT);
  pinMode(led2,OUTPUT);
  pinMode(led3,OUTPUT);
}

void loop() {
  if(analogRead(potenciometro) < 300)
    analogWrite(led1,HIGH);
  if(analogRead(potenciometro) > 300)
    analogWrite(led1,LOW);
  if(analogRead(potenciometro) > 300 && analogRead(potenciometro) < 600)
    analogWrite(led2,HIGH);
  if(analogRead(potenciometro) < 300 || analogRead(potenciometro) > 600)
    analogWrite(led2,LOW);
  if(analogRead(potenciometro) > 600)
    analogWrite(led3,HIGH);
  if(analogRead(potenciometro) < 600)
    analogWrite(led3,LOW);
}
