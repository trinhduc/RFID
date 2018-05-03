#include <SPI.h>
#include <MFRC522.h>
#include <ESP8266WiFi.h>
#include <ESP8266HTTPClient.h>

const char* ssid = "DungPhan"; // ID wifi
const char* pass = "0908271812"; // pass wifi
const char* host = "192.168.0.107"; // server address
const int port = 34567; // port server

#define SS_PIN D4
#define RST_PIN D3

int i = 0;

MFRC522 rfid(SS_PIN, RST_PIN);
byte ID[4];
void setup() {
  Serial.begin(115200);
  SPI.begin();
  rfid.PCD_Init();
  Serial.println("RFID Reader !");
  WiFi.begin(ssid, pass);
  while (WiFi.status() != WL_CONNECTED)
  {
    delay(100);
    Serial.print(".");
  }
  Serial.println("Wifi connected");
  Serial.print("IP Adress: ");
  Serial.println(WiFi.localIP());
  Serial.print("Connecting to server : ");
  Serial.println(host);

}
void loop() {
  WiFiClient client;
  while (!client.connect(host, port))
  {
    Serial.print(".");
    i++;
    if (i == 10)
    {
      Serial.println();
      i = 0;
    }
  }
  delay(100);
  if ( !rfid.PICC_IsNewCardPresent())
    return;
  if ( !rfid.PICC_ReadCardSerial())
    return;
  MFRC522::PICC_Type piccType = rfid.PICC_GetType(rfid.uid.sak);
  if (piccType != MFRC522::PICC_TYPE_MIFARE_MINI &&
      piccType != MFRC522::PICC_TYPE_MIFARE_1K &&
      piccType != MFRC522::PICC_TYPE_MIFARE_4K)
  {
    Serial.println("Cant read this card");
    return;
  }
  String IDnumber = "";
  for (byte i = 0; i < 4; i++)
  {
    ID[i] = rfid.uid.uidByte[i];
    IDnumber = IDnumber + String(ID[i]);
  }
  Serial.print("Read ID:");
  Serial.println(IDnumber);
  char IDnumberarr[16]="";
  IDnumber.toCharArray(IDnumberarr, 16);
  client.write((const uint8_t *)IDnumberarr,16);
  delay(100);
  client.flush();
  client.stop();
}

