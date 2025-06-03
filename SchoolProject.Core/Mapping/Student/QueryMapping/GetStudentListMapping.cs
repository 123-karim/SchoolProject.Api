using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Core.Features.Students.Queries.Results;

namespace SchoolProject.Core.Mapping.Student
{
    public partial class StudentProfile
    {
        public void GetStudentListMapping()
        {
            CreateMap<Data.Entities.Student, GetStudentListResponse>().ForMember(dest => dest.DepartmentName, o => o.MapFrom(src => src.Department.DName));
        }
    }
}
