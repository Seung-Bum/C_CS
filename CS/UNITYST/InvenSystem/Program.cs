
class Program
{
    private static void Main(string[] args)
    {
        // *****
        // *****
        // *****
        /*Inven NewInven2 = null;
        NewInven2.ItemIn(null, 10);*/


        ConsoleKeyInfo cki;

        Inven NewInven = new Inven(5, 3);
        // Item NewItem = new Item("철검", 100);
        // 뭐가 있어야 겠다.
        // 클래스
        // 속성들이 있다.
        // 아이템 배열을 맴버변수로 가졌다.

        // 넣는다. 동사.
        // 인벤에 아이템을 넣는다.
        // c#이라는 언어에 대해서 모른다.
        // 깊게 배운다음 절대로 안될거라고 생각하는
        // 녀석 존재한다면 
        NewInven.ItemIn(new Item("철검", 100));
        NewInven.ItemIn(new Item("갑옷", 100));

        NewInven.ItemIn(new Item("마나포션", 10), 10);

        // 알아서 처리해 줄거라는 생각 자체를 하지 말라.
        NewInven.ItemIn(new Item("포션", 100), 100);

        while (true)
        {
            Console.Clear();
            NewInven.Render();

            cki = Console.ReadKey();
            switch (cki.Key)
            {
                case ConsoleKey.UpArrow:
                    break;
                case ConsoleKey.DownArrow:
                    break;
                case ConsoleKey.RightArrow:
                    NewInven.NextIndex();
                    break;
                case ConsoleKey.LeftArrow:
                    break;
            }


            
            
            Console.ReadLine();
        }
    }
}