
/*void setup() {
  /*TRANSFORMA EM PINMODE*/
/*  for(int i = 1;i < 13; i++){
    if(i != 10){
       pinMode(i, OUTPUT);
    }
  }
  pinMode(10, INPUT_PULLUP);

}*/



//void loop() {
  /*ESCREVE IOT NO DISPLAY*/
  /*
  digitalWrite(2,HIGH);
  digitalWrite(3,HIGH);
  delay(2000);
  digitalWrite(2,LOW);
  digitalWrite(7,HIGH);
  digitalWrite(3,HIGH);
  digitalWrite(5,HIGH);
  digitalWrite(4,HIGH);
  delay(2000);
  digitalWrite(3,LOW);
  digitalWrite(7,HIGH);
  digitalWrite(5,HIGH);
  digitalWrite(6,HIGH);
  delay(2000);
  digitalWrite(6,LOW);
  digitalWrite(4,LOW);
  digitalWrite(7,LOW);
  digitalWrite(5,LOW);
  */
  /*QUANDO O BOTÂO È APERTADO ACENDE O LED E DIS QUE ELE ESTÁ LIGADO NO PAINEL E APARECE DESLIGADO QUANDO O BOTÂO NÂO ESTÀ PRECIONADO*/
   /*
   if(digitalRead(10) == LOW){
    digitalWrite(7,LOW);
    digitalWrite(3,LOW);
    digitalWrite(12, HIGH);
    digitalWrite(6,HIGH);
    digitalWrite(5,HIGH);
    digitalWrite(4,HIGH);
  }else{
    digitalWrite(12, LOW);  
    digitalWrite(4,LOW);
    digitalWrite(6,LOW);
    digitalWrite(7,HIGH);
    digitalWrite(3,HIGH);
    digitalWrite(4,HIGH);
  }
  */
  /*#include <LiquidCrystal.h>

LiquidCrystal lcd(12, 11, 5, 4, 3, 2);

void setup() {
  lcd.begin(16, 2);
  lcd.clear();
  lcd.setCursor(0,0);
  lcd.print("Hello");
  lcd.setCursor(0,1);
  lcd.print("World!");
  // put your setup code here, to run once:

}

void loop() {
  lcd.setCursor(0,0);
  lcd.print("Hello");
  lcd.setCursor(0,1);
  lcd.print("World!");
  // put your main code here, to run repeatedly:

}*/

#include <LiquidCrystal.h>
 
//Define os pinos que serão utilizados para ligação ao display
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);
 
void setup()
{
  //Define o número de colunas e linhas do LCD
  lcd.begin(16, 2);
  lcd.setCursor(0,0);
}

void loop()
{
  //Limpa a tela
  lcd.clear();
  //Posiciona o cursor na coluna 3, linha 0;
  lcd.setCursor(3, 0);
  //Envia o texto entre aspas para o LCD
  lcd.print("FILIPEFLOP");
  lcd.setCursor(3, 1);
  lcd.print(" LCD 16x2");
  delay(5000);
   
  //Rolagem para a esquerda
  for (int posicao = 0; posicao < 3; posicao++)
  {
    lcd.scrollDisplayLeft();
    delay(300);
  }
   
  //Rolagem para a direita
  for (int posicao = 0; posicao < 6; posicao++)
  {
    lcd.scrollDisplayRight();
    delay(300);
  }
}
