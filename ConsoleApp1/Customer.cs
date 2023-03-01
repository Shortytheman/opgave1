using System.Collections.Generic;
using System;

namespace yoyo
{
    
    
    public class Customer
    {
        
        String name;
        int? age;
        String? email;
        String message;

        public Customer(String name, int age, String email, String message)
        {
            this.name = name;
            this.age = age;
            this.email = email;
            this.message = message;
        }
        
        public Customer(String name, int age, String message)
        {
            this.name = name;
            this.age = age;
            this.message = message;
        }

        public static void Main(string[] args)
        {
            Customer customer1 = new Customer("John Doe", 30, "john.doe@example.com", "The customer is between 30 and 40");
            Customer customer2 = new Customer("Jane Doe", 25, "jane.doe@example.com", "The customer is under 30");
            Customer customer3 = new Customer("Jim Smith", 35, "The customer is between 30 and 40");

            List<Customer> customers = new List<Customer>();

            customers.Add(customer1);   
            customers.Add(customer2);
            customers.Add(customer3);
            
            Console.WriteLine(findCustomerEmail(customer1)); 
            
            if (customer2.age is int){
            Console.WriteLine(customer2);
            }

        }

        public static String findCustomerEmail(Customer customer)
        {

            return customer.email ?? throw new Exception("Mailen findes ikke");

        }


        public override string ToString()
        {
            return $"Name: {name}, Age: {age}, Email: {email}, Message: {message}";
        }


    }
}