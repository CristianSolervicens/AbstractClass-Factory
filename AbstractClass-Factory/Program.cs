
// See https://aka.ms/new-console-template for more information
using AbstractClass_Factory;

int configVal = 2;

Console.WriteLine("Hello, World!");

AbstractClass MiClase = null;

// ACOPLAMIENTO !!!
//if (configVal == 1)
//    MiClase = new FirstClass("Pepe", "Persona");
//else
//    MiClase = new SecondClass("José", "Persona");

// Las Clases Abstractas NO se pueden instanciar
// var MiClase = new AbstractClass();

try
{
    MiClase = AbstractClassFactory.GetClass("Pepe", "Persona", configVal);
}
catch (Exception ex)
{
    Console.WriteLine("Error instanciando Clase AbstractClassFactory");
    Console.WriteLine(ex.ToString());
    return;
}

//Forma indirecta NO estilo C# para detectar el error !!!
//if (MiClase == null)
//{
//    Console.WriteLine("Error instanciando MiClase");
//    return;
//}


MiClase.WhoAmI();

///////////////////////////////////////////////////////////////////////////////////////
///  
///  AC_Login  -  LoginOAuth0   LoginBasico   LoginAD(LDAP)  - AC_LoginFactory
///  
///  Llamadas a Servicios que PODRIAN variar de Cliente a Cliente
///    Obtener Usuarios, Obtener Paridad de Monedas, Obtener Comunas, Regiones, etc.
///    Obtener Sucursales
///  
///  TODO LO QUE PUDIERA LLEGAR A CAMBIAR ES UN PARAMETRO O UNA CLASE ABSTRACTA COMO SE ACABA DE VER
///  
///  IVA y otros impuestos: Siempre Paramétrico
///  
///  Todos los parámetros que deben poder leer de configuración (archivo) y "VARIABLES DE ENTORNO" !!!
///         GetEnvironmentVariable(); - DOCKERIZACION
///  
///  LAS CLASES DEBEN SER PEQUEÑAS CON UNA UNICA RESPONSABILIDAD, DE LO CONTRARIO DEBEN DESCOMPONERSE
///  EN MAS SUB CLASES... PARA OBTENER UNA FUNCIONALIDAD COMPLEJA SE PUEDE RECURRIR A LA COMPOSICION DE CLASES
///  
///  Polimorfismo: Muchas veces la composición de clases es MEJOR que la HERENCIA, sobre todo si es una CLASE
///  DESARROLLADA POR TERCEROS.
///  
///  Todo módulo o aplicación debe incorporar "Logging" con NIVELES Error, Warning, Debug  "OJO CON LOS NIVELES"
///      Estandarizar el Nombre y el Path !!!
///  
///  Al comenzar a crear un módulo o programa PARTIR CON CONTROL DE VERSION
///  
///  NUNCA utilizar Logins de Base de Dato con permiso "dbo" y mucho menos "sa"
///  
///  PREPARARSE PARA FALLAR
///  Controlar ERRORES incluso de forma EXAGERADA y EVALUAR las CONSECUENCIAS !!!
///  
///  
///  -- COMO BAJAR Visual Studio 2022 Comunity con Instalación Offline
///  
