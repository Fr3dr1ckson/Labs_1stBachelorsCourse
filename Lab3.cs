namespace Labs;

public class Lab3
{
    public static double task1(double x) 
    {
        try
        {
            double y;
            y = Math.Sqrt(Math.Pow(x, 2) + 5 * x + 8);
            return y;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return 0;
    }

    public static void task2(double x, out double perimeter, out double area) 
    {
        try
        {
            perimeter = x * 4;
            area = x*x;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
    public static double task3(double x, double b, double c) 
    {
        if (x==b) {
            Console.WriteLine("Cannot do the operation, the domain of a function excludes this value of a variable");
            return Double.NaN;
        }
        else if(b>x) 
        {
            Console.WriteLine("Cannot do the operation, the value of x cannot be less than b");
            return Double.NaN;
        }
        else 
        {
            double y = (2 * x - c) / Math.Sqrt(x - b) + Math.Abs(x - c);
            return y;
        }
    }
}
