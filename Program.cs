namespace _00___TileCost_Calculator;

class Program
{
    static void Main(string[] args)
    {
        
        double height;
        double width;
        double tileCost;
        double totalCost;
        
        Console.Write("Hi, this is a Tile Cost Calculator!\n\n" +
                      "In order to calculate the costs for flooring, please enter\n"+
                      "1) the width and\n"+
                      "2) the height \n"+ 
                      "3) the cost per 1 unit for flooring"+
                      "Thank you\n"+
                      "--------------\n"+
                      "1) Enter the height in cm\n");
        height = Double.Parse(Console.ReadLine());
        Console.WriteLine("2) Enter the width in cm");
        width = Double.Parse(Console.ReadLine());
        Console.WriteLine("3) Please enter the cost per unit for flooring");
        tileCost = Double.Parse(Console.ReadLine());
        
        totalCost = height * width * tileCost;
        Console.WriteLine($"The total cost for flooring is {totalCost}.");
    }
}