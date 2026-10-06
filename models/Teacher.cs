namespace WestCoastEducation.Models;

public class Teacher : Person
{
    public string KnowledgeArea { get; set; } = string.Empty;
    public List<Course> Courses { get; set; } = new();

    public override string ToString()
    {
        return $"{FirstName} {LastName}, Kunskapsområde: {KnowledgeArea}";
    }
}