class Player
{

    // 접근제한자를 지정하지 않으면 디폴트 설정 - private
    // private이 일반적이다. 
    // 속성들은 외부에서 접근하지 못하게 하는것이 일반적이다.
    private int LV = 1;
    private int AT;
    private int HP;
    
    // 리턴값이란 객체가 자신의 상태를 외부에 알려주는 용도로 사용
    public int GetLv()
    {   
        // 리턴 아래값은 무시가 된다.
        return LV;
    }

    public void setUp(int HP)
    {   
        // 내가 HP 0이 되는순간만 체크할 수도 있다.
        this.HP = HP;
    }

    public void LVUP()
    {
        AT = 100;
        this.HP = 3000;
    }

    // 함수는 보통 선언과 내용으로 나뉜다.
    // void[리턴값] Func[이름 혹은 식별자] ()[인자값]

    // 인자값의 개수는 여러개가 될 수 있다.

    // 리턴값은  자신이 리턴해주려는 자료형과
    // 동일한 자료형이여야 한다.
    public int Damage(int Dmg, int SubDmg)
    {
        this.HP = HP - SubDmg;
        this.HP = HP - Dmg;

        return HP;
    }


}
// 플레이어가 어떤 사양과 모양을 가졌는가


class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();    
        // 그래서 필요한 것이 함수이다.
        // HP를 0으로 맘대로 죽일 수 있게됨

        NewPlayer.setUp(1000);
        NewPlayer.LVUP();

        // 객체가 내부의 상태를 변화시키기 위해서
        // 함수를 선언하는 경우가 많습니다.
        // NewPlayer.Damage(10, 20);

        Console.WriteLine(NewPlayer.GetLv() + " => Level");
        Console.WriteLine(NewPlayer.Damage(10, 20) + " => HP");
    }
}