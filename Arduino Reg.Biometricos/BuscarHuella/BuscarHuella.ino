
#include <InnovaS_Dactilar.h>
#include <SoftwareSerial.h>

// pin #2 - Entrada desde el Sensor  (cable verde)
// pin #3 - Salida de desde Arduino  (cable blanco)

SoftwareSerial MySerial(2, 3);

uint32_t ClaveSensorHuella = 0;
InnovaS_Dactilar MySensorDactilar = InnovaS_Dactilar(&MySerial, ClaveSensorHuella);

void setup()
{ 
    Serial.begin(57600);
    Serial.println("Sensor de Huella");
  
    //Setea la velocidad de comunicacion con el sensor de huella
    //Iniciar verificando los valores de 9600 y 57600
    MySensorDactilar.begin(57600);
    
    if (MySensorDactilar.VerificarClave()) 
    {
      Serial.println("Sensor de Huella Encontrado :)  :) ");
    } 
    else 
    {
      Serial.println("No fue posible encontrar al sensor de Huella  :(  :( ");
      while (1);
    }
}

void loop()                     
{ 
   BuscarID_Huella();
   delay(10);  
}

void BuscarID_Huella(void) 
{
  int p = -1;
  p = MySensorDactilar.CapturarImagen();
  if (p != SDACTILAR_OK)  return;
  p = MySensorDactilar.GenerarImg2Tz();
  if (p != SDACTILAR_OK)  return;
  p = MySensorDactilar.BusquedaRapida();
  if (p != SDACTILAR_OK)  return;
  Serial.print("Encontrado ID #"); Serial.print(MySensorDactilar.Id_Dactilar); 
  Serial.print(" con seguridad: "); Serial.println(MySensorDactilar.Seguridad);
}
