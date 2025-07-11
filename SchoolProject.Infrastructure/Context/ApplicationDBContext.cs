﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;

namespace SchoolProject.Infrastructure.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
        {
            
        }public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options) 
        {
            
        }
        public DbSet<Department> Departments { get; set; }  
        public DbSet<Student> Students{ get; set; }  
        public DbSet<DepartmentSubject> departmentSubjects{ get; set; }  
        public DbSet<Subjects> subjects{ get; set; }  
        public DbSet<StudentSubject> StudentSubjects{ get; set; }  

    }
}
