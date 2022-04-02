using System;

public class Employee
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DayOfWeek WorkingDay { get; set; }

    public Employee(int id, string firstName, string lastName, DayOfWeek workingDay)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        WorkingDay = workingDay;
    }

    public virtual void DoWork()
    {
        Console.WriteLine($"{FirstName} {LastName} is doing work");
    }
}
}
