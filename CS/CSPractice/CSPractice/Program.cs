// See https://aka.ms/new-console-template for more information
using CSPractice;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Foreach forPractice = new Foreach();

        ForeachXml foreachXml = new ForeachXml();

        //forPractice.foreachPractice();

        foreachXml.foreachXml();
    }
}