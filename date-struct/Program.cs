using System;

public class Program
{

    struct Date
    {

        int year;
        int month;
        int day;

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public Boolean IsValid()
        {
            Boolean yearValid = this.year > 0 ? true : false;
            Boolean monthValid = this.month >= 1 && this.month <= 12 ? true : false;
            Boolean dayValid = this.day >= 1 && this.day <= 31 ? true : false;

            return yearValid && monthValid && dayValid ? true : false;

        }

        override public String ToString()
        {
            return $"Year: {year}, Month: {month}, Day: {day}";
        }

    };

    public static void Main(String[] args)
    {

        Date date01 = new Date(1994, 10, 16);
        Console.WriteLine(date01.IsValid());
        Console.WriteLine(date01.ToString());

        Date date02 = new Date(-1, 10, 15);
        Console.WriteLine(date02.IsValid());
        Console.WriteLine(date02.ToString());

        Date date03 = new Date(1994, 15, 15);
        Console.WriteLine(date03.IsValid());
        Console.WriteLine(date03.ToString());

        Date date04 = new Date(1994, 10, 35);
        Console.WriteLine(date04.IsValid());
        Console.WriteLine(date04.ToString());

    }

}