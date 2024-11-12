namespace inheritanceDemoCSharp_51;

public class Coder : Person
{
    public string ProgrammingLanguage { get; set; }

    public void Code()
    {
        Console.WriteLine("I can code!");
    }
}