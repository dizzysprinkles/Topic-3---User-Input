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
            Console.WriteLine();

            ////Adder - add 3 ints
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
            Console.WriteLine();
            Console.WriteLine();



            //Distance - 3 distances in km, (include decimals) prints the average - round to 2 decimals
            Double firstDistance, secondDistance, thirdDistance, averageDistance;
            Console.WriteLine("You see how good I am at adding? I think I can impress you more by showing you how I can \naverage three different distances in kilometers!");
            Console.WriteLine("Give me the first distance please!");
            Double.TryParse(Console.ReadLine(), out firstDistance);
            Console.WriteLine();

            Console.WriteLine("And what's the second distance?");
            Double.TryParse(Console.ReadLine(), out secondDistance);
            Console.WriteLine();

            Console.WriteLine("And what about the last distance?");
            Double.TryParse(Console.ReadLine(), out thirdDistance);
            Console.WriteLine();

            averageDistance = (firstDistance + secondDistance + thirdDistance)/3;

            Console.WriteLine($"Thank you kindly! And I have calculated that the average between the three is {Math.Round(averageDistance, 2)} km.");
            Console.WriteLine();
            Console.WriteLine();

            //Hypotenuse  - 2 legs and output length of hypotenuse - round to 2 decimals
            double firstLeg, secondLeg, hypotenuse;
            Console.WriteLine($"You know {name}, I don't think that's impressive enough. Would hard math be more impressive?\nWhat about trigonometry and the pythagorean theorem? ");
            Console.WriteLine();
            Console.WriteLine("I think that would be more impressive. How about you tell me the two lengths of the legs of a \nright angle triangle and I will tell you the size of the hypotenuse in meters.");
            Console.WriteLine();
            Console.WriteLine("What's the size of the first leg? ");
            Double.TryParse(Console.ReadLine(), out firstLeg);
            Console.WriteLine();

            Console.WriteLine("And the second leg? ");
            Double.TryParse(Console.ReadLine(), out secondLeg);
            Console.WriteLine();

            hypotenuse = Math.Sqrt((Math.Pow(firstLeg, 2) + Math.Pow(secondLeg, 2)));
            Console.WriteLine($"I believe that the hypotenuse would be {Math.Round(hypotenuse, 2)} m.");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Thank you, {name}, for letting me show you my math skills! ");
        }
    }
}
