using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Learning.Repositories.Interfaces.Employee;
using CQRS_Learning.Repositories.Interfaces.Location;
using FluentValidation;

namespace CQRS_Learning.Commands.CreateEmployee
{
    public class CreateEmployeeCommandValidation : AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeCommandValidation(
            IEmployeeRepository employeeRepo,
            ILocationRepository locationRepo)
        {
            RuleFor(x => x.EmployeeId)
                .Must(x => !employeeRepo.Exists(x))
                .WithMessage("An employee with this id already exists");

            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("First name can not be null/empty");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Last name can not be null/empty");

            RuleFor(x => x.JobTitle)
                .NotEmpty()
                .WithMessage("The job title can not be blank");
        }
    }
}
