using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Feature.Employee.Commands
{
    public class CreateEmployeeCommand : IRequest<string>
    {
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public int DepartmentId { get; set; }

        public string EmailId { get; set; }
    }
}
