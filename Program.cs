

using More_C_Sharp_Practice.Math;

namespace CSharpFundamentals
{


    class Program
    {

        static void Main(string[] args)
        {
            //changing the console :)
            Console.ForegroundColor = ConsoleColor.DarkYellow;


            //------------------------------------------- Basic Stuff -------------------------------------------


            //instantiating a new instance of person
            var john = new Person();
            john.FirstName = "John ";
            john.LastName = "Smith";

            john.Introduce(); //calling method from person class--greeting


            //instantiating a new calculator instance and calling add method from calculator class
            Calculator calculator = new Calculator();
            Console.WriteLine("\nThe number you are looking for is " + calculator.Add(1, 2) + ".");


            //basic array practice

            var numbers = new int[3];

            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);


            //boolean arrays 
            var flags = new bool[3];

            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);


            //basic string instantiation and practice
            var basicNames = new string[3] { "Jack", "John", "Mary" };


            var firstName = "Be-Asia";
            var lastName = "McKerracher";

            //basic concatenation
            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            //using string.Format to create the string
            var anotherFullName = string.Format("Mu name is {0} {1}", firstName, lastName);
            Console.WriteLine(anotherFullName);


            //string.join
            var newNames = new string[3] { "Jessica", "Riley", "Kevin" };
            var formattedNames = string.Join(", ", newNames);
            Console.WriteLine(formattedNames);

            //verbatim strings

            var text = @"Hey babes!
             I'm off to the store
             don't forget to feed the dogs!";
            Console.WriteLine(text);




            //---------------------------------------------------------- Enum work ---------------------------------------------------------------

            //calling an Enum
            var newEnum = ShippingMethod.Express;

            //converting an enum to and from an int
            Console.WriteLine("\n" + (int)newEnum);

            var enumId = 3;
            Console.WriteLine((ShippingMethod)enumId);

            //converting an enum to a string
            Console.WriteLine("\n" + newEnum); //or newEnum.ToString


            //converting a string to an enum
            var enumName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), enumName);


            //------------------------------------------------- Reference and Value Types --------------------------------


            //using string.Format
            var firstInt = 10;
            var secondInt = firstInt;
            secondInt++;
            Console.WriteLine(string.Format("\nfirstNumber: {0}, secondNumber: {1}", firstInt, secondInt));


            //reference types using arrays
            var array1 = new[] { 1, 2, 3 };

            var array2 = array1;

            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

            //----------------------- Working with reference methods (increment and make old) -------------------------------


            var anyNumber = 1;

            Increment(anyNumber);
            Console.WriteLine(anyNumber);
            //anyNumber is 1 despite line 129--because it is referencing the same place--not two separate places


            var anotherPerson = new AnotherPerson() { Age = 20 };
            MakeOld(anotherPerson);
            Console.WriteLine(anotherPerson.Age);



            //--------------------------------------- conditional practice -----------------------------------------------



            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                System.Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                System.Console.WriteLine("it's afternoon.");
            }
            else
            {
                System.Console.WriteLine("it's evening.");
            }


            bool isGoldCustomer = false;


            //        //general condtional
            //float price;
            //        if (isGoldCustomer)
            //        {
            //price = 19.95f;
            //        }
            //        else
            //        {
            //         price = 29.95f;
            //        }

            //quick conditional--learn this!

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            System.Console.WriteLine(price);




            var season = Seasons.Fall;

            switch (season)
            {
                case Seasons.Fall:
                case Seasons.Summer:
                    Console.WriteLine("We're doing a promotion");
                    break;

                case Seasons.Winter:
                    Console.WriteLine("Winter's so chill :)");
                    break;

                case Seasons.Spring:
                    Console.WriteLine("Yay for sprint!");
                    break;

                default:
                    Console.WriteLine("I don't know what season it is");
                    break;




            }

            Console.Read();
        }





		//---------------------------------- not part of main: methods , classes outside main, etc. ----------------------------------------------


        //working with switchcases


        public enum Seasons
        {
            Spring,
            Summer,
            Fall,
            Winter
        }

        //enum shipping method

		public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3

        }


        //reference type method work

        public class AnotherPerson
        {
            public int Age;
        }

        public static void Increment(int anyNumber)
        {
            anyNumber += 10;
        }

        public static void MakeOld(AnotherPerson anotherPerson)
        {
            anotherPerson.Age += 10;
        }


    }
}