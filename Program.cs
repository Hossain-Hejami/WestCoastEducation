using WestCoastEducation.Models;

namespace WestCoastEducation;

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.FirstName = "Sara";
        student.LastName = "Andersson";
        student.City = "Göteborg";
        student.Phone = "070-1234567";

        Teacher teacher = new Teacher();

        teacher.FirstName = "Johan";
        teacher.LastName = "Svensson";
        teacher.KnowledgeArea = "C# och .NET";
        teacher.Phone = "070-9876543";

        Console.WriteLine(student);
        Console.WriteLine("--------------------");

        Console.WriteLine(teacher);
    }
}