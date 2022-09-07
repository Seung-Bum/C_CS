class Player
{
    public enum DMGTYPE
    { 
        PYDMG,
        FIREDMG,
        ICEDMG
    }

    // 물리방어
    int AttDef = 5;

    // 불방어
    int FireDef = 5;

    // 물방어
    int IceDef = 5;

    int HP = 100;

    // Damageint
    // 함수 오버로딩
    // 같은 이름은 안되지만 컴파일러가 인식할때 다르면 가능
    public void Damage(int _Damage)
    { 
        
    }

    // 자료형이 달라도 가능
    public void Damage(float _Dameage)
    { 
    
    }

    // Damageintint
    public void Damage(int _Damage, DMGTYPE _Type)
    {
        switch (_Type)
        {
            case DMGTYPE.PYDMG:
                _Damage -= AttDef;
                break;
            case DMGTYPE.ICEDMG:
                _Damage -= FireDef;
                break;
            case DMGTYPE.FIREDMG:
                _Damage -= IceDef;
                break;
            default:
                break;        
        }

        Damage(_Damage);
    }
}

class Program
{
    private static void Main(string[] args)
    {
        Player NewPalyer = new Player();

        NewPalyer.Damage(3.14f);
        NewPalyer.Damage(100, Player.DMGTYPE.FIREDMG);

    }
}