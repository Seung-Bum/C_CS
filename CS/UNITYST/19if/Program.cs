internal class Program
{
    private static void Main(string[] args)
    {
        int Test = 100;

        // 조건문이다.
        if (Test == 100)
        {
            Console.WriteLine("Test 100 입니다.");
        }

        int ElseIfTest = 10;
        if (Test == 101)
        {
            Console.WriteLine("ElseIfTest 101 입니다.");
        }
        else if (ElseIfTest == 10)
        {
            Console.WriteLine("ElseIfTest 10입니다.");
        }

        // 꿀팁 ctrl + rr 모든 변수명 변경


        int ElseTest = 5;

        if (ElseIfTest == 10)
        {
            Console.WriteLine("ElseTest 10입니다.");
        }
        else if (ElseIfTest == 100)
        {
            Console.WriteLine("ElseTest 100입니다.");
        }
        else
        {
            Console.WriteLine("연계된 모든 조건이 거짓일 경우");
        }


    
    }
}