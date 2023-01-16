using System;

public class Institute
{
    // properties
    public Guid ID { get; set; }
    public string Name { get; set; }
    public int YearsInService { get; set; }

    // constructor
    public Institute(Guid id, string name, int yearsInService)
    {
        ID = id;
        Name = name;
        YearsInService = yearsInService;
    }

    // methods
    public string GetName()
    {
        return Name;
    }

    public void SetName(string name)
    {
        Name = name;
    }
}

