﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Infrastructure.Data;
using SchoolProject.Infrastructure.InfrastructureBases;

namespace SchoolProject.Infrastructure.Repositories
{
    public class StudentRepository : GenericRepositoryAsync<Student>, IStudentRepository
    {
        #region Fields
        private readonly DbSet<Student> _students;

        #endregion

        #region Constructore
        public StudentRepository(ApplicationDBContext dBContext):base(dBContext) 
        {
            _students=dBContext.Set<Student>();
        }
        #endregion

        #region Handles Functions

        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _students.Include(x=>x.Department).ToListAsync();
                }
        #endregion
    }
}
