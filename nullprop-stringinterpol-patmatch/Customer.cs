using System;

public class Customer
{

    public String? name {get; set;}
    public int? age {get; set;}
    public String? email {get; set;}

    public Customer(String name, int age, String email)
    {
        this.name = name;
        this.age = age;
        this.email = email;
    }

}
