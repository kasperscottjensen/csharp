namespace tuple_values;

public class Program
{

    public static void Main(String[] args)
    {

        var person = new Person("John", 30, "Software Engineer", 75000.00m);

        var (name, age, occupation, salary) = person.GetPersonInfo();

        Console.WriteLine($"{name} is {age} years old and works as a {occupation}, earning {salary:C} per year.");

    }
    
}