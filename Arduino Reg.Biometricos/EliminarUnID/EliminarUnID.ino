
// Esta librería ha sido desarrollada para la version de Arduino 1.8.5
// y en caso de encontrarse BUGS en futuras versiones de Arduino
// El soporte lo encontrarán en el Canal de Youtube "Innova Domotics"
// https://www.youtube.com/c/innovadomotics en el vídeo dedicado al
// SENSOR DE HUELLA cuyas actualizaciones estarán en enlaces descargables 
// en la descripción del vídeo
//--------------------------------------------------------------------
// Esta librería no se ha testeado con versiones anteriores de Arduino
//--------------------------------------------------------------------

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
    
    if (MySensorDactilar.VerificarClave()) {
      Serial.println("Sensor de Huella Encontrado :)  :) ");
    } else {
      Serial.println("No fue posible encontrar al sensor de Huella  :(  :( ");
      while (1);
    }

    byte TotalRegistrados = (byte)MySensorDactilar.ContarRegistrados();
    Serial.print("El sensor tiene "); Serial.print(TotalRegistrados); Serial.println(" usuarios registrados");

}

void loop()                     
{ 
  Serial.println("Ingrese el numero del ID que desea eliminar: ");
  
  uint8_t my_id = 0;
  while (true) {
    while (! Serial.available());
    char c = Serial.read();
    if (! isdigit(c)) break;
    my_id *= 10;
    my_id += c - '0';
  }
  Serial.print("Eliminando ID #");
  Serial.println(my_id);
  
  EliminarUN_ID_DACTILAR(my_id);    
}

void EliminarUN_ID_DACTILAR(uint8_t id) {
  uint8_t p = -1;
  
  p = MySensorDactilar.EliminarModelo(id);

  if (p == SDACTILAR_OK) {
    Serial.println("ID Eliminado!");
  } else if (p == SDACTILAR_PAQUETE_IN_ERROR) {
    Serial.println("Error en Comunicacion");
    return p;
  } else if (p == SDACTILAR_ERROR_UBICACION) {
    Serial.println("No es posible eliminar en dicha ubicacion");
    return p;
  } else if (p == SDACTILAR_ERROR_FLASH) {
    Serial.println("Error escribiendo en la flash");
    return p;
  } else {
    Serial.print("Error Desconocido: 0x"); Serial.println(p, HEX);
    return p;
  }   
}
