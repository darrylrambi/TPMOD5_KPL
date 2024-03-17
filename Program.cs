// See https://aka.ms/new-console-template for more information

public class HaloGeneric
{
    public void sapauser(string input)
    {
        Console.WriteLine("Halo User " + input);
    }
}

public class DataGeneric<T>
{
    public T Data { get; set; }

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void Printdata()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + Data);
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

        DataGeneric<string> dataString = new DataGeneric<string>("1302223154");
        dataString.Printdata();
    }
}