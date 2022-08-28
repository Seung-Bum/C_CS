class Program
{
    private static void Main(string[] args)
    {
        bool check = true;
        while (check)
        {
            Console.WriteLine("무한출력");
            check = false;
        }

        // 실행코드 -> 조건
        int Count = 0;
        do
        {
            Count += 1; 
            Console.WriteLine(Count);
        } while (Count < 5);


    }
}