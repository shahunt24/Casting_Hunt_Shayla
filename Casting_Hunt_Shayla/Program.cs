namespace Casting_Hunt_Shayla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asks user to enter a whole number and assigns input to integer
            Console.WriteLine("Please enter a whole number!"); 
            int wholeNum = Convert.ToInt32(Console.ReadLine());

            // Prints favoite number to concsole
            Console.WriteLine("Your favorite number is " + wholeNum); 

            // Asks user a ture or false question about videogames and assigns response to boolean
            Console.WriteLine("Do you like video games? (Please enter 'true' or 'false')");
            bool isTrue = Convert.ToBoolean(Console.ReadLine());

            // Print the result of the question asked
            Console.WriteLine($"It is {isTrue} that I like video games!");
        }
    }
}
