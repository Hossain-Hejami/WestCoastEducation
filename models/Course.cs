namespace WestCoastEducation.Models;

public class Course
{
    public string CourseNumber { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public int DurationDays { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public CourseType Type { get; set; }

    public override string ToString()
    {
        return $"{CourseNumber} - {Title}, {Type}, {StartDate:yyyy-MM-dd} till {EndDate:yyyy-MM-dd}";
    }
}