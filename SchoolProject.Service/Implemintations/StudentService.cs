using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
        #endregion

    
}
