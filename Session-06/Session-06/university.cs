using System;

public class University : Institute
{
    // properties
    public Student[] Students { get; set; }
    public Course[] Courses { get; set; }
    public Grade[] Grades { get; set; }
    public Schedule[] ScheduledCourses { get; set; }

    // constructor
    public University(Guid id, string name, int yearsInService) : base(id, name, yearsInService)
    {
    }

    // methods
    public Student[] GetStudents()
    {
        return Students;
    }

    public Course[] GetCourses()
    {
        return Courses;
    }

    public Grade[] GetGrades()
    {
        return Grades;
    }

    public void SetScheduled(string courseID, string professorID, DateTime dateTime)
    {
        // method implementation to schedule a course with a specific professor on a specific date and time
    }
}

