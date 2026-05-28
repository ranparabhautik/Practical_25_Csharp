using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Feature.Employee.Query
{
    public class GetEmployeeQuery:IRequest<object>
    {
        public int? Id {  get; set; }
    }
}
