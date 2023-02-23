// null propagation, string interpolation and pattern matching
// safely access email, format output and check customer's age

using System;
using static Customer;

public class Program
{

    public static void Main(String[] args)
    {

        Customer customer01 = new Customer("John Doe", 30, "johndoe@email.dk");
        Customer customer02 = new Customer("Jane Doe", 25, "janedoe@email.dk");
        Customer customer03 = new Customer("Jim Smith", 35, null);

        Formatter(customer01);
        Formatter(customer02);
        Formatter(customer03);

    }

    public static void Formatter(Customer customer)
    {

        String name;
        String age;
        String email;
        String message;

        name = customer.name ?? "no name provided";
        
        age = customer.age.ToString() ?? "no age provided";
        
        email = customer.email ?? "no email provided";

        message = customer.age switch
            {
                < 30 => "this person is from a younger generation",
                30 => "this person is getting old",
                > 30 => "there is no help for this one",
                null => "no age to judge off of"
            }
        ;
        
        String formattedString = $"Name: {name}, Age: {age}, Email: {email.ToLower()}, Msg: {message}.";
        Console.WriteLine(formattedString);

    }

}