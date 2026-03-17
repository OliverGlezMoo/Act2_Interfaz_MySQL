# CIBERINFRAESTRUCTURA
## Act2_Interfaz_MySQL
### Requisitos
Generación de una interfaz gráfica con conexión a MySQL.

#### Base de datos
Para esta actividad vamos a crear una base de datos usando como ejemplo la empleada en la actividad 1 de esta clase, tomando solo una clase CatPersonal.

  create database Act2;

  CREATE TABLE IF NOT EXISTS `Act2`.`CatPersonal` (
  
    `ID` INT NOT NULL AUTO_INCREMENT,
    
    `Nombre` VARCHAR(80) NOT NULL,
    
    `Cargo` VARCHAR(80) NOT NULL,
    
    PRIMARY KEY (`ID`))
    
  ENGINE = InnoDB;

#### Código
Para el codigo emplee 5 textbox en lo cual el usuario rellenara segun los datos pertinentes pedidos.

DataGridView con el cual poder mostrar los datos (filas/registros) contenidos dentro de la tabla CatPersonal en la base de datos Act2

Boton conectar al cual al momento de dar clic establecera una conexion con nuestra base de datos empleando la clase MySql.Data.MySqlClient.

A su vez es necesario agregar al proyecto el Paquete MySql.Data dentro de la seccion de herramientas como un administrador de paquetes NuGet

#### Evidencias
<img width="596" height="279" alt="1" src="https://github.com/user-attachments/assets/506a0614-162f-479b-8b26-47fbc3f208d7" />

Ejecutamos nuestra interfaz desde visual studio.

<img width="731" height="279" alt="2" src="https://github.com/user-attachments/assets/c0640c3d-07f7-460b-9350-4312429df62b" />

Rellenamos los datos correspondientes y damos clic al botón Conectar

<img width="731" height="279" alt="3" src="https://github.com/user-attachments/assets/21291b41-5e36-47f4-ba1b-662e85a94097" />

Se nos mostrara la totalidad de registros contenidos dentro de nuestra base de datos usando la sentencia (SELECT * FROM CatPersonal).
