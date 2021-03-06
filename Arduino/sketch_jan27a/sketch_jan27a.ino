#include <LiquidCrystal.h>
#include <WiFi.h>
#include <FirebaseESP32.h>

#define BAUD_RATE 9600
#define ANALOG_PIN A0

#define Led 32

#define WIFI_SSID "Redmi Note 8"
#define WIFI_PASSWORD "12345678"
#define FIREBASE_HOST "https://esp32-fbcfe-default-rtdb.firebaseio.com/" // configurando o host do firebase
#define FIREBASE_AUTH "b7BEMSmZx5hNifccqg2nBBhQCoqyAcXMeY4AkpNw"   

LiquidCrystal lcd(13,12,14,27,26,25);

FirebaseData firebaseData;
FirebaseJson json;

int readLDRSensor(){
  int ldrValue = map(analogRead(ANALOG_PIN),0,4095,0,100);
  return ldrValue;
}

void initSerial(){
    Serial.begin(BAUD_RATE);
    Serial.setDebugOutput(false);
    //Wait for port to be open
    while (!Serial) {
    }
    Serial.println();
    Serial.println("Connected to serial port on baud rate 9600");
}

void wifiConect(){
    WiFi.begin(WIFI_SSID,WIFI_PASSWORD);
    while (WiFi.status() != WL_CONNECTED){// enquando não estiver conectado
    Serial.print(".");
    delay(300);
    }
}

void inLcd(){
  lcd.clear();
  lcd.setCursor(0, 0);
}

void conectFireBase(){
  Firebase.begin(FIREBASE_HOST,FIREBASE_AUTH); // inicia o firebase
  Firebase.reconnectWiFi(true);               
  Firebase.setReadTimeout(firebaseData, 100*60);
  Firebase.setwriteSizeLimit(firebaseData, "tiny");
}

void setup() {
  lcd.begin(16, 2);
  initSerial();
  wifiConect();
  conectFireBase();
  pinMode(Led, OUTPUT);
}

void loop() {
  int l = readLDRSensor();
  Serial.println(l);
  inLcd();
  lcd.print(l);
  json.set("/Luminosidade",l);
  digitalWrite(Led, HIGH);
  Firebase.updateNode(firebaseData,"/Sensor/Alexandre",json);
  digitalWrite(Led, LOW);
  delay(15000);
}
