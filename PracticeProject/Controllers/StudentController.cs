using Microsoft.AspNetCore.Mvc;
using PracticeProject.Interfaces;

namespace PracticeProject.Controllers
{
    public class StudentController

    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService )
        {
            _studentService = studentService;
        }
        [HttpGet]
        public async Task<bool> GetStudentList()
        {
            return await _studentService.GetAllStudents();
        }

   }
}
