using EmployeeManagement.DAL.Data;
using EmployeeManagement.DAL.Entities;
using EmployeeManagement.DAL.Feature.Employee.Commands;
using EmployeeManagement.DAL.Repository.CommandRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Feature.Employee.Handler
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, string>
    {
        private readonly IEmployeeCommandRepository _cmdrepo;
        public DeleteEmployeeHandler(IEmployeeCommandRepository cmdrepo)
        {
            _cmdrepo = cmdrepo;
        }
        public async Task<string> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            await _cmdrepo.Delete(request.Id);
            return $"Employee Deleted Succesfully with id : {request.Id}";
        }
    }
}
