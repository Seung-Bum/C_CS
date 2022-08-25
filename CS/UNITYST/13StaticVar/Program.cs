
class Monster
{   
    // static을 붙이는 순간 공유할 수 있는 데이터로 변경됨
    static int MonsterDeathCount;

    public void Death()
    {
        MonsterDeathCount += 1;
        Console.WriteLine("MonsterDeathCount" + MonsterDeathCount);
    }
}
class Player
{   
    // static을 붙이게 되면 
    // 정적 멤버변수라고 합니다.
    // 객체화를 하지 않고도 사용할 수 있다.
    // 그 사용법이 클래스의 이름만으로 사용할 수 있다.
    public int PlayerCount = 0;

    public int AT = 10;
    public int HP = 100;

    // 클래스 내부 안에서는 사용이 가능하다.
    public void Setting(int _AT, int _HP) 
    { 
        PlayerCount = 100; // 모든 객체가 공유하는 하나의 변수

        AT = _AT;
        HP = _HP;
    }
}


namespace _13StaticVar
{
    class Program
    {
        private static void Main(string[] args)
        {   
            // 플레이어를 3번 new 하게 되면
            // 플레이어가 3개 생성됨
            // 3개의 플레이어는 각각의 hp를 가지고 있다.
            Player NewPlayer1 = new Player();
            //Player.PlayerCount = 1;
            Player NewPlayer2 = new Player();
            //Player.PlayerCount = 2;
            Player NewPlayer3 = new Player();
            NewPlayer3.Setting(10, 10);
            //Player.PlayerCount = 3;

            // static이 없을 경우 객체 하나씩 접근 가능하다.
            // 각각의 객체의 데이터가 다 다르다.

            // static이 있을 경우 여러 객체가 하나의 데이터 공유
            Console.WriteLine("PlayerCount" + NewPlayer3.PlayerCount); 

            // 이런식으로 객체화를 전혀 하지 않고 사용할 수 있는 녀석
            // 정적 멤버변수라고 부르고
            // 이런 정적 멤버변수는 데이터 영역에 들어간다. (힙이 아니라 데이터 영역)

            // 어떤 클래스가 공유하고 싶은 값
            NewPlayer1.Setting(10, 100);
            NewPlayer2.Setting(20, 50);
            NewPlayer3.Setting(100, 500);

            // NewPlayer3.PlayerCount를 가져올 수도 없다.

            Monster NewMonster1 = new Monster();
            Monster NewMonster2 = new Monster();
            Monster NewMonster3 = new Monster();

            // 모든 객체가 값을 공유할 필요가 있는 데이터를
            // 정의하는데 사용한다.
            NewMonster1.Death();// 각각 죽음카운트를 1개씩가짐
            NewMonster2.Death();
            NewMonster3.Death();
        }
    }
}
