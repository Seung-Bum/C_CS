class Program
{
    private static void Main(string[] args)
    {

        // continue와
        // break는 가장 가까운 반복문의 for(증감문) while(조건문)
        // 

        for (int j = 1; j < 100; j++)
        {
            if (0 == j % 50)
            {
                break;
            }
            Console.WriteLine(j);
        }

        for (int i = 0; i < 10; i++)
        {
            if (0 == i % 2)
            { 
                // 만약 이 문장을 만나면
                // while 문에도 통한다.
                // 반복문의 증감문으로 바로 이동한다.
                continue;
            }
            Console.WriteLine(i);
        }

    }
}