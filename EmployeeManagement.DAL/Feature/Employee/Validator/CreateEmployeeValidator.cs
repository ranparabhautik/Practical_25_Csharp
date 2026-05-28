using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.DAL.Feature.Employee.Commands;
using FluentValidation;
namespace EmployeeManagement.DAL.Feature.Employee.Validator
{
    public class CreateEmployeeValidator:AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is Required").MaximumLength(50).WithMessage("Name must not exceed 50 characters");

            RuleFor(x => x.Salary).GreaterThan(0).WithMessage("Salary must be greater than 0").LessThanOrEqualTo(1000000).WithMessage("Salary must not exceed 1,000,000");

            RuleFor(x => x.EmailId).NotEmpty().WithMessage("Email is Required").EmailAddress().WithMessage("Invalid email format");

            RuleFor(x => x.DepartmentId).NotEmpty().GreaterThan(0);
        }
    }
}
