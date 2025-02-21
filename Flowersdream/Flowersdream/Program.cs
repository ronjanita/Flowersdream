class Program
{
    static void Main()
    {
        Console.WriteLine("Flowers are still considered pretty even when they dont always bloom the same, look the same or smell the same.");
        Console.WriteLine("Humans are considered special, weird or ugly as soon as they look different, act different or get old.");
        Question();
    }

    static void Question()
    {

        Console.WriteLine("Would you rather be a flower or a human? (f/h)");
        Console.ReadLine();
        string answer = Console.ReadLine();
        if (answer == "f")
        {
            Console.WriteLine("Beeing a flower is for sure really calming.");
        }
        else
        {
            Console.WriteLine("Beeing a Human must be nice too sometimes.");
        }
    }
    
}