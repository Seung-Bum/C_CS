// 컨트롤 시프트 u대문자로 변경하는 단축키
struct StructData
{   
    // = 0이 기본이다.
    public int a;
    public int b;

    public void Func()
    {
        a = 100;
        b = 100;
    }
}

class Program
{
    static void Tset(StructData _Data)
    { 
        _Data.a = 1000;
    }

    static void TestNumber(int _Number)
    {
        _Number = 1000;
    }

    private static void Main(string[] args)
    {
        int Number = 100;

        StructData NewData = new StructData();

        NewData.a = 10;
        NewData.b = 10;
        
        // 참조형과 값형이 있다.
        // 클래스를 객체화하면 그건 참조형
        Tset(NewData);
        Console.WriteLine(NewData.a); // 10

        // 값형은 함수에서 사용되고 메모리에서 없어짐 (지역변수) 스택에서 없어진다
        // 참조형(레퍼런스형) 힙영역에서 메모리에 남아있는다.

        int TestNewNumber = 100;
        TestNumber(TestNewNumber);
        Console.WriteLine(TestNewNumber); // 100

    }

}