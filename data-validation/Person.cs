using System.ComponentModel.DataAnnotations;
namespace tuple_values;

public class Person
{
    
    [Required]
    [StringLength(100)]
    private string name { get; set; }
    [Required]
    [Range(0,120)]
    private int age { get; set; }
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
    private string email { get; set; }

    public Person(string name, int age, string email)
    {
        this.name = name;
        this.age = age;
        this.email = email;
    }

    public void Validate()
    {
        var context = new ValidationContext(this);
        var errorResults = new List<ValidationResult>();
        var isValid = Validator.TryValidateObject(this, context, errorResults, true);
        Console.WriteLine(errorResults.ToString());
        Console.WriteLine("Object is: {0}", isValid ? "VALID" : "NOT VALID");
        
    }
}