namespace _11Memory_Value
{
    class Player
    {   
        int AT;
        int HP;
        public void Test(int Dmg) 
        {   
            // 이 안에서의 일이다
            Dmg = 1000;

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int Value = 0;
            Player NewPlayer = new Player();

            NewPlayer.Test(Value);

            Console.WriteLine(Value);
            Console.WriteLine(Value);
            Console.WriteLine(Value);

            // 값을 1000으로 변경하려면 
            // Test의 return 값을 받아서 대입 받아야함
            // Value = NewPlayer.Test(Value); => 값형 처리라고함
            // Value는 1000이다. 
        }
    }
}