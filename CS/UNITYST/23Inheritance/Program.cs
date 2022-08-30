namespace _23Inheritance
{   
    // 상속이란
    // 코드 재활용성을 향상시키기 위해서
    // (똑같은 코드 2번치기 싫다.)
    // 어떤 계열이 있느냐를 파악하는 감

    // 새로운 클래스에 그 모든 멤버변수와 함수를 넣는다.
    // 상속시킨다.

    class FightUnit
    {   
        //
        //       public protected private
        //  범위  외부    자식       나     까지

        protected int AT = 10;
        protected int HP = 100;

        public void Damage(FightUnit _OtherUnit)
        {
            // 이 안에서 플레이어의 기능을 쓰고 싶은것
            // 다운캐스팅은 최대한 지양해라
            // Player OtherPlayer = (Player)_OtherUnit;

            this.HP -= _OtherUnit.AT;
        }
    }

    // 내려준다 상속시킨다라고 말합니다.
    // C# 에서 상속이란 오직 하나만 가능하다.
    // 클래스상속을 여러개 받는 언어들도 존재하지만
    // C#은 아니다.
    class Player : FightUnit
    {
        int Lv = 1;

        void Heal()
        {
            HP = 100; // this
        }
    }

    class Monster : FightUnit
    {

    }

    class Program
    {
        private static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            Monster NewMonster = new Monster();
            // FightUnit FU = NewPlayer; // 지역변수가 되어서 메모리 잡아먹음 이거 안써도됨
            // FightUnit 알파가 NewPlayer, NewMonster이다.
            
            //  업캐스팅 자식이 부모형이 되는것
            //  그러므로 자식의 능력은 버린다.
            //  다운캐스팅은 그 반대, 다운캐스팅은 최대한 지양해라
            //  플레이어를 몬스터를 바꿀수도 있기 때문, 막 변경해서는 안될것도 바꾸면 위험
            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);
            // => 플레이어와 몬스터는 모두 파이트유닛을 상속받아서 파이트를 할 수 있다
            // 

        }
    }
}

