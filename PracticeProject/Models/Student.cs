using PracticeProject.Enums;

namespace PracticeProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentId { get; set; }
        public string Email { get; set; }
        public string PostalCode{ get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Grades Grades { get; set; }
        public virtual List<Course> Courses { get; set; }

        public Student()
        {
            Grades = new Grades();
            Courses = new List<Course>();
        }


    }
}
