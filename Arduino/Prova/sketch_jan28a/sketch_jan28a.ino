#include <DHT.h>
#include <DHT_U.h>

#include <WiFi.h>
#include <FirebaseESP32.h>

#define WIFI_SSID "Redmi Note 8"
#define WIFI_PASSWORD "12345678"
#define FIREBASE_HOST "https://prova-8aed1-default-rtdb.firebaseio.com/"
#define FIREBASE_AUTH "jMq3R0gDXGCPHHVH1x5cyNScx6f7f8qnXzA5fBnu"

FirebaseData firebaseData;
FirebaseJson json;

int botao = 35;
int led1 = 23;
int led2 = 21;
int led3 = 18;
int led4 = 2;
int parar = 0;
//DISPLAY
#include <LiquidCrystal.h>
LiquidCrystal lcd(13,12,14,27,26,25);
//DHT

#define DHTTYPE DHT11
DHT dht(4, DHTTYPE);

void wifiConect(){
    WiFi.begin(WIFI_SSID,WIFI_PASSWORD);
    while (WiFi.status() != WL_CONNECTED){// enquando não estiver conectado
    Serial.print(".");
    delay(300);
    }
}

void conectFireBase(){
  Firebase.begin(FIREBASE_HOST,FIREBASE_AUTH); // inicia o firebase
  Firebase.reconnectWiFi(true);               
  Firebase.setReadTimeout(firebaseData, 100*60);
  Firebase.setwriteSizeLimit(firebaseData, "tiny");
}

void setup() {
  pinMode(botao, INPUT_PULLUP);
  pinMode(led1, OUTPUT);
  pinMode(led2, OUTPUT);
  pinMode(led3, OUTPUT);
  pinMode(led4, OUTPUT);
  Serial.begin(9600);
  lcd.begin(16, 2);
  Serial.println("DHTxx test!");
  dht.begin();
  lcd.clear();
  wifiConect();
  conectFireBase();
}

void loop() {
  float h = dht.readHumidity();
  float t = dht.readTemperature();
  // testa se retorno é valido, caso contrário algo está errado.
  digitalWrite(led1, LOW);
  digitalWrite(led2, LOW);
  digitalWrite(led3, LOW);
  if(digitalRead(botao) == LOW){
    if (isnan(t) || isnan(h)) 
    {
      Serial.println("Failed to read from DHT");
    } 
    else
    {
      digitalWrite(led4, HIGH);
      json.set("/temperatura", t);
      json.set("/umidade", h);
      Firebase.updateNode(firebaseData, "/Sensor", json);
      digitalWrite(led4, LOW);
      Serial.print("Umidade: ");
      Serial.print(h);
      Serial.print("Temperatura: ");
      Serial.print(t);
      Serial.println(" *C");
      lcd.setCursor(0, 0);
      lcd.print(h);
      lcd.print(" Umidade");
      lcd.setCursor(0, 1);
      lcd.print(t);
      lcd.print(" Temperatura");
      if(t <= 25){
        digitalWrite(led1, HIGH);
      }
      if(t > 25 && t <27){
        digitalWrite(led2, HIGH);
      }
      if(t >= 27){
        digitalWrite(led3, HIGH);
      }
      delay(30000);
    }
  }
  else{
    lcd.clear();
    lcd.print("TCHAU");
    delay(500);
  }
}
