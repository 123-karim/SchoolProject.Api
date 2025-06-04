using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Data.Entities;

namespace SchoolProject.Service.Abstracts
{
    public interface IStudentService
    {
        public Task<List<Student>> GetStudentsListAsync();
        public Task<Student> GetStudentByIdAsync(int id);
        public Task<string> AddAsync(Student student);
    }
}
