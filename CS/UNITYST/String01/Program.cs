namespace _25String01
{
    // 언어는 숨쉬는것
    // 붉은줄이 왜 갔는가?
    // 프로그래밍에 있어서 기본기 3가지
    // 디버깅 (95%)
    // 문자열
    // 파일입출력

    class Program
    {   
        // 리턴값이 없어서 오류
        //Func()
        //{ 
        
        //}
        private static void Main(string[] args)
        {
            // 동적 기본자료형이다.
            char Charactor = 'a';

            // string은 char의 집합
            string TEST = "aaaa";

            Console.WriteLine(TEST);

            // 자료형은 c#에서 만들어놓은 기본구조체이다.

            int AAA = 1000; // 얘도 클래스고 C#에서 만들어준
            TEST = AAA.ToString();
            // int도 멤버함수나 이런게 있다.

            // int도 구조체고 내부의 멤버변수나 함수가 존재하고
            // 그것을 통해서 문자열로 변환이 가능하다.
            string Left = "안녕하세요";
            string Right = "날씨가 좋네요";

            string Result = Left + Right;
            Console.WriteLine(Left + Right + TEST);
            




            // 자료형이 다르다.
            //int A = 'gkgkgk';
            //int B = 2;
        }
    }
}
