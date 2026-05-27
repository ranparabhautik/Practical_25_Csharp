using EmployeeManagement.DAL.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<>> GetAll();
    }
}
