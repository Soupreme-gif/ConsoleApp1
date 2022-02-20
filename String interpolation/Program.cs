using Microsoft.VisualBasic;

namespace ConsoleApp1;

public class Program
{

    static void Main(string[] args)
    {

        DateTime todaysDate = DateTime.Now;
        
        Console.WriteLine($"1A:{$"{todaysDate:MMMM} {todaysDate:dd}, {todaysDate:yyyy}",40}");
        Console.WriteLine($"1B: {todaysDate:yyyy}.{todaysDate:MM}.{todaysDate:dd}");
        Console.WriteLine($"1C: Day {todaysDate:dd} of {todaysDate:MMMM}, {todaysDate:yyyy}");
        Console.WriteLine($"1D: Year:{todaysDate:yyyy}, Month:{todaysDate:MMMM}, Day:{todaysDate:dd}");
        Console.WriteLine($"1E:{$"{todaysDate:dddd}",10}");
        Console.WriteLine($"1F:{$"{todaysDate:hh}:{todaysDate:mm} {todaysDate:tt}",10}{$"{todaysDate:dddd}",10}");
        Console.WriteLine($"1G: h:{todaysDate:hh},m:{todaysDate:mm},s:{todaysDate:ss}");
        Console.WriteLine($"1H: {todaysDate:yyyy}.{todaysDate:MM}.{todaysDate:dd}.{todaysDate:hh}.{todaysDate:mm}.{todaysDate:ss}");
        Console.WriteLine();

        var pi = Math.PI;
        
        Console.WriteLine($"2A: {pi:C2}");
        Console.WriteLine($"2B:{pi,10:f3}");
        
        var squareRoot = Math.Sqrt(2);
        byte[] hexadecimal = BitConverter.GetBytes(squareRoot);
        var hexadecimalString = BitConverter.ToString(hexadecimal);
        

        Console.WriteLine(hexadecimalString);


    }
    
}

