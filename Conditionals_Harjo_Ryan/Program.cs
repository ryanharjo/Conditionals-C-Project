namespace Conditionals_Harjo_Ryan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Output a message to the user asking them to enter a whole number
            Console.WriteLine("Enter a whole number, please!");
            // Read the input from the user, which is initially a string, and convert it to an integer
            // Convert.ToInt32 is used to convert the input string to an integer (whole number)
            int myWholeNum = Convert.ToInt32(Console.ReadLine());
            // Checks if positive or negative
            if (myWholeNum >= 0)
            {
                Console.WriteLine($"{myWholeNum} is a positive number!");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is a negative number!");
            }
            // Checks if even or odd
            if (myWholeNum % 2 == 0)
            {
                Console.WriteLine($"{myWholeNum} is an even number!");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is an odd number!");
            }
            // Creates two more integer numbers
            int num1 = 8;
            int num2 = 53;
            // Gets first max
            int firstMax = Math.Max(myWholeNum, num1);
            // Gets maximum number
            int max = Math.Max(firstMax, num2);

            // Prints max to console
            Console.WriteLine($"The maximum number of {myWholeNum}, {num1}, and {num2} is {max}!");

            // Asks user to enter a grade and assigns it to a char variable, grade 
            Console.WriteLine("Enter a grade (A, B, C, D, F)!");
            char grade = Console.ReadKey().KeyChar;
            // Prints description based on grade value 
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("\nSuperior");
                    break;
                case 'B':
                    Console.WriteLine("\nVery Good");
                    break;
                case 'C':
                    Console.WriteLine("\nAverage");
                    break;
                case 'D':
                    Console.WriteLine("\nBelow Average");
                    break;
                case 'F':
                    Console.WriteLine("\nFail");
                    break;
                default:
                    Console.WriteLine("\nYou did not enter a valid grade!");
                    break;
            }

        }
    }
}
