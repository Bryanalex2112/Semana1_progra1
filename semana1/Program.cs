// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using semana1.Entidades;
using semana1.Negocio;
//per es una variable/objeto que ba a ser utilizada para setear la informacio de la clase persona(entidades)
persona per = new persona();

//Clspersona es una variable/objeto que va a ser utilizada para invocar la lojica de nuetra aplicacion
ClsTratamientoDePersonas ClsPersona= new ClsTratamientoDePersonas();

//Console.ReadLine es utilizado para capturar la informacion de usuario

Console.WriteLine("ingresa tu nombre");
string? variableNombre = Console.ReadLine();

Console.WriteLine("ingresa tu Edad");
string? variableEdad = Console.ReadLine();
int EdadConvert = Convert.ToInt32(variableEdad);

per.Nombre =  variableNombre;
per.edad = EdadConvert;

String Resultado = ClsPersona.ObtenerNombrePersona(per);
String ResultadoEdad = ClsPersona.mayorDeEdad(per);

Console.WriteLine(Resultado);
Console.WriteLine(ResultadoEdad);
