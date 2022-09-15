class Player
{
    private int mAT;

    public int AT 
    { 
        get { return mAT; }
        set { mAT = value; } 
    }
}

class Program
{
    private static void Main(string[] args)
    {

        Player NewPlayer = new Player();
        // 가리키는게 없이 비워 놓겠다.
        // 참조형의 데이터 구조를 가리키는 자료형들은 클래스는
        // new를 하게 되면

        Player NewPlayer2 = null;

        Console.WriteLine(NewPlayer.AT);
        Console.WriteLine(NewPlayer2.AT);

    }
}