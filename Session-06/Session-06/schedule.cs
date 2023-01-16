using System;

public class Schedule
{
    //properties
    public Guid ID { get; set; }
    public Guid CourseID { get; set; }
    public Guid ProfessorID { get; set; }
    public DateTime Calendar { get; set; }

    // constructor
    public Schedule(Guid id, Guid courseID, Guid professorID, DateTime calendar)
    {
        ID = id;
        CourseID = courseID;
        ProfessorID = professorID;
        Calendar = calendar;
    }
}

