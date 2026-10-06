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

        Console.WriteLine("--------------------");

        EducationLeader leader = new EducationLeader();

        leader.FirstName = "Maria";
        leader.LastName = "Johansson";
        leader.KnowledgeArea = "Systemutveckling";
        leader.EmploymentDate = new DateTime(2020, 8, 15);

        Console.WriteLine(leader.FirstName);
        Console.WriteLine(leader.KnowledgeArea);
        Console.WriteLine(leader.EmploymentDate);

        Administrator admin = new Administrator();

        admin.FirstName = "Anna";
        admin.LastName = "Karlsson";
        admin.KnowledgeArea = "Administration";
        admin.EmploymentDate = new DateTime(2022, 3, 10);

        Console.WriteLine(admin.FirstName);
        Console.WriteLine(admin.KnowledgeArea);
        Console.WriteLine(admin.EmploymentDate);

        Console.WriteLine("--------------------");

        Console.WriteLine(leader);
        Console.WriteLine(admin);


        Course course = new Course();

        course.CourseNumber = "C001";
        course.Title = "C# Grundkurs";
        course.DurationDays = 5;
        course.StartDate = new DateTime(2026, 11, 2);
        course.EndDate = new DateTime(2026, 11, 6);
        course.Type = CourseType.Classroom;

        Console.WriteLine(course.Title);
        Console.WriteLine(course.Type);

        Console.WriteLine(course);

        if (course.Type == CourseType.Classroom)
        {
            Console.WriteLine("Den här kursen hålls i klassrum.");
        }
        else
        {
            Console.WriteLine("Den här kursen hålls på distans.");
        }

        teacher.Courses.Add(course);

        foreach (Course teacherCourse in teacher.Courses)
        {
            Console.WriteLine(teacherCourse);
        }
    }
}