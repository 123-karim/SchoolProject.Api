using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Abstracts;

namespace SchoolProject.Core.Features.Students.Commands.Handlers
{
    public class StudentCommandHandler:ResponseHandler,IRequestHandler<AddStudentCommand,Response<string>>
    {
        #region Fied
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        #endregion

        #region Ctor
        public StudentCommandHandler(IStudentService studentService, IMapper mapper)
        {
            _mapper = mapper;   
            _studentService = studentService;

        }


        #endregion

        #region Func
        public async Task<Response<string>> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var studentmapper = _mapper.Map<Student>(request);
            var result =await _studentService.AddAsync(studentmapper);
            if (result == "Student Is Already Exist") return UnprocessableEntity<string>("Name Is Exist");
            else if (result == "Success") return Created("Added Successfully");
            else return BadRequest<string>();

        }
        #endregion
    }
}
