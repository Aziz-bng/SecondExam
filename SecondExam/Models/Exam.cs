namespace SecondExam.Models
{
    public class Exam
    {
        public int Id { get; set; }

        public string? Title { get; set; }
        public List<Question>? Questions { get; set; }
    }
}
