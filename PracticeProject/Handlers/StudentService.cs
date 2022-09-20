using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using PracticeProject.Data;
using PracticeProject.Interfaces;
using PracticeProject.Models;


namespace PracticeProject.Handlers
{
    public class StudentService : IStudentService
    {
        private readonly DataContext _dataContext;
        public StudentService(DataContext dataContext)
        {
            _dataContext = dataContext;  
        }
       public 
    }
}
