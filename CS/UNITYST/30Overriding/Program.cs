
class FightUnit
{
    protected string Name = "NONE";
    protected int AT = 10;
    protected int HP = 100;


    // 이 문법의 핵심은
    // 자식에서 만약 나의 GetAT를 재구현했다면
    // 자식의 형태의 GetAT를 호출해주세요
    // 이걸 오버라이딩
    // 다형성의 핵심 문법중 하나이다.
    public virtual int GetAT()
    {
        Console.WriteLine("FightUnit의 GETAT");
        return AT;
    }

    // 프로퍼티는 virtual
    // 오버라이드 할 때 부모클래스는 virtual을 적용한다.
    protected virtual int DMGAT
    {
        get
        {
            Console.WriteLine("FightUnit의 GETAT");
            return AT;
        }
    }

    // 업캐스팅
    public void Damage(FightUnit _OtherFightUnit)
    {
        int AT = _OtherFightUnit.GetAT();

        Console.WriteLine(_OtherFightUnit.Name + "에게" + AT + "만큼의 데미지를 입었습니다.");

        HP -= AT;
    }
}


// 문법적으로 하나이나 두개인것 FightUnit이라면
// 
class Player : FightUnit 
{
    int ItemAT = 5;

    // 나는 부모님의 GetAT를 재구현 했다.
    // 부모의 접근제한자에 맞춰서 작성해야함
    protected override int DMGAT // 부모의 GetAT를 숨겨버림
    {
        get 
        {
            Console.WriteLine("플레이어의 GETAT");
            return ItemAT; 
        }
    }
    public Player(string _Name)
    { 
            // 이름 넣는것을 강제하였다. 
            // 강제하기 싫으면 이름을 파라미터 안받는 생성자 하나더 만들어야함
    }
}

class Monster : FightUnit
{

    int MonsterLv = 2; // 자식에서 추가된 변수, 이건 부모는 알 수 없다.

    public override int GetAT()
    {
        Console.WriteLine("Monster의 GETAT");
        return AT + MonsterLv;
    }

    public Monster(string _Name, int _MonsterStartLv)
    {
        Name = _Name;
        MonsterLv = _MonsterStartLv;
    }
}


class Program
{
    private static void Main(string[] args)
    {

        Player NewPlayer = new Player("플레이어"); // 이름을 넣어야함 생성자 설정 때문에
        Monster NewMonster = new Monster("몬스터", 2);

        NewPlayer.GetAT(); // 이때는 플레이어 이므로 플레이어의 GETAT 호출
        NewMonster.Damage(NewPlayer);
        NewPlayer.Damage(NewMonster);
        // 몬스터는 FightUnit을 상속받았기 때문에 
        // Damage의 파리미터로 NewMonster을 업캐스팅하여 받을 수 있다.

    }
}