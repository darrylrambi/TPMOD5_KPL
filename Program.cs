// See https://aka.ms/new-console-template for more information

public class HaloGeneric
{
    public void sapauser(string input)
    {
        Console.WriteLine("Halo User " + input);
    }
}

class main()
{
    static void Main(string[] args)
    {
        HaloGeneric input = new HaloGeneric();
        Console.WriteLine("Input: ");
        string user = Console.ReadLine();
        input.sapauser(user);

    }
}