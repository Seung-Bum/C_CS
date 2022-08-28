// for(초기화문; 조건문; 증감문)
// {



class Program
{
    private static void Main(string[] args)
    {
        // for문의 장점은 접근성
        // 한방에 변수를 선언후 초기화하고
        // 그걸로 조건을 비교하고
        // 그변수를 변화시키는 코드를 한단락에 다 담았다.
        // i++
        // 변수 하나와 연산자만 있으면 
        // 실행되는 연산자를 단항 연산자라고 한다.
        // 정수형 일때 ++을 하게 되면 1증가 하고
        // --를 하게 되면 1감소하게 된다.
        // 함수안에서만 사용할 수 있다.
        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine(i);
        }

        int y = 0;
        for (; y < 10; y++)
        {
            Console.WriteLine(y);
        }

        for (; true;)
        {
            Console.WriteLine("무한");
        }
    }
}