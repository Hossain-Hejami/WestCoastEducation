namespace WestCoastEducation.Models;

public class Teacher : Person
{
    public string KnowledgeArea { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"{FirstName} {LastName}, Kunskapsområde: {KnowledgeArea}";
    }
}