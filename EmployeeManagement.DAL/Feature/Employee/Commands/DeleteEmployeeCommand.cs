using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Feature.Employee.Commands
{
    public class DeleteEmployeeCommand:IRequest<string>
    {
        public int Id { get; set; }
    }
}
