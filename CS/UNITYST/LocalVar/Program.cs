// c# 고지식한 객체지향 언어
// 클래스 바보이다.
// 프로그램 시작조차도 클래스에 묶어야 된다.


// class는 단지 설계도이다.
class Player
{   
    // 클래스안에 있으면 멤버변수
    int Att;
    int Hp;

    void Fight()
    {
        Console.WriteLine("Hello, aoao");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 함수안에 있는 변수를 지역변수라 한다.
        int Att = 0;

        // 설계도대로 플레이러를 만든다.
        Player NewPlayer1 = new Player();
        Player NewPlayer2 = new Player();
        Player NewPlayer3 = new Player();

    }
}