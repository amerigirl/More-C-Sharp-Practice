
using More_C_Sharp_Practice.Math;

namespace CSharpFundamentals
{
    class Program
    {

        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John ";
            john.LastName = "Smith";
            
            //john.Introduce(); //introduces
            Calculator calculator = new Calculator();

            //Console.WriteLine("\nThe number you are looking for is " + calculator.Add(1, 2) + ".");


            //array practice
            var numbers = new int[3];

            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);


            var flags = new bool[3];

            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);


            var names = new string[3] {"Jack", "John", "Mary"};



        }
        
    }


}