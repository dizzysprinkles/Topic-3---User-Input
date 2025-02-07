namespace Topic_3____User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            int age, currentYear, yearBorn;
            currentYear = DateTime.Now.Year;

            //Greetings! 
            Console.WriteLine("Hello! What's your name?  ");
            firstName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"{firstName} is a wonderful name! Now, how old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine();

            yearBorn = currentYear - age;
            Console.WriteLine($"Oh my god {firstName}! So you were born in {yearBorn}?! I feel so old!");
            Console.WriteLine();



        }
    }
}
