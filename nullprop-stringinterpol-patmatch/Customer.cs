using System;

public class Customer
{

    public String? name {get; set;}
    public String? email {get; set;}
    public int? age {get; set;}

    public Customer(String name, String email, int age = 0)
    {
        this.name = name;
        this.email = email;
        this.age = age;
    }

}
