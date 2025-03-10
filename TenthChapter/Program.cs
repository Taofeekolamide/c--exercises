class Cat
{
    public string Name{get; set;}
    static void Cat(string name)
    {
        this.Name = name;
    }

    public void SayMeow()
    {
        Console.WriteLine($"{this.Name}");
    }

    static void Main()
    {
        Cat cat = new Cat("olamide");
        cat.SayMeow();
    }
}