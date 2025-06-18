using System.Runtime.CompilerServices;

partial class Program
{
    static void TypeDifference()
    {
        //Tipo de Valor
        int x = 5;
        int y = x;
        y = 15;
        Console.WriteLine($"x:{x}, y:{y}");

        //Tipo de Referencia
        Person person1 = new Person { Name = "Carlos" };
        Person person2 = person1;
        person2.Name = "Ana";
        Console.WriteLine($"person1.Name: {person1.Name}");
    }
}
class Person
{
    public string? Name{ get; set; }
}