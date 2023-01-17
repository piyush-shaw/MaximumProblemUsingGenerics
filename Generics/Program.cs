using Generics;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Maximum Problem Using Generics ");
        Console.WriteLine("\n1.Maximum Integer");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.WriteLine();
                Console.WriteLine(MaximumNumber.MaximumIntegerNumber(25,48,41));
                break;
            default:
                Console.WriteLine("Invalid option ");
                break;
        }
    }
}