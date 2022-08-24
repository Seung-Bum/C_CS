namespace _12Memory02_Reference
{
    class Monster
    {
        public int AT = 10;
        public int HP = 100;

        public void ATT(Player player)
        {   
            // 몬스터의 공격으로 플레이어의 HP를 감소시킴
            player.HP -= AT;
        }
    }

    class Player
    {
        public int AT = 10;
        public int HP = 100;

        public void ATT(Monster monster)
        {   
            // 플레이어의 공격으로 몬스터의 HP를 감소시킴
            monster.HP -= AT;
        }
    }

    class Program
    {
        private static void Main(string[] args)
        {   
            // 값형과 레퍼런스 형을 구분할 줄 알아야 한다.
            // 기본자료형을 선언만 하면 그녀석들은 값형이다.
            
            // 자기가 만든 클래스를 new 클래스명();
            // 해서 만든것을 그 클래스명에 받으면 
            // 그건 레퍼런스형이다.

            // 클래스가 객체화된 녀석은
            // 레퍼런스형이라고 하느 자료형이 되고

            // int, bool 이런 녀석들은 값형이라고 한다.
            // 값형과 레퍼런스형은 메로리의 위치와 사용법이 다르다.

            // mew Monster();는 힙에 올라간다. 안의 값도 같이 올라간다.
            // 레퍼런스 - 힙에 생성된 어떠한 메모리의 위치를 가리키는 값이다.
            Monster NewMonster = new Monster();
            Player NewPlayer = new Player();

            // 힙에 올라간 HP를 깍는다.
            NewMonster.ATT(NewPlayer);
            NewPlayer.ATT(NewMonster);

            Console.WriteLine(NewPlayer.HP);
            Console.WriteLine(NewMonster.HP);

            // 스택: 함수의 실행 메모리 영역안에 들어있는 지역변수 
            
        }
    }
}
    