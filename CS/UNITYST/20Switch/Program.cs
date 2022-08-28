class Program
{
    private static void Main(string[] args)
    {   

        // 이녀석은 == 연산밖에 못한다.
        int switchTest = 100;

        switch (switchTest)
        {   
            // 오로지 상수와만 비교할 수 있다.
            case 0:
                Console.WriteLine("SwitchTest는 0 입니다.");
                break;
            case 1:
                Console.WriteLine("SwitchTest는 1 입니다.");
                break;
            case 100:
                Console.WriteLine("SwitchTest는 100 입니다.");
                break;
            default:
                break;
        }
    }
}