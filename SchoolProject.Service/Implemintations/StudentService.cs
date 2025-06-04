using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Service.Abstracts;

namespace SchoolProject.Service.Implemintations
{
    class StudentService : IStudentService
    {
        #region Fields
        private readonly IStudentRepository _studentRepository;

        #endregion

        #region Ctor
        public StudentService(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }

    
        #endregion
        #region Handle Func

        public async Task<List<Student>> GetStudentsListAsync()
        {
           return await _studentRepository.GetStudentsListAsync();
        }
        public async Task<Student> GetStudentByIdAsync(int id)
        {
            var student = _studentRepository.GetTableNoTracking()
                .Include(x => x.Department)
                .Where(x => x.StudId.Equals(id))
                .FirstOrDefault();
            return student;
        }

        public async Task<string> AddAsync(Student student)
        {
            //check if name is exist
            var studentResult = _studentRepository.GetTableNoTracking().Where(x=>x.Name.Equals(student.Name)).FirstOrDefault();
            if (studentResult != null) 
                return "Student Is Already Exist";
            
            //add student
            await _studentRepository.AddAsync(student);
            return "Success";
        }
    }
        #endregion

    
}
