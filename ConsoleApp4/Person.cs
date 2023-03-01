namespace ConsoleApp4;

public class Person
{
    private string name { get; set; }
    private int age { get; set; }
    private string occupation { get; set; }
    private decimal decimalSalery { get; set; }


    public Tuple<string,int,string,decimal> GetPersonInfo()
    {
        Tuple<string, int, string, decimal> person = new Tuple<string, int, string, decimal>(name,age,occupation,decimalSalery);
        return person;
    }

    public static void Main(string[] args)
    {
        var person = new Person

        {

            name = "John",

            age = 30,

            occupation = "Software Engineer",

            decimalSalery = 75000.00m

        };
        
        var (name, age, occupation, salary) = person.GetPersonInfo();
        
        Console.WriteLine($"{name} is {age} years old and works as a {occupation}, earning {salary:C} per year.");
        
    }

}