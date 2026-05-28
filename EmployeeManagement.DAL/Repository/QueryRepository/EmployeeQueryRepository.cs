using EmployeeManagement.DAL.Data;
using EmployeeManagement.DAL.Model.QueryModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Repository.QueryRepository
{
    public class EmployeeQueryRepository : IEmployeeQueryRepository
    {
        private readonly AppDbContext _context;
        public EmployeeQueryRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<EmployeeQueryModel>> GetAll()
        {
            var employees = await _context.Employees.AsNoTracking().Include(x => x.Department).Where(x=> x.IsDeleted == false).Select(x => new EmployeeQueryModel
            {
                Id = x.Id,
                Name = x.Name,
                Department = x.Department.Name,
                EmailId = x.EmailId,
                JoiningDate = x.JoiningDate,
                Salary = x.Salary,
                Status = x.Status
            }).ToListAsync();
            return employees;
        }

        public async Task<EmployeeQueryModel> GetById(int id)
        {
            var employee = await _context.Employees.AsNoTracking().Include(x => x.Department).Where(x => x.Id == id).Select(x => new EmployeeQueryModel
            {
                Id = x.Id,
                Name = x.Name,
                Department = x.Department.Name,
                EmailId = x.EmailId,
                JoiningDate = x.JoiningDate,
                Salary = x.Salary,
                Status = x.Status
            }).FirstOrDefaultAsync();
            return employee;
        }
    }
}
