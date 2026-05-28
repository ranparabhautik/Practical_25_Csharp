using EmployeeManagement.DAL.Data;
using EmployeeManagement.DAL.Entities;
using EmployeeManagement.DAL.Feature.Employee.Commands;
using EmployeeManagement.DAL.Repository.CommandRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Feature.Employee.Handler
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, string>
    {
        private readonly IEmployeeCommandRepository _cmdrepo;
        public CreateEmployeeHandler(IEmployeeCommandRepository cmdrepo)
        {
            _cmdrepo = cmdrepo;
        }
        public async Task<string> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
           await _cmdrepo.Create(request);
            return "Employee Created Successfully";
        }


    }
}
