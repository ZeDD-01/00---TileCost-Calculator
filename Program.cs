namespace _00___TileCost_Calculator;

class Program
{
    static void Main(string[] args)
    {

        double height = 0;
        double width = 0;
        double area = 0;
        double totalArea = 0;
        double circleArea = 0;
        double tileCost;
        double totalCost;
        string shape;
        double radius = 0;
        int numberOfRectangles = 0;
        const double COST_PER_HOUR = 86.00;
        const double AMOUNT_OF_SQUAREFEET = 20;

        Console.Write("Hi, this is a Tile Cost Calculator!\n\n" +
                      "In order to calculate the costs for flooring, please choose\n" +
                      "1) the shape of your room. Then enter\n"+
                      "1) the width and\n" +
                      "2) the height \n" +
                      "If you want flooring for a non-rectangular and non-circular room, you have to divide your room into smaller rectangles\n" +
                      "and provide us with the sizes for all the rectangles\n\n" +
                      "The cost per hour is 86$ and our team is able to put in 20 square feet of flooring per hour\n " +
                      "--------------\n" +
                      "Please chose the shape of your room\n" +
                      "A for Circular, B for Rectangular, C for non Rectangular and non Circular\n");
        shape = Console.ReadLine();
       
        
        //checking if the user has a non-rectangular room. If so, he has to type in the number of rectangles.
        //This number will be used to decide how often the for-loop will be run to collect the users measurements
       
        
        
        if (shape == "C" || shape == "c")
        {
            Console.WriteLine("In how many rectangle did you divide your room?\n");
            numberOfRectangles = Int32.Parse(Console.ReadLine());
        }

        if (shape == "B" || shape == "b")
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
        
        if (shape == "A" || shape == "a")
        {
            Console.WriteLine("Enter the radius of your room: ");
            radius = Double.Parse(Console.ReadLine());
            circleArea = (radius * radius) * Double.Pi;
            totalArea = circleArea;
        } 
        

        totalCost = (totalArea/AMOUNT_OF_SQUAREFEET) * COST_PER_HOUR;
        double formattedCost = Math.Round(totalCost, 2);
        Console.WriteLine($"The total cost for flooring is {formattedCost} $.");
    }
}