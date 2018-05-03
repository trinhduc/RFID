#include <SPI.h>
#include <MFRC522.h>

#define SS_PIN D4
#define RST_PIN D3

MFRC522 rfid(SS_PIN, RST_PIN);
byte ID[4];
void setup() 
{
  Serial.begin(115200);
  SPI.begin();
  rfid.PCD_Init();
  Serial.println("RFID Reader !");
}
void loop() 
{
 delay(300);
  if ( !rfid.PICC_IsNewCardPresent())
    return;
  if ( !rfid.PICC_ReadCardSerial())
    return;
MFRC522::PICC_Type piccType = rfid.PICC_GetType(rfid.uid.sak);
if(piccType != MFRC522::PICC_TYPE_MIFARE_MINI &&  
    piccType != MFRC522::PICC_TYPE_MIFARE_1K &&
    piccType != MFRC522::PICC_TYPE_MIFARE_4K)
    {
      Serial.println("Cant read this card");
      return;
    }
String IDnumber="";
for(byte i = 0;i<4;i++)
{
  ID[i]=rfid.uid.uidByte[i];
  IDnumber = IDnumber+String(ID[i]);
}
Serial.print("Read ID:");
Serial.println(IDnumber);
delay(300);
}

