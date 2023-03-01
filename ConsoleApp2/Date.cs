namespace ConsoleApp2;

public struct Date
{
    private int year;
    private int month;
    private int day;

    public Date(int year, int month, int day)
    {
        this.year = year;
        this.month = month;
        this.day = day;
    }


    public bool IsValid()
    {
        bool IsValid = true;
        try
        {
            DateTime dateTime1 = new DateTime(year, month, day);
        }
        catch (Exception)
        {
            IsValid = false;
            Console.WriteLine("The date is not valid..");
        }

        return IsValid;
    }

    public override string ToString()
    {
        return $"Day: {day}, Month: {month}, Year: {year}";
    }

    public static void Main(string[] args)
    {
        Date date1 = new Date(2023, 2, 17);
        Date date2 = new Date(2023, 2, 29);
        Date date3 = new Date(2023, 13, 1);


        Console.WriteLine("Date 1 is valid? " + date1.IsValid());
        Console.WriteLine("Date 2 is valid? " + date2.IsValid());
        Console.WriteLine("Date 3 is valid? " + date3.IsValid());
    }
}