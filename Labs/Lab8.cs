using System.Text;
using System.Text.RegularExpressions;

namespace Labs;

public class Lab8
{
    public static void task9(string[] sirnames)
    {
        String longestsir = sirnames[0].Split(' ')[0];;
        for (int i = 0; i < sirnames.Length; i++)
        {
            string[] PIB = sirnames[i].Split(' ');
            String name = PIB[1];
            String sirname = PIB[0];
            String pobatkovi = PIB[2];
            Console.WriteLine('\n' + $"Sirname: {sirname}" + '\n' +
                              $"Name: {name}" + '\n' +
                              $"Father's name: {pobatkovi}");
            Console.WriteLine('\n' + $"Name's length: {name.Length}");
            Console.Write($"First Letter of Father's name: {pobatkovi[0]}"+ '\n' + '\n' );
            if (sirname.Length > longestsir.Length)
            {
                longestsir = sirname;
            }
        }
        Console.WriteLine($"Longest Sirname: {longestsir}");
    }

    /*public static String phonedefault(string number)
    {
        string standartform = "+38 098 456-78-90";
        Regex phonepattern = new Regex( @"\+[3][8]\s[0]{1}[0-9]{2}\s[0-9]{3}-[0-9]{2}-[0-9]{2}");
        
        string finalres = phonepattern.
    }*/
}