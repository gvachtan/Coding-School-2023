using System;



public class Student : Person
{
    // properties
    public int RegistrationNumber { get; set; }
    public Course[] Courses { get; set; }

    // constructor
    public Student(Guid id, string name, int age, int registrationNumber) : base(id, name, age)
    {
        RegistrationNumber = registrationNumber;
    }

    // methods
    public void Attend(string course, DateTime date)
    {
    }
    public void WriteExam(string course, DateTime date)
    {
    }
}

