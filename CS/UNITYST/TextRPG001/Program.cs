// 클래스는 왠만하면 자기의 일은 스스로하자
// 캡슐화
// 코드재활용성을 향상시키는 문법 "상속"


// 플레이어와 몬스터가 똑같이 공격력과, HP를 가지고 있어서
// 중복을 피하기위해 파이트유닛을 만들어 상속시킴
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

class FightUnit
{
    protected String Name = "None";
    protected int AT = 10;
    protected int HP = 50;
    protected int MAXHP = 100;

    public bool IsDeath()
    {
        // A = 100
        // 100 = A

        // 함수도 연산자에 가깝다.
        // 결과값이 있다.
        //bool boolDeath = HP <= 0;
        // 연산자도 함수에 가깝다고 했다.

        return HP <= 0;
    }

    public void StatusRender()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("**" + Name + "**");
        Console.Write("공격력 : ");
        Console.WriteLine(AT);
        Console.Write("체력 : ");
        Console.Write(HP);
        Console.Write("/");
        Console.WriteLine(MAXHP);
        Console.WriteLine("-------------------------------------");
    }

    public void Damage(FightUnit _OtherUnit)
    {
        HP -= _OtherUnit.AT;
        Console.WriteLine(_OtherUnit.Name + "이 공격 하였습니다. ");
        Console.WriteLine(Name + "은" + _OtherUnit.AT + " 데미지를 입었습니다.");
        Console.WriteLine(Name + "HP는" + HP + "이 남았습니다.");
        Console.WriteLine(" ");

        if (HP <= 0)
        {
            Console.WriteLine(_OtherUnit.Name + "님이 승리하였습니다.");            
        }
    }

}


class Player : FightUnit
{
    // 필드를 public 으로 만들어서 해결하지 말라
    // 맴버변수는 무조건 private
    private int AT = 10;
    private int HP = 50;
    private int m_MAXHP = 100;

    public int MAXHP
    {
        set 
        {
            m_MAXHP = value;
        }

        get 
        {
            return m_MAXHP;
        }  
    }
    public Player()
    {
        Name = "플레이어";
    }

    public int getAT()
    { 
        return AT;
    }

    public int getHP()
    {
        return this.HP;
    }

    public void PrintHp()
    {
        Console.Write("현재 플레이어의 HP는");
        Console.Write(HP);
        Console.WriteLine("입니다.");
        Console.ReadKey();
    }

    public int Heal(/*Player this*/)
    {
        HP = MAXHP;
        return HP;
    }
}

class Monster : FightUnit
{   
    // 인자값을 만들어 줄 수도 있다.
    public Monster(string _Name)
    {
        Name = _Name;
        AT = 5;
    }

    public int getHP()
    { 
        return this.HP;
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

        static STARTSELECT Town(Player _Player)
        {
            while (true)
            {
                Console.Clear();
                _Player.StatusRender();
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
                        return STARTSELECT.NONESELECT;
                    default:
                        break;
                }
            }
        }

        static STARTSELECT Battle(Player _Player)
        {
            Monster NewMonster = new Monster("오크");
            // FightUnit NewFight = new FightUnit();

            int PlayerHp = _Player.getHP();

            while ( false == NewMonster.IsDeath() && false == _Player.IsDeath() )
            {
                
                //if (PlayerHp <= 0)
                //{
                //    Console.WriteLine("정신을 잃었습니다. 마을로 돌아갑니다.");
                //    Town(_Player);
                //    break;
                //}

                Console.Clear();
                _Player.StatusRender();
                NewMonster.StatusRender();

                NewMonster.Damage(_Player);
                if (false == NewMonster.IsDeath())
                {
                    _Player.Damage(NewMonster);
                }

                
                // NewFight.Damage(NewMonster);
                Console.ReadKey();
            }

            if (true == NewMonster.IsDeath() || true == _Player.IsDeath() )
            {
                Console.WriteLine(" 싸움이 결판 났습니다.");

                Console.ReadKey();
            }


            

            return STARTSELECT.NONESELECT;

            /*
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
            }*/
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
            Monster NewMonster = new Monster("오크영웅");

            STARTSELECT SelectCheck = StartSelect();
            while (true)
            {
                // 함수 자체의 용도를 생각해라
                //if (SelectCheck == STARTSELECT.NONESELECT)
                //{
                //    SelectCheck = StartSelect();
                //}

                switch (SelectCheck)
                {
                    case STARTSELECT.NONESELECT:
                        SelectCheck = StartSelect();
                        break;
                    case STARTSELECT.SELECTTOWN:
                        SelectCheck = Town(NewPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        SelectCheck = Battle(NewPlayer);
                        break;
                    default:
                        break;

                }

            }

        }
    }
}
