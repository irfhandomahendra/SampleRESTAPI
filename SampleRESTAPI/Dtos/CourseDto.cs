namespace SampleRESTAPI.Dtos
{
    public class CourseDto
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int TotalHours { get; set; } //1 krediit = 1.5 jam
    }
}
