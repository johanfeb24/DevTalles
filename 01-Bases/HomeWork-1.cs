partial class Program
{
    static void SalesReport()
    {
        string product = "Laptop";
        int quantitySold = 3;
        double unitPrecio = 750.99;
        double totalAmount = quantitySold * unitPrecio;

        Console.WriteLine($"Producto: {product}");
        Console.WriteLine($"Cantidad vendida: {quantitySold}");
        Console.WriteLine($"Total Generado: {totalAmount:C}");
    }
}