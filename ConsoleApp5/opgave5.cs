namespace ConsoleApp5;

public class opgave5
{

    


    public static void ModifyValue(ref int a, in int b, out int c)
    {
        a += b;
        c = a - b;
    }

    public static void Main(string[] args)
    {
        int x = 10;

        int y = 5;

        int z;
        
        Console.WriteLine($"Before calling ModifyValue: x={x}, y={y}");
        
        ModifyValue(ref x, y, out z);
        
        Console.WriteLine($"After calling ModifyValue: x={x}, z={z}");
    }

}