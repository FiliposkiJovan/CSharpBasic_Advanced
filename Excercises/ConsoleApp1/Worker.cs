using System;

public class Worker : Employee
{
    public Worker(int id, string firstName, string lastName, DayOfWeek workingDay) : base(id, firstName, lastName, workingDay)
    {
    }

    public void WriteReport()
    {
        Console.WriteLine($"{FirstName} is writing a report");
    }
}
}