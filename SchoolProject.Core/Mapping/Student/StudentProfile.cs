using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Entities;

namespace SchoolProject.Core.Mapping.Student
{
   public partial class StudentProfile:Profile
    {
        public StudentProfile()
        {
            GetStudentListMapping();


        }
    }
}
