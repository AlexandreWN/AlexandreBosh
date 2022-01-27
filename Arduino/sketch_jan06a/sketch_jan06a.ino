#include <LiquidCrystal.h>
#include <DHT.h>
#define BOTAO 6
#define BUZZER 7
#define ESTADIOFIFA 8
#define DHTPIN 13
#define DHTTYPE DHT11   // DHT 11
DHT dht = DHT(DHTPIN, DHTTYPE);
//Define os pinos que serão utilizados para ligação ao display
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);

void setup()
{
  //Define o número de colunas e linhas do LCD
  lcd.begin(16, 2);
  lcd.setCursor(0,0);
  Serial.begin(9600);
  dht.begin();
}

void loop()
{
    delay(300);
    lcd.clear();
    lcd.setCursor(0, 0);

    if (digitalRead(ESTADIOFIFA) == HIGH){
      digitalWrite(BUZZER,HIGH);
      lcd.print("HIGH");       
    }
    else{
      digitalWrite(BUZZER,LOW);
      lcd.print("LOW");
    }
    
    float t = dht.readTemperature();
    float u = dht.readHumidity();
    if (isnan(t) || isnan (u)) {
      Serial.println("Falha ao ler do sensor DHT!");
      return;
    }
    lcd.setCursor(0, 1);
    lcd.print(t);
    lcd.print("*C");
    lcd.setCursor(9,1);
    lcd.print(u);
    lcd.print("%");
    Serial.println(t);
    Serial.println(u);
}
