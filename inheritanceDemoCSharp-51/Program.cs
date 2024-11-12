namespace inheritanceDemoCSharp_51;

class Program
{
    static void Main(string[] args)
    {
        var seth = new Person();
        seth.Name = "Seth";

        var john = new Coder();
        john.Name = "John";
        
        john.Greet();

        john.ProgrammingLanguage = "C#";
        
        john.Code();

        var todd = new BackEndDev();
        todd.Name = "Todd";
    }
}