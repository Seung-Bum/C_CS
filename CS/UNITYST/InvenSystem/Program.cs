class Program
{
    private static void Main(string[] args)
    {
        // *****
        // *****
        // *****
        Inven NewInven = new Inven(5, 3);

        Item NewItem = new Item("철검", 100);

        while (true)
        {
            Console.Clear();
            NewInven.Render();
            Console.ReadLine();
        }
    }
}