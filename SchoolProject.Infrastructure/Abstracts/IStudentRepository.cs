﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.InfrastructureBases;

namespace SchoolProject.Infrastructure.Abstracts
{
    public interface IStudentRepository: IGenericRepositoryAsync<Student>
    {
        public Task<List<Student>> GetStudentsListAsync();
    }
}
