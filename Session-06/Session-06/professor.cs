using System;

public class Professor : Person
{
    // properties
    public string Rank { get; set; }
    public Course[] Courses { get; set; }

    // constructor
    public Professor(Guid id, string name, int age, string rank) : base(id, name, age)
    {
        Rank = rank;
    }
    // methods to record the professor teaching a course on a specific date, to assign a grade to a student in a specific course and return the name of the professor
    public void Teach(string course, DateTime date)
    {
        
    }
    public void SetGrade(Guid studentID, string courseID, double grade)
    {
        
    }
    public new void GetName()
    {
        Console.WriteLine("Dr. " + Name);
    }
}

