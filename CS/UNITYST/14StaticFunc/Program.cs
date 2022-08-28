
public class Player
{   
    // 자기 클래스 내부에서 공개
    private int HP = 100;
    private int AT = 100;

    // 객체화를 하지 않아도 플레이어의 내부는 내부이므로
    // 접근제한 지정자에의 영향을 받지 않는다.
    public static void PVP(Player _Left, Player _Right)
    {
        _Left.HP = _Right.AT;
        _Right.HP = _Left.AT;
    }

    public void Damage(int _Damage)
    {
        HP -= 100;
    }

    // Monster에 접근 불가능, 다른 클래스
    public void Damage(Player _Other)
    { 
        
    }
} // 클래스와 시작과 끝 내부에서 제한, static

public class Monster
{
    private int AT = 100;
}

class Program
{   
    // 정적함수
    // Main의 이름을 가진 정적멤버 함수로 부터 시작된다.
    private static void Main(string[] args)
    {   
        //
        Console.WriteLine("static");

        Player NewPlayer1 = new Player();
        Player NewPlayer2 = new Player();

        // 클래스에 속하지만
        // 객체를 굳이 만들지 않고도 사용할수 있는
        // 함수를 정적멤버 함수라고 한다.
        Player.PVP(NewPlayer1, NewPlayer2);


    }
}