
// 여러개의 프로젝트를 하나의 솔루션으로 관리한다.

// 시작 프로그램 설정 ( 우클릭 )

// 각자의 프로젝트는 각각의 EXE 파일을 만든다.
// 컨트롤 F5를 누르면 EXE가 생성된다. (실행파일)

// 솔루션을 우클릭하고 속성에서 현재선택영역을 시작프로그램으로 설정하면 작업중인 영역에서 바로 실행시킬 수 있다.

// 추가 -> 솔루션 폴더 (실제 폴더 생성은 아니고 정리용)

// 와우본체.exe
// 와우맵에디터.exe
// 와우스킬에디터.exe
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}