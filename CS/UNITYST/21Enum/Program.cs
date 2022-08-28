// 기본 자료형 -> 이미 있다.

// 사용자 정의자료형중 하나
// class : 참조형 사용자 정의
// struct : 값형 사용자 정의
// enum : 값형 사용자 정의

// 다른 언어에서는 정수형 상수라고 하는데 정수형 상수 C#에서는 아니다.
// 보통 어떤 상태를 표현하는것중
// 나만의 것을 가지고 싶을때 사용한다.

enum ITEMTYPE
{   
    // 내가 값의 범위를 지정한 새로운 자료형을
    // 만들어 낼수 있다는 장점이 있고
    // Switch와 궁합이 정말 좋다.
    EQUIP,
    POTION,
    QUEST,
    NONESELECT
}

// 클래스를 다 따로 따로 만들수도 있지만
// EQUIP, POTION, QUEST ..
// 1000개의 클래스를 만든다??
class Item
{
    // int ItemType = 0; // 0이면장비, 1이면 포션, 2면 ... 이러면 가독성이 떨어지게 된다.
    // 
    // 아이템 타입
    public ITEMTYPE ItemType = ITEMTYPE.EQUIP;

    public void TypeSetting()
    { 
        ItemType = ITEMTYPE.NONESELECT;
    }
}

class Program
{   
    private static void Main(string[] args)
    {
        Item NewItem = new Item();
        Console.WriteLine("0: " + NewItem.ItemType);

        NewItem.ItemType = ITEMTYPE.POTION;
        Console.WriteLine("1: " + NewItem.ItemType);

        // 값형이고
        // int라고 생각해도 된다.
        // ITEMTYPE ItemType = 6; 당연히 대입되지 않는다. 한번 사용되고 없어짐

        NewItem.TypeSetting();
        Console.WriteLine("2: " + NewItem.ItemType);

        Console.WriteLine("3: " + ITEMTYPE.POTION);

        // 값형이면서 사용자 정의자료형
        ITEMTYPE Type = ITEMTYPE.POTION;

        switch (Type)
        {
            case ITEMTYPE.EQUIP:
                break;
            case ITEMTYPE.POTION:
                break;
            case ITEMTYPE.QUEST:
                break;
            case ITEMTYPE.NONESELECT:
                break;
            default:
                break;
        }
    }
}