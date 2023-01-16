using System;
using static Person;
using System.Diagnostics.Metrics;
using System.Diagnostics;

public class Person
{

    // properties
    public Guid ID { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }

    // constructors

    public Person(Guid id, string name, int age)
    {
        ID = id;
        Name = name;
        Age = age;
    }

    // methods
    public void GetName()
    {

    }

    public void SetName(string name)
    {


    }

}





