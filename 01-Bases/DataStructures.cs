partial class Program
{
    static void DataStructures()
    {
        User Johan = new User { Name = "Johan", Age = 35 };
        Johan.Greet();
        Point punto = new Point { X = 30, Y = 20 };
        Console.WriteLine($"Punto({punto.X},{punto.Y})");
        Cellphone celular = new Cellphone("Xiaomi", 2022);
        Console.WriteLine(celular);
    }
}
class User
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public void Greet()
    {
        Console.WriteLine($"Hola, soy el usuario {Name} y tengo una edad de {Age} años.");
    }
}

struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}
record Cellphone(string Model, int Year);