partial class Program
{
    static void Generics()
    {
        string[] names = { "Ana", "Carlos", "Juan" };
        int[] numbers = { 1, 2, 3 };
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
  
}