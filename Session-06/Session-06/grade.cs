using System;

public class Grade
{
    // properties
    public Guid ID { get; set; }
    public Guid StudentID { get; set; }
    public Guid CourseID { get; set; }
    public int GradeValue { get; set; }

    // constructor
    public Grade(Guid id, Guid studentID, Guid courseID, int grade)
    {
        ID = id;
        StudentID = studentID;
        CourseID = courseID;
        GradeValue = grade;
    }
}

