
 
/// <summary>
/// partial 클래스를 나누어서 사용할 수 있다.
/// </summary>
class Program
{
    private static void Main(string[] args)
    {
        Player NewPlayer = new Player();

        NewPlayer.Damage();
        NewPlayer.EventStart();
        NewPlayer.Func();
    }
}