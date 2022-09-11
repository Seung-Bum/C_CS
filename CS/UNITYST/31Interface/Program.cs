// 사용자 정의 자료형인데
interface QUESTUnit
{
    // 맴버변수를 넣을수 없다. (필드)
    //int A = 0;

    // 함수의 형태만 물려줄 수 있다.
    // 무조건 public
    void Talk(QUESTUnit _OtherUnit);

    void Event(QUESTUnit _OtherUnit);

}

// 비슷한 성격의 클래스를 다중 상속받을 경우 문제가 생긴다.
// 도대체 어떤걸 사용해야 하는가?
class SKillUnit
{
    int AT;
}

class FightUnit
{
    int AT;
    int DMG;

    public void Damage()
    { 
        
    }
}

// 기능을 추가하기 위해 상속을 여러개 받을 수 없다.
// 함수 구현을 강제 할 수 있다.
// 인터페이스는 상속이라고 안하는 사람도 있다.
// 상속의 개념보다는 포함의 개념이다.
// 인터페이스를 상속받았다고 치면
// 나는 talk를 구현해야함
class Player : FightUnit, QUESTUnit
{
    public void Talk(QUESTUnit _OtherUnit)
    { 
    
    }

    public void Event(QUESTUnit _OtherUnit)
    { 
    
    }

}

class Monster : FightUnit
{ 

}

class NPC : FightUnit , QUESTUnit
{
    public void Talk(QUESTUnit _OtherUnit)
    {

    }

    public void Event(QUESTUnit _OtherUnit)
    {

    }
}

class Program
{
    private static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        NPC NewNPC = new NPC();

        // 한통속으로 관리할 수 있다.
        // 안에 맴버변수나 이런걸 가질 수 없다.
        // 너는 뭐를 구현해야해 라고 하는 형태만 상속
        // QUESTUnit QuestUnit = new QUESTUnit();

        QUESTUnit NewQuestUnit = NewNPC;


        // 업캐스팅이 된다.
        NewPlayer.Talk(NewNPC);
        NewNPC.Talk(NewPlayer);

    }

}