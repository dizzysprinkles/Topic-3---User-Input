using System.Security.Cryptography;

namespace Topic_3____User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age, currentYear, yearBorn;
            currentYear = DateTime.Now.Year;

            //Greetings! 
            Console.WriteLine("Hello! What's your name?  ");
            name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"{name} is a wonderful name! Now, how old are you (in whole numbers)");

    
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine();

            yearBorn = currentYear - age;
            Console.WriteLine($"Oh my god {name}! So you were born in {yearBorn}?! I feel so old!");
            Console.WriteLine();

            //Adder - add 3 ints
            int firstNumber, secondNumber, thirdNumber, sum;
            Console.WriteLine($"Alright {name}, I want to show you my amazing addition skills so give me three whole numbers.");
            Console.WriteLine("What is the first number you pick?");
            Int32.TryParse(Console.ReadLine(), out firstNumber);
            Console.WriteLine();

            Console.WriteLine($"Sweet, {firstNumber} is my favourite number. What's the second number?");
            Int32.TryParse(Console.ReadLine(), out secondNumber);
            Console.WriteLine();

            Console.WriteLine("Cool! Last but not least, what's the third number you pick?");
            Int32.TryParse(Console.ReadLine(), out thirdNumber);
            Console.WriteLine();

            sum = thirdNumber + secondNumber + firstNumber;
            Console.WriteLine($"And the grand total is.... {sum}!");



            //Distance - 3 distances in km, (include decimals) prints the average - round to 2 decimals
            int firstDistance, secondDistance, thirdDistance, averageDistance;


            //Hypotenuse  - 2 legs and output length of hypotenuse - round to 2 decimals
            int firstLeg, secondLeg;

        }
    }
}
