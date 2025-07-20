partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[5]; // Array de enteros con 5 elementos
        numbers[0] = 1;
        numbers[1] = 2;

        //Directa
        int[] numbersArray = { 3, 4, 5, 6, 7, 8 };

        //Indices
        Console.WriteLine($"Primer elemento: {numbersArray[0]}");
        Console.WriteLine($"Ultimo elemento: {numbersArray[5]}");

        //Tamaño del Array
        Console.WriteLine($"El numero de elementos es: {numbersArray.Length}");

        //Desde el final del arreglo ^
        Console.WriteLine($"Ultimo elemento: {numbersArray[^1]}");
        Console.WriteLine($"Penultimo elemento: {numbersArray[^2]}");

        //Rangos para obtener subarreglos
        int[] firstThree = numbersArray[..3];
        foreach (var number in firstThree)
        {
            Console.WriteLine(number);
        }
    }
}