using Humanizer;

Console.WriteLine("Por favor ingrese un nombre: ");
var name = Console.ReadLine();

Console.WriteLine("Por favor ingrese su cargo: ");
var position = Console.ReadLine();

Console.WriteLine("Por favor ingrese su edad: "); 
var age = Console.ReadLine();

/* Necesitamos que la variable sea entera */
/* Console.WriteLine($"Mi nombre es {name}. Mi edad es {int.Parse(age).ToWords()}. Mi cargo es {position}"); */

/* Tambien podemos cambiar el idioma en el que retorna la palabra. En el caso anterior toma el idioma en el que se encuentra nuestro sistema operativo. */
Console.WriteLine($"Mi nombre es {name}. Mi edad es {int.Parse(age).ToWords(new System.Globalization.CultureInfo("en"))}. Mi cargo es {position}");
