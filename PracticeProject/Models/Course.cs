namespace PracticeProject.Models
{
    public class Course
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string CourseId { get; set; }
        public virtual List<Student> Students { get; set; }

        public Course()
        {
            Students = new List<Student>();
        }
    }

    
}
