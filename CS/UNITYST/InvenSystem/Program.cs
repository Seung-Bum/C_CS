class Program
{
    private static void Main(string[] args)
    {
        // *****
        // *****
        // *****
        Inven NewInven = new Inven(5, 3);

        while (true)
        {
            Console.Clear();
            NewInven.Render();
            Console.ReadLine();
        }
    }
}