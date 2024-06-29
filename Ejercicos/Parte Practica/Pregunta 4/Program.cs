// See https://aka.ms/new-console-template for more information
using Pregunta_4.Controlers;

ControlersPcNueva nueva = new ControlersPcNueva();
ControlersPcReparacion repara = new ControlersPcReparacion();   
nueva.gurdarDatos();
nueva.Mostrar();
Console.WriteLine("DATOS DE LA CLASE NUEVA PC");
Console.WriteLine();
Console.WriteLine("DARTOS DE LA CLASE REPACION PC");
repara.gurdarDatos();
repara.Mostrar();
