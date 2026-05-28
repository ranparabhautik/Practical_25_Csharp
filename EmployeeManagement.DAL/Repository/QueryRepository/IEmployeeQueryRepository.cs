using EmployeeManagement.DAL.Model.QueryModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Repository.QueryRepository
{
    public interface IEmployeeQueryRepository
    {
        Task<IEnumerable<EmployeeQueryModel>> GetAll();
        Task<EmployeeQueryModel> GetById(int id);
    }
}
