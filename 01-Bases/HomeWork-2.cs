partial class Program
{
    static void DaysOfLife()
    {
        DateTime birthDate = new DateTime(1990, 02, 12);
        TimeSpan difference = DateTime.Now - birthDate;
        Console.WriteLine($"Días vividos: {difference.Days}");     
    }
}