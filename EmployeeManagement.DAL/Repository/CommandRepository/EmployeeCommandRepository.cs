using Azure.Core;
using EmployeeManagement.DAL.Data;
using EmployeeManagement.DAL.Feature.Employee.Commands;
using EmployeeManagement.DAL.Model.CommandModel;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Repository.CommandRepository
{
    public class EmployeeCommandRepository : IEmployeeCommandRepository
    {
        private readonly AppDbContext _context;
        public EmployeeCommandRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(CreateEmployeeCommand entity)
        {
            var emp = new Entities.Employee()
            {
                Name = entity.Name,
                DepartmentId = entity.DepartmentId,
                EmailId = entity.EmailId,
                Salary = entity.Salary
            };
            await _context.Employees.AddAsync(emp);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var emp = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if(emp == null)
            {
                throw new Exception("Employee no exist");
            }
            emp.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task Update(int id, UpdateEmployeeCommand entity)
        {
            var emp = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if (emp == null)
            {
               throw new Exception("Employee doest not exist");
            }
            emp.Name = entity.Name;
            emp.Salary = entity.Salary;
            emp.DepartmentId = entity.DepartmentId;
            emp.EmailId = entity.EmailId;
            await _context.SaveChangesAsync();
        }
    }
}
