namespace NestedLoopPractice
{
    internal class Program
    {
        //put spaces between printed row symbols
        //ask for new user input, keeping row/column preferences for 1 run?
        static void Main(string[] args)
        {
            Console.Write("Let's draw a solid box with symbols. How many rows do you want? ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nAlright, now how many columns do you want? ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNow, what symbol do you want to use? ");
            string symbol = Console.ReadLine();

            for (int rowIndex = 0; rowIndex < rows; rowIndex++) //row index starts at 0, as long as its of lower value than user input rows it grows by 1
            {
                for (int columnIndex = 0; columnIndex < columns; columnIndex++) 
                    //same logic behind for loop of row, and for each instance of a written row "block" i.e symbol, column grows by 1 
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }



        }
    }
}
