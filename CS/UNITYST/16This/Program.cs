using System.Numerics;

class Player
{
    // 맴버변수
    // 객체가 생기면 만들어지게 되는
    private int HP = 100;

    public void Damage(int _Damage)
    {
        HP -= 100;
    }

    // 정적 맴버변수만을 정적 맴버함수에서 사용할 수 있다.
    private static int StTest = 100;

    /*
    public static void PVP(Player _left, Player _Right)
    {
        StTest = 50;
        // 이안에서 객체에 영향을 받지 않는 것이 
        // 정적 맴버함수 정적 맴버변수
        // 누구의 HP인지 모른다.
        // HP = 1000;
    }
    */

    public static void Damage(Player _this, int _Dmg)
    {   
        //this.HP; 
        // static이라 객체화 되지 않고도 사용할 수 있기 때문에
        // this 개념이 사용되지 못한다.
        // 객체들 모두가 사용하는 함수라는 것이기 때문에
        // this로 자기 자신이라는 것을 표현할 필요가 없다.
        // 모두가 쓴다는 것이기 때문에
        // static이 안붙은것은 누구의 것이라는 개념이 필요하기 때문에
        // this나 누구 객체의 것이라고 표시를 해줘야한다.

        _this.HP -= _Dmg;
    }

    // 멤버함수의 호출이란 
    // 어차피 넣을거 내가 대신 넣어줄게
    public void Heal(/* Player this, */int _Heal)
    {
        // 맴버함수에서
        // 맴버변수를 쓴다면
        // 눈에 보이지는 않지만
        // 앞에 this.이 생략된 것이다.
        this.HP += _Heal; // this는 없어도 된다.
    }

    private static void Main(string[] args)
    {
        Player NewPlayer1 = new Player();
        Player NewPlayer2 = new Player();
        Player NewPlayer3 = new Player();

        NewPlayer2.Damage(100);

        // 문법적으로 편의를 줌
        // 나 자신을 넣을 필요가 없다.
        // NewPlayer2.Heal(NewPlayer2, 100);
    }
}