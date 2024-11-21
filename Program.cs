namespace _00___TileCost_Calculator;

class Program
{
    static void Main(string[] args)
    {

        const double COST_PER_HOUR = 86.00;
        const double AMOUNT_OF_SQUAREFEET = 20;
        const string CIRCULAR_ROOM_TYPE = "A";
        const string RECTANGULAR_ROOM_TYPE = "B";  
        const string NON_CIRC_NON_RECT_ROOM_TYPE = "C";
        const string TRIANGULAR_ROOM_TYPE = "D";
        
        Console.Write("Hi, this is a Tile Cost Calculator!\n\n" +
                      "In order to calculate the costs for flooring, please choose\n" +
                      "1) the shape of your room. Then enter\n" +
                      "1) the width and\n" +
                      "2) the height \n" +
                      "If you want flooring for a non-rectangular and non-circular room, you have to divide your room into smaller rectangles\n" +
                      "and provide us with the sizes for all the rectangles\n\n" +
                      "The cost per hour is 86$ and our team is able to put in 20 square feet of flooring per hour\n " +
                      "--------------\n" +
                      "Please chose the shape of your room\n" +
                      "A for Circular, B for Rectangular, C for non Rectangular and non Circular, D for Triangular\n");
        string shape;
        
        shape = Console.ReadLine().ToUpper();


        //checking if the user has a non-rectangular room. If so, he has to type in the number of rectangles.
        //This number will be used to decide how often the for-loop will be run to collect the users measurements

        if (shape != CIRCULAR_ROOM_TYPE && shape != RECTANGULAR_ROOM_TYPE && shape != NON_CIRC_NON_RECT_ROOM_TYPE && shape != TRIANGULAR_ROOM_TYPE)
        {
            Console.WriteLine("Invalid shape");
        }
        else
        {

            int numberOfRectangles = 0;
            
            if (shape == NON_CIRC_NON_RECT_ROOM_TYPE)
            {
                Console.WriteLine("In how many rectangle did you divide your room?\n");
                numberOfRectangles = Int32.Parse(Console.ReadLine());
            }

            if (shape == RECTANGULAR_ROOM_TYPE)
            {
                numberOfRectangles = 1;
            }
            
            double height = 0;
            double width = 0;
            double area = 0;
            double totalArea = 0;

            for (var counter = 0; counter < numberOfRectangles; counter++)
            {
                Console.WriteLine("1) Enter the height in feet");
                height = Double.Parse(Console.ReadLine());
                Console.WriteLine("2) Enter the width in feet");
                width = Double.Parse(Console.ReadLine());
                area = height * width;
                totalArea += area;

            }
            
            double radius = 0;

            if (shape == CIRCULAR_ROOM_TYPE)
            {
                Console.WriteLine("Enter the radius of your room: ");
                radius = Double.Parse(Console.ReadLine());
                totalArea = (radius * radius) * Double.Pi;
            }

            if (shape == TRIANGULAR_ROOM_TYPE)
            {
                Console.WriteLine("Enter the heigth");
                height = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the basis of the triangle");
                double basis = Double.Parse(Console.ReadLine());
                totalArea = 0.5 * (height * basis);
            }

            double totalCost;

            totalCost = (totalArea / AMOUNT_OF_SQUAREFEET) * COST_PER_HOUR;
            double formattedCost = Math.Round(totalCost, 2);
            Console.WriteLine($"The total cost for flooring is {formattedCost} $.");
        }
    }
}