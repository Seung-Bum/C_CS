
namespace _26Property
{
    class Player
    {
        public int HP = 20;

        static int m_StaticValue = 100;
        public static int StaticValue
        {
            get
            {
                return m_StaticValue;
            }

            set
            {
                m_StaticValue = value;
            }
        }



        int AT = 10;

        // 마치 멤버변수 같음
        // 자료형을 선언했다면 이는 int와 관련된 함수라고
        // 명시하는것
        public int ProAT
        {   
            // 프로퍼티의 GET 함수는 무조건 int를
            // 리턴한다고 보고
            get 
            { 
                return AT;
            }

            // 무조건 int하나가 들어온다고 생각한다.
            // 그런 외부 값들을 프로퍼티에서는
            // value라고 기호로 정의해 놓았다.
            set 
            { 
                AT = value;
            }
        }

        public int GetAT()
        { 
            return AT;
        }

        public void SetAT(int _Value)
        {
            if (999 < _Value)
            {
                Console.WriteLine("최대 공격치를 넘었습니다.");
                    while (true) { Console.ReadKey(); }
            }

            AT = _Value;

            
        }

    }

    class Program
    {
        private static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            Player.StaticValue = 200;

            NewPlayer.ProAT = 100;
            int PlayerAT = NewPlayer.ProAT;

            NewPlayer.HP = 80;

            //NewPlayer.SetAT(9999999);
        }
    }
}
