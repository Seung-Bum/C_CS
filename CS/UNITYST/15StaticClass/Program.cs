// 정적 클래스란
// 정적 맴버변수와
// 정적 맴버함수만을 가질수 있는 클래스이다.
static class StClass
{   
    // 일반 맴버변수는 선언만해도 오류가 나게 된다.
    //int TEST = 100;
}

class Player
{
    static int Number = 100;

    private static void Main(string[] args)
    {
        Console.WriteLine("정적멤버 함수");
    }
}