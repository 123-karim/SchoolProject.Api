using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Entities;

namespace SchoolProject.Core.Features.Students.Queries.Models
{
    public class GetStudentListQuery:IRequest<Response<List<GetStudentListResponse>>>
    {
    }
}
