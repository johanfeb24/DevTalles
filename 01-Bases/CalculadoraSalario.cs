partial class Program
{
    static void CalculadoraSalario()
    {
        double salario;
        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingresa el numero de horas trabajadas: ");
        double horasTrabajadas = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el valor por hora: ");
        double valorPorHora = double.Parse(Console.ReadLine());
        salario = horasTrabajadas * valorPorHora;
        
        Console.WriteLine($"El salario para {nombre} es: ${salario:N2}");
    }
}