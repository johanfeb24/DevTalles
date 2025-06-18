partial class Program
{
    static void HandleNullables()
    {
        //No Nullificable
        string firstName = "Johan";

        //Nulificable
        string? lastName = null;
        Console.WriteLine($"Nombre:{firstName}");
        if (lastName != null)
        {
            Console.WriteLine($"Apellido:{lastName}");
        }
        else
        {
            Console.WriteLine("Apellido no proporcionado");
        }

        //Operador de coalescencia nula
        Console.WriteLine($"Apellido:{lastName ?? "No proporcionado!"}");

        //Operador de qacceso nulo seguro .?
        string? text = null;
        Console.WriteLine(text?.Length);
    }
}