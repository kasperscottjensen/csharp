using System;

public class Program
{

    public static void Main(String[] args)
    {
        
        SendMessage("Hello, how are you", "John");
        SendMessage("Meeting postponed", "All employees", true);
        SendMessage("Reminder: project due in 2 days", "Project team", scheduledTime: DateTime.Now.AddDays(2));
        
        
    }

    static void SendMessage(string message, string recipient, bool isUrgent = false, DateTime ? scheduledTime = null)
    {

        string urgent = isUrgent ? "" : "URGENT: ";

        string time = scheduledTime.HasValue ? $" Scheduled Time: {scheduledTime}" : " No scheduled time";
        
        Console.WriteLine($"{urgent}{message}, {recipient}.{time}.");

    }
    
}