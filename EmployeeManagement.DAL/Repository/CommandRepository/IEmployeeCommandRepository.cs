using EmployeeManagement.DAL.Feature.Employee.Commands;
using EmployeeManagement.DAL.Model.CommandModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Repository.CommandRepository
{
    public interface IEmployeeCommandRepository
    {
        Task Create(CreateEmployeeCommand entity);
        Task Update(int id, UpdateEmployeeCommand entity);
        Task Delete(int id);
    }
}
