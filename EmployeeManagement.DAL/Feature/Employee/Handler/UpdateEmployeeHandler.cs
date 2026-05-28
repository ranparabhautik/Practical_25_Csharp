using EmployeeManagement.DAL.Data;
using EmployeeManagement.DAL.Feature.Employee.Commands;
using EmployeeManagement.DAL.Repository.CommandRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Feature.Employee.Handler
{
    internal class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, string>
    {
        private readonly IEmployeeCommandRepository _cmdrepo;
        public UpdateEmployeeHandler(IEmployeeCommandRepository cmdrepo)
        {
            _cmdrepo = cmdrepo;
        }
        public async Task<string> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            await _cmdrepo.Update(request.Id,request);
            return "Employee Updated Successfully";
        }
    }
}
