using Generics;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Maximum Problem Using Generics ");
        Console.WriteLine("\n1.Maximum Integer \n2.Maximum Floating \n3.Maximum String \n4.Maximum Using Generic Method "
            + "\n5.Maximum Using Generic Class \n6.Extend Max Value \n7.Print Max Value");
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
            case 3:
                Console.WriteLine("Maximum String");
                Console.WriteLine(MaximumNumber.MaximumString("Apple","Peach","Banana"));
                break;
            case 4:
                Console.WriteLine("Maximum using Generic Method");
                Console.WriteLine("Maximum For Integer "+MaximumGenericMethod.MaxValue(10,15,11));
                Console.WriteLine("Maximum For Float "+ MaximumGenericMethod.MaxValue(9.1f,7.9f,8.7f));
                Console.WriteLine("Maximum For String "+ MaximumGenericMethod.MaxValue("Bengaluru","Delhi","Kolkata"));
                break;
            case 5:
                Console.WriteLine("Maximum using Generic Class");
                Console.WriteLine("Maximum For Integer " + MaximumGenericClass<int>.MaxValue(100, 115, 211));
                Console.WriteLine("Maximum For Float " + MaximumGenericClass<float>.MaxValue(19.1f, 27.9f, 18.7f));
                Console.WriteLine("Maximum For String " + MaximumGenericClass<string>.MaxValue("Apple", "Peach", "Banana"));
                break;
            case 6:
                Console.WriteLine("Extend Max Value");
                int[] arr = { 101, 156, 167, 183, 176 };
                GenericMaximum<int> generic = new GenericMaximum<int>(arr);
                Console.WriteLine(generic.MaxValue());
                break;
            case 7:
                Console.WriteLine("Print Max Value");
                int[] intarr = { 101, 156, 167, 183, 176 };
                GenericMaximum<int> intnum = new GenericMaximum<int>(intarr);
                intnum.PrintMaxValue();
                float[] floatarr = { 101f, 196f, 167f, 183f, 176f };
                GenericMaximum<float> floatnum = new GenericMaximum<float>(floatarr);
                floatnum.PrintMaxValue();
                string[] stringarr = { "Apple", "Peach", "Banana"};
                GenericMaximum<string> stringnum = new GenericMaximum<string>(stringarr);
                stringnum.PrintMaxValue();
                break;
            default:
                Console.WriteLine("Invalid option ");
                break;
        }
    }
}