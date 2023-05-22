namespace CalculationOfShape;
class Program
{
    static void Main(string[] args)
    {
        CalculationOfShape.MainMenu();
    }
}

public static class CalculationOfShape
{
    static int shape = 0; 
    static int calcutaion = 0;
    public static void MainMenu(){
        int chose = 0;
        Back:
        System.Console.WriteLine("--- Calculation Of Shapes Menu ---");
        System.Console.WriteLine("1 - Circle\n2 - Triangle\n3 - Square\n4 - Rectangle\n0 - Exit");
        System.Console.Write("Please, choose one from the menu for which shape you will calculate: ");
        if(!Int32.TryParse(Console.ReadLine(), out chose)){
            System.Console.WriteLine("You made the wrong choice. Please, enter a number!");
            Thread.Sleep(1000);
            goto Back;
        }
        switch (chose)
        {
            case 1:
                shape = 1;
                SubMenu();
                break;
            case 2:
                shape = 2;
                SubMenu();
                break;
            case 3:
                shape = 3;
                SubMenu();
                break;
            case 4:
                shape = 4;
                SubMenu();
                break;
            case 0:
                break;
            default:
                System.Console.WriteLine("You made the wrong choice. Please, choose one from the menu.");
                Thread.Sleep(1000);
                goto Back;
        }
        
    }
    public static void SubMenu(){
        int chose = 0;
        Back:
        System.Console.WriteLine("--- Calculation Menu ---");
        System.Console.WriteLine("1 - Field\n2 - Perimeter\n0 - Exit");
        System.Console.Write("Please, choose one from the menu for which shape you will calculate: ");
        if(!Int32.TryParse(Console.ReadLine(), out chose)){
            System.Console.WriteLine("You made the wrong choice. Please, enter a number!");
            Thread.Sleep(1000);
            goto Back;
        }
        switch (chose)
        {
            case 1:
                calcutaion = 1;
                Calculate(shape,calcutaion);
                break;
            case 2:
                calcutaion = 2;
                Calculate(shape,calcutaion);
                break;
            case 0:
                break;
            default:
                System.Console.WriteLine("You made the wrong choice. Please, choose one from the menu.");
                Thread.Sleep(1000);
                goto Back;
        }
    }
    public static void Calculate(int shape, int calculation){
        if(shape == 1){
            CalculateCircle(calculation);
        }else if(shape == 2){
            CalculateTriangle(calculation);
        }else if(shape == 3){
            CalculateSquare(calculation);
        }else if(shape == 4){
            CalculateRectangle(calculation);
        }
    }
    public static void CalculateTriangle(int calculation){
        Back:
        System.Console.Write("Please, Enter a long edge : ");
        if(!double.TryParse(Console.ReadLine(), out double longEdge) || longEdge<=0)
        {
            System.Console.WriteLine("You entered the wrong length. Please, enter a positive non-zero number...");
            goto Back;
        }

        Back1:
        System.Console.Write("Please, Enter a short edge : ");
        if(!double.TryParse(Console.ReadLine(), out double shortEdge) || shortEdge<=0)
        {
            System.Console.WriteLine("You entered the wrong length. Please, enter a positive non-zero number...");
            goto Back1;
        }

        double result = 0;

        if(calculation == 1)
        {
            result = shortEdge*longEdge/2;
            System.Console.WriteLine($"Area of the Triangle : {result}");
        }
        else if(calculation == 2)
        {
            result = shortEdge + longEdge + Math.Sqrt(shortEdge*shortEdge  + longEdge*longEdge);
            System.Console.WriteLine($"Perimeter of the Triangle : {result}");
        }
    }
    public static void CalculateSquare(int calculation){
        Back:
        System.Console.Write("Please, Enter a edge : ");
        if(!double.TryParse(Console.ReadLine(), out double edge) || edge<=0)
        {
            System.Console.WriteLine("You entered the wrong length. Please, enter a positive non-zero number...");
            goto Back;
        }
        double result = 0;

        if(calculation == 1)
        {
            result = edge*edge;
            System.Console.WriteLine($"Area of the Square : {result}");
        }
        else if(calculation == 2)
        {
            result = 4*edge;
            System.Console.WriteLine($"Perimeter of the Square : {result}");
        }
    }
    public static void CalculateCircle(int calculation){
        Back:
        System.Console.Write("Please, Enter a radius : ");
        if(!double.TryParse(Console.ReadLine(), out double radius) || radius<=0)
        {
            System.Console.WriteLine("You entered the wrong length. Please, enter a positive non-zero number...");
            goto Back;
        }
        double result = 0;

        if(calculation == 1)
        {
            result = 3.14*radius*radius;
            System.Console.WriteLine($"Area of the circle : {result}");
        }
        else if(calculation == 2)
        {
            result = 3.14*2*radius;
            System.Console.WriteLine($"Circumference of the circle : {result}");
        }
    }
    public static void CalculateRectangle(int calculation){
        Back:
        System.Console.Write("Please, Enter a long edge : ");
        if(!double.TryParse(Console.ReadLine(), out double longEdge) || longEdge<=0)
        {
            System.Console.WriteLine("You entered the wrong length. Please, enter a positive non-zero number...");
            goto Back;
        }

        Back1:
        System.Console.Write("Please, Enter a short edge : ");
        if(!double.TryParse(Console.ReadLine(), out double shortEdge) || shortEdge<=0)
        {
            System.Console.WriteLine("You entered the wrong length. Please, enter a positive non-zero number...");
            goto Back1;
        }

        double result = 0;

        if(calculation == 1)
        {
            result = shortEdge*longEdge;
            System.Console.WriteLine($"Area of the Rectangle : {result}");
        }
        else if(calculation == 2)
        {
            result = 2*shortEdge  + 2*longEdge;
            System.Console.WriteLine($"Perimeter of the Rectangle : {result}");
        }
    }
}
