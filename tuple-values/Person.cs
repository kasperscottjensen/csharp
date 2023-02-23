namespace tuple_values;

public class Person
{

    private string name { get; set; }
    private int age { get; set; }
    private string occupation { get; set; }
    private decimal salary { get; set; }

    public Person(string name, int age, string occupation, decimal salaray)
    {
        this.name = name;
        this.age = age;
        this.occupation = occupation;
        this.salary = salaray;
    }

    public Tuple<string, int, string, decimal> GetPersonInfo()
    {
        return Tuple.Create(name, age, occupation, salary);
    }

}