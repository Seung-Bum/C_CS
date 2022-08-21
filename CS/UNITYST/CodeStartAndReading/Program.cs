// os가 하나하나 내 프로그램을 읽어준다.
// 리눅스, 윈도우, 안드로이드

internal class Program
{
    private static void Main(string[] args) // main부터 읽는다고 약속을함
    {   
        // 한줄 한줄 읽는것을 ide가 도와준다.
        // F10 디버깅 (암산으로 해결하려고 하지마라, 안좋은 습관)
        Console.WriteLine("Hello, World!"); // 대괄호 사이의 내용을 읽는다.
        Console.WriteLine("Hello, hoho");
        Console.WriteLine("Hello, haha");
        Console.WriteLine("Hello, ahah");
        Console.WriteLine("Hello, aoao");
    } // 게임의 경우에는 이 지점에 도달하지 않게 한다. 종료시에는 말고
}