namespace WestCoastEducation.Models;

public class Student : Person
{
    public override string ToString()
    {
        return $"{FirstName} {LastName}, {City}";
    }
}