using Generics;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Maximum Problem Using Generics ");
        Console.WriteLine("\n1.Maximum Integer \n2.Maximum Floating");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.WriteLine("Maximum Integer Number");
                Console.WriteLine(MaximumNumber.MaximumIntegerNumber(25,48,41));
                break;
            case 2:
                Console.WriteLine("Maximum Floating Number");
                Console.WriteLine(MaximumNumber.MaximumFloatNumber(8.6,5.9,9.8));
                break;
            default:
                Console.WriteLine("Invalid option ");
                break;
        }
    }
}