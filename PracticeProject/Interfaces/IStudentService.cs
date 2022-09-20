using Microsoft.AspNetCore.Mvc;
using PracticeProject.Models;

namespace PracticeProject.Interfaces
{
    public interface IStudentService
    {
         Task<List<Student>> GetAllStudents(int studentId);
        Task<bool> GetAllStudents();
    }
}
