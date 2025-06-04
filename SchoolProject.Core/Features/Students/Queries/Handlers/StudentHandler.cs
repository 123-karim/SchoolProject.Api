using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Abstracts;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class StudentHandler :ResponseHandler, IRequestHandler<GetStudentListQuery,Response<List<GetStudentListResponse>>>,
        IRequestHandler<GetStudentByIDQuery, Response<GetSingleStudentResponse>>
    {
        #region Fields
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        #endregion
        #region ctor
        public StudentHandler(IStudentService studentService,IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        #endregion 
        #region handl func
        public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var StudentList= await _studentService.GetStudentsListAsync();
            var StudentListMapper = _mapper.Map<List<GetStudentListResponse>>(StudentList);
            return Success (StudentListMapper);
        }

        public async Task<Response<GetSingleStudentResponse>> Handle(GetStudentByIDQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetStudentByIdAsync(request.Id);
            if (student == null) {
                return NotFound<GetSingleStudentResponse>();
            }
            var result=_mapper.Map<GetSingleStudentResponse>(student);  
            return Success (result);
        }
        #endregion

    }
}
