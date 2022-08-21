
// 내가 처음으로 해야할 일
// 내가 RPG를 만들고 싶다.
// 클래스를 만든다.


class Player
{   
    // 세가지 접근제한자
    public int Att; // 외부 공개
    protected int Hp; // 자식 공개
    private int Def; // 내부 공개

    public void Fight()
    {
        Console.WriteLine("싸운다");
    }
}

class Program
{
    static void Main(string[] args)
    { 

        // 객체지향의 캡슐화 은닉화
        // 접근제한 지정자

        Player NewPlayer = new Player();

        // 만들어진 객체의 내용을 사용하기 위해서는
        // 객체의 이름뒤에 .을 넣는다.
        NewPlayer.Att = 100;
        NewPlayer.Fight();

        // 접근제한자에 의한 제어
        // NewPlayer.Hp = 0;  
        // NewPlayer.Def = 100;
    }
}