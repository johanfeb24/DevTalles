using System.IO.Compression;
using System.Security.AccessControl;

partial class Program
{
    static void InventoryManager()
    {
        Console.WriteLine("----- Venta Tecnologica -----");
        Console.WriteLine("Escoja una de las siguientes opciones:");
        Console.WriteLine("1. Comprar Producto");
        Console.WriteLine("2. Salir");
        string? option = Console.ReadLine();
        if (option == "1")
        {
            string[] products = ["Laptop", "Mouse", "Keyboard", "Monitor", "Printer"];
            int[] stock = [10, 50, 30, 20, 15];
            double[] prices = [999.99, 19.99, 49.99, 199.99, 299.99];
            Console.WriteLine("Inventario de Productos:");
            Console.WriteLine("--------------------------");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Precio: ${prices[i]:F2}");
            }
            System.Console.WriteLine("\nIngrese el producto que desea comprar: ");
            string? searchedProduct = Console.ReadLine();
            System.Console.WriteLine(("Ingrese la cantidad que desea comprar"));
            int quantity = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
                {
                    if (stock[i] >= quantity)
                    {
                        stock[i] -= quantity;
                        double totalPrice = prices[i] * quantity;
                        Console.WriteLine($"Compra exitosa! Total a pagar: ${totalPrice:F2}");
                        Console.WriteLine($"Stock restante para el producto {searchedProduct} es: {stock[i]}");
                    }
                    else
                    {
                        Console.WriteLine("Stock insuficiente para completar la compra.");
                    }
                    return; // Salir del bucle una vez encontrado el producto
                }
            }
        }
        else if (option == "2")
        {
            Console.WriteLine("Gracias por visitar nuestra tienda. ¡Hasta luego!");
            return;
        }
        else
        {
            Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
        }
    }
}