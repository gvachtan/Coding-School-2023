using System;

public class Course
{
    // properties
    public Guid ID { get; set; }
    public string Code { get; set; }
    public string Subject { get; set; }

    // constructor
    public Course(Guid id, string code, string subject)
    {
        ID = id;
        Code = code;
        Subject = subject;
    }
}

