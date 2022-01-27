#include <DHT.h>
#define DHTPIN 34 // pino que estamos conectado
#define DHTTYPE DHT11 // DHT 11
DHT dht(DHTPIN, DHTTYPE);

#include <WiFi.h>
#include <FirebaseESP32.h>
/*#define WIFI_SSID "Vivo-Internet-BF17"//nome de WiFi
#define WIFI_PASSWORD "78814222" // senha do WiFi*/
#define WIFI_SSID "Galaxy A318713"
#define WIFI_PASSWORD "12345678"
#define FIREBASE_HOST "https://dsmod3-default-rtdb.firebaseio.com/" // configurando o host do firebase
#define FIREBASE_AUTH "4k6JNrElbIda17kE2eqdhFayrlY8yuMU9lcKKBBE"   

FirebaseData firebaseData;
FirebaseJson json;
void setup() {
  Serial.begin(9600);
  WiFi.begin(WIFI_SSID,WIFI_PASSWORD);
  while (WiFi.status() != WL_CONNECTED){// enquando não estiver conectado
    Serial.print(".");
    delay(300);
  }
  Serial.print("Connected with IP: ");//se conectar ao WiFi mostra o IP da rede
  Serial.print(WiFi.localIP());
  //conectando ao firebase
  Firebase.begin(FIREBASE_HOST,FIREBASE_AUTH); // inicia o firebase
  Firebase.reconnectWiFi(true);               
  Firebase.setReadTimeout(firebaseData, 100*60);
  Firebase.setwriteSizeLimit(firebaseData, "tiny");
}

void loop() {
  float h = dht.readHumidity();
  float t = dht.readTemperature();
  //configurando o firebase
  json.set("/temperatura",t);
  json.set("/humidade",h);
  Firebase.updateNode(firebaseData,"/Sensor/Alexandre",json);
  delay(500);
}
