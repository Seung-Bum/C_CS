// 클래스는 왠만하면 자기의 일은 스스로하자
// 캡슐화
class Player
{   
    // 필드를 public 으로 만들어서 해결하지 말라
    // 맴버변수는 무조건 private
    private int AT = 10;
    private int HP = 50;
    private int MAXHP = 100;

    public int getAT()
    { 
        return AT;
    }

    public int getHP()
    {
        return this.HP;
    }

    public void SatatusRender()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("**플레이어**");
        Console.Write("공격력 : ");
        Console.WriteLine(AT);
        Console.Write("체력 : ");
        Console.Write(HP);
        Console.Write("/");
        Console.WriteLine(MAXHP);
        Console.WriteLine("-------------------------------------");
    }

    public void Heal()
    {
        HP = MAXHP;
    }
}

class Monster
{
    private int HP = 10;
    private int AT = 5;
    private int MAXHP = 10;

    public int getHP()
    { 
        return this.HP;
    }

    public void Damage(Player _Player)
    {
        HP -= _Player.getAT();       
    }

    public void SatatusRender()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("**몬스터**");
        Console.Write("공격력 : ");
        Console.WriteLine(AT);
        Console.Write("체력 : ");
        Console.Write(HP);
        Console.Write("/");
        Console.WriteLine(MAXHP);
        Console.WriteLine("-------------------------------------");
    }

}

namespace TextRPG001
{
    class Program
    {
        enum STARTSELECT
        { 
            SELECTTOWN,
            SELECTBATTLE,
            NONESELECT
        }

        // 시작한다.
        // 마을로 갈지 싸움터로 갈지를 정해주는 함수
        static STARTSELECT StartSelect()
        {
            Console.Clear();
            Console.WriteLine("어디로 가시겠습니까?");
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 배틀");

            //ConsoleKeyInfo CKI = Console.ReadKey();

            Console.WriteLine("");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine(" 마을로 이동합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.D2:
                    Console.WriteLine(" 배틀을 시작합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                default:
                    Console.WriteLine(" 잘못된 선택입니다.");
                    Console.ReadKey();
                    return STARTSELECT.NONESELECT;
            }

            // 리턴이 되는 순간 함수를 완전히 종료시킨다.
        }

        static void Town(Player _Player)
        {
            while (true)
            {
                Console.Clear();
                _Player.SatatusRender();
                Console.WriteLine("마을에서 무슨일을 하시겠습니까?");
                Console.WriteLine("1. 체력을 회복한다.");
                Console.WriteLine("2. 무기를 강화한다.");
                Console.WriteLine("3. 마을을 나간다.");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        _Player.Heal();
                        Console.WriteLine("플레이어 HP : " + _Player.getHP);
                        Console.WriteLine("체력을 회복했습니다.");
                        break;
                    case ConsoleKey.D2:
                        //
                        break;
                    case ConsoleKey.D3:
                        return;
                    default:
                        break;
                }
            }
        }

        static void Battle(Player _Player, Monster _Monster)
        {
            while (true)
            {
                Console.Clear();
                _Player.SatatusRender();
                _Monster.SatatusRender();
                Console.WriteLine("사냥터에서 무엇을 하겠습니까?");
                Console.WriteLine("1. 몬스터 공격");
                Console.WriteLine("2. 사냥터를 나간다.");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        
                        if (_Monster.getHP() <= 0)
                        {
                            Console.WriteLine(" 몬스터 Kill");
                            Console.ReadKey();
                            break;
                        }
                        else 
                        {
                            _Monster.Damage(_Player);
                            Console.WriteLine(" 몬스터를 공격했습니다.");
                            Console.WriteLine(" 몬스터 HP : " + _Monster.getHP());
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.D2:
                        //
                        break;
                    default:
                        break;
                }
            }
        }

        private static void Main(string[] args)
        {
            // 객체지향 프로그래밍이란
            // 결국 클래스로 설계하고
            // 객체로 만들어 나가는 것

            // (메모장으로 정리한다. 시나리오) 
            // 저는 마을과 싸움터로 나눠서 싸우고 싶다.
            // 1. 마을로간다 - 2. 사냥터로 간다.
            // 반복문과 조건문중 어떤걸??

            //while (true)
            //{
            //    // 객체화 하지 않고도 쓸 수 있는 함수
            //    // static 함수, 정적맴버 변수
            //    ConsoleKeyInfo KeyInfo = Console.ReadKey(); // 어떤 값을 눌렀는지 누를때까지 기다려줌

            //    Console.WriteLine(KeyInfo.Key);
            //}

            Player NewPlayer = new Player();
            Monster NewMonster = new Monster();

            while (true)
            {   
                // 함수 자체의 용도를 생각해라
                STARTSELECT SelectCheck = StartSelect();

                switch (SelectCheck)
                {
                    case STARTSELECT.SELECTTOWN:
                        Town(NewPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        Battle(NewPlayer, NewMonster);
                        break;
                    default:
                        break;

                }

            }

        }
    }
}
