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
        public void GetStudentByIDMapping()
        {
            CreateMap<Data.Entities.Student, GetSingleStudentResponse>().ForMember(dest => dest.DepartmentName, o => o.MapFrom(src => src.Department.DName));
        }
    }
}
