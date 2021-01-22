# Proyectos

Tabla_de_contenido
=================

<!--ts-->
   * [Tabla de contenido](#Tabla_de_contenido)
   * [Introduccion](#Introduccion)
   * [Proyectos](#Proyectos)
      * [Detectar](#Detectar)
      * [Prueba Proyecto](#Prueba_Proyecto)
      * [UnlockFaceV2](#UnlockFaceV2)
      * [FaceID](#FaceID)
      * [WebUF](#WebUF)
   * [Documentacion](#Documentacion)
      
<!--te-->


Introduccion
=========
  El objetivo principal del proyecto es lograr que un plantel tenga una forma rápida, eficaz y segura de acceso para que el personal pueda ingresar o salir, además de informar los usuarios sobre la hora de la entrada y salida.
  

Proyectos
=====


Detectar
-----
  Sistema desarrollado en Csharp para la administración y control de la información de los usuarios. Este sistema se conecta a una base de datos(MYSQL) para almacenar dicha información, también usamos un lector de huellas controlado por un arduino para tener un identificador de cada usuario y así controlar la entrada y salida. 


Prueba_Proyecto
-----------
  Sistema basado en nuestro proyecto anterior(Detectar) en esta version mejoramos la interfaz gráfica, las validaciones, la seguridad y demás aspectos en la base de datos, se cambio el uso de huella dactilar como identificador a reconocimiento facial por medio de Inteligencia Artificial (IA) y se adapto la interfaz para este cambio.
  
UnlockFaceV2
------------
  Script codificado en Python en el IDE (Jupyter notebook) se uso: Opencv, Redes Convolucionales(Red siamesa), fórmulas matemáticas para convertir el rostro en vectores además de implementar la distancia euclidania para identificar cada rostro ya por último utilizamos tkinter para la interfaz. 

FaceID
--------------
  Aplicación codificada en Kotlin usando el IDE Android Studio con la finalidad de informar a los usuarios la hora de entrada y salida del personal. Se usarón servicios de Google como "Firebase" y sus extenciones para la autenticación de los emails de los usuarios, además de que este tenía conexión directa a la base de datos del proyecto.


WebUF
-----
  Página Web que tiene la finalidad de brindar toda la información general del proyecto UnlockFace, cuenta con los apartados de cada módulo y un breve video explicativo.


Documentacion 
-----
  Para saber mas sobre nuestro proyecto ponemos a su dispocición la documentación principal que se encuentra en el pdf llamado "Documentacion Unlock Face".
