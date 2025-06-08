partial class Program
{
    static void ShowStringTypes()
    {
        string name = "Johan";
        string message = "Hola " + name;
        string interpolacion = $"Hola {name}";
        Console.WriteLine(message);
        Console.WriteLine(interpolacion);              
    }
}