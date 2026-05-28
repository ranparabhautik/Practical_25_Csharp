using EmployeeManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Repository
{
    public interface IGenericRepo<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Update(T entity);
        Task Create(T entity);
        Task Delete(int id);
    }
}
