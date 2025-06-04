using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Core.Features.Students.Queries.Results;

namespace SchoolProject.Core.Mapping.Student
{
    public partial class StudentProfile
    {
        public void AddStudentCommandMapping()
        {
            CreateMap<AddStudentCommand, Data.Entities.Student>().ForMember(dest => dest.DID, o => o.MapFrom(src => src.DepartmentId));
        }
    }
}
