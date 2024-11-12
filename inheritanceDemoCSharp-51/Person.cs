namespace inheritanceDemoCSharp_51;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Height { get; set; }
    public string HairColor { get; set; }

    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name}!");
    }
}