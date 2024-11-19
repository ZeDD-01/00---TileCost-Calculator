namespace _00___TileCost_Calculator;

class Program
{
    static void Main(string[] args)
    {

        double height = 0;
        double width = 0;
        double area = 0;
        double totalArea = 0;
        double tileCost;
        double totalCost;
        string isRectangular;
        int numberOfRectangles = 0;
        const double COST_PER_HOUR = 86.00;
        const double AMOUNT_OF_SQUAREFEET = 20;

        Console.Write("Hi, this is a Tile Cost Calculator!\n\n" +
                      "In order to calculate the costs for flooring, please enter\n" +
                      "1) the width and\n" +
                      "2) the height \n" +
                      "3) the cost per 1 unit for flooring\n" +
                      "If you want flooring for a non-rectangular room, you have to divide your room into smaller rectangles\n" +
                      "and provide us with the sizes for all the rectangles\n" +
                      "--------------\n" +
                      "Is your room rectangular?\n" +
                      "Please type Y for Yes and N for No\n");
        isRectangular = Console.ReadLine();
       
        
        //checking if the user has a non-rectangular room. If so, he has to type in the number of rectangles.
        //This number will be used to decide how often the for-loop will be run to collect the users measurements
        if (isRectangular == "N" || isRectangular == "n")
        {
            Console.WriteLine("In how many rectangle did you divide your room?\n");
            numberOfRectangles = Int32.Parse(Console.ReadLine());
        }

        if (isRectangular == "Y" || isRectangular == "y")
        {
            numberOfRectangles = 1;
        }

        for (var counter = 0; counter < numberOfRectangles; counter++)
        {
            Console.WriteLine("1) Enter the height in feet");
            height = Double.Parse(Console.ReadLine());
            Console.WriteLine("2) Enter the width in feet");
            width = Double.Parse(Console.ReadLine());
            area = height * width;
            totalArea += area;
           
        }
        
        

        totalCost = (totalArea/AMOUNT_OF_SQUAREFEET) * COST_PER_HOUR;
        Console.WriteLine($"The total cost for flooring is {totalCost} $.");
    }
}