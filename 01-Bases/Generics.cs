using System.Runtime.InteropServices.Marshalling;

partial class Program
{
    static void Generics()
    {
        string[] names = { "Ana", "Carlos", "Juan" };
        int[] numbers = { 1, 2, 3 };
        System.Console.WriteLine($"Tamaño del arreglo numerico:{GetIntArrayLength(numbers)} ");
        System.Console.WriteLine($"Tamaño del arreglo de nombres:{GetStringArrayLength(names)}");
        System.Console.WriteLine($"Tamaño del arreglo de nombres:{GetArrayLength(names)}");
        System.Console.WriteLine($"Tamaño del arreglo numerico:{GetArrayLength(numbers)}");

    }

    ///Metodos sin Genericos
    static int GetIntArrayLength(int[] array)
    {
        return array.Length;
    }
    static int GetStringArrayLength(string[] array)
    {
        return array.Length;
    }

    //Metodo Generico
    static int GetArrayLength<T>(T[] array)
    {
       return array.Length; 
    }
  
}