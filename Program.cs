namespace InventoryManagement
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Json Inventory Management");
            string path = @"C:\Users\Achal\source\repos\InventoryManagement\InventoryManagement\jsconfig1.json";
            JsonMain main = new JsonMain();
            Inventory data = main.Read(path);
            Console.WriteLine(data.name);
            Console.WriteLine(data.weight);
            Console.WriteLine(data.price);


        }
    }

}

