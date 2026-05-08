using System.Numerics;

int[] vector1 = new int [5];
int [] vector2 = new int [5];
int[] vectorSuma = new int [5];
Console.WriteLine("por favor ingrese los valores del primer vector");
for (int i = 0; i < vector1 .Length; i++)
{
    try
    {
        Console.WriteLine($"valor{i + 1}: ");
        vector1[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error : entrada no valida, por favor ingrese un mumero");
        i--; // Decrementar el indice para volver a solicitar el valor
        Console.ResetColor();
    }
}
 Console.WriteLine("por favor ingrese los valores del degundo vector");
 for (int i = 0; i < vector2.Length; i++)
{
    try
    {
        Console.WriteLine($"valor{i + 1}:");
        vector2[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error : entrada no valida, por favor ingrese un mumero");
        i--; // Decrementar el indice para volver a solicitar el valor
        Console.ResetColor();
    }
}
     // Suma los vectores
    for ( int i = 0; i < vectorSuma.Length; i++)
   {
    vectorSuma[i] = vector1[i] + vector2[i];
   }

   //Muestra el arreglo resultante
   Console.WriteLine("suma de vectores: ");
   for (int i = 0; i < vectorSuma.Length; i++)
  {
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"valor {i + i}: {vectorSuma[i]}");1
  }