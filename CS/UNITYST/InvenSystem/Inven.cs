using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 나는 아이템을 담아두는 인벤토리를 만들고 싶다.
// 나는 인벤토리를 만들어 질때
// 인벤토리가 최대 몇개를 담을 수 있는지 부터
// 정하지 않으면 인벤토리를 new 할 수도 없어야 한다.
// 이때 숫자가 두개 필요한데
// x와 y이다
// 그럼 담을 수 있는 아이템의 총 개수는??
// x * y
class Inven
{
    // 만들어 질 때
    Item[] ArrItem;
    int ItemX;

    // 잘못쓰기도 힘들게 만들어라
    // 인벤토리를 new 하려면 
    // int X와 Y를 넣어주는 방법 밖에 없게 만들었다.
    public Inven(int _X, int _Y)
    {
        // 초보프로그래머가 가장 주의해야 할 것
        // 방어코드는 선택이 아니다.
        // 방어코드란 무엇이냐??
        // switch문의 디폴트 같은것
        // 혹은 프로그램이 터지거나 오작동하지 않게
        // 들어오는 값들을 체크해서 문제가 없게 만드는 코드
        // 함수나 이런곳에서 인자값을 받을때
        // 이걸 검사하고 사용한다 1.(무조건 1번을 선택해야함)
        // 이걸 사용한다 2.
        if (1 > _X)
        { 
            _X = 1;
        }

        if (1 > _Y)
        {
            _Y = 1;
        }

        ItemX = _X;
        ArrItem = new Item[(_X * _Y)];
    }

    public void Render()
    {
        for (int i = 0; i < ArrItem.Length; i++)
        {   
            // i % 5
            if (0 != i && 0 == i % ItemX)
            {
                Console.WriteLine("");
            }

            // 15개의 아이템을 가질 수 있는 인벤
            // i번째에 아이템이 있니?
            if (null == ArrItem[i])
            {
                Console.WriteLine("□");
            }
            else
            {
                Console.WriteLine("■");
            }
               
        }
    }
}

