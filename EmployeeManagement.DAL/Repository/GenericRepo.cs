using EmployeeManagement.DAL.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Repository
{
    public class GenericRepo<T> : IGenericRepo<T> where T : BaseEntity
    {
        public Task Create(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
