namespace Labs;

public class Lab5
{
    public static void task9(double r1, double r2, out double s1, out double s2, out double s3)
    {
        s1 = Math.PI*Math.Pow(r1, 2);
        s2 = Math.PI*Math.Pow(r2, 2);
        s3 = s1-s2;
    }

    public static void task36(double a1, double a2, double b1, double b2, double c1, double c2, out double x, out double y)
    {
        if (b2 - (b1 * a2) * a1 != 0)
        {
            //y = c2 - (c1 * a2) / a1;
            //x = c1 - b2 * ((c2 - (c1 * a2) / a1) / (b2 - b1 * a2 / a1));
            x = (c1 * b2 - c2 * b1) / (a1 * b2 - a2 * b1);
            y = (a1 * c2 - a2 * c1) / (a1 * b2 - a2 * b1);
        }
        else if(a1*b2-a2*b1==0)
        {
            Console.WriteLine("Розв'язків Безліч");
            x = double.NaN;
            y = double.NaN;
        }
        else if ((b2 - (b1 * a2) * a1 == 0 && c2 - (c1 * a2) / a1 == 0 ))
        {
            Console.WriteLine("Розв'язків Безліч");
            x = double.NaN;
            y = double.NaN;
        }
        else if(((b2 - (b1 * a2) * a1 == 0 && c2 - (c1 * a2) / a1 != 0 )))
        {
            Console.WriteLine("Розв'язків Немає");
            x = double.NaN;
            y = double.NaN;
        }
        else
        {
            x = double.NaN;
            y = double.NaN;
        }
    }
}