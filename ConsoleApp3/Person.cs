using System.ComponentModel.DataAnnotations;

namespace ConsoleApp3;

public class Person
{
    [StringLength(100), Required]
    public string Name { get; set; }

    [Range(0, 120), Required] public int Age { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

    public Person(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }
    
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    

    public static void Main(string[] args)
    {
        var person1 = new Person("John", 30, "john@example.com");
        Console.WriteLine(person1.Validate()); // no exception
        
        
        var person2 = new Person(null, 150);
        try
        {
            Console.WriteLine(person2.Validate());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message); // "Name must be between 1 and 100 characters."
        }

 

        var person3 = new Person("Jane", -10, "jane@example.com");
        try
        {
            Console.WriteLine(person3.Validate());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message); // "Age must be between 0 and 120."
        }

 

        var person4 = new Person("Bob", 40, "invalid-email");

        try

        {

            Console.WriteLine(person4.Validate());

        }

        catch (ArgumentException ex)

        {

            Console.WriteLine(ex.Message); // "Email must be a valid email address format."

        }
    }
    public bool Validate()
    {
        Console.WriteLine("Name: " + Name + " Age: " + Age + " Email: " + Email);
        Person person = new Person(Name,Age,Email);
        var result = new List<ValidationResult>();
        var context = new ValidationContext(person);
        return Validator.TryValidateObject(person, context, result, true);
    }

}