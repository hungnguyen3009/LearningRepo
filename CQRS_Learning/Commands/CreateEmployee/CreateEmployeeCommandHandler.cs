using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CQRS_Learning.Models;
using MediatR;
using SimpleCqrs.Commanding;

namespace CQRS_Learning.Commands.CreateEmployee
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand>
    {
        public async Task<Unit> Handle(
            CreateEmployeeCommand request,
            CancellationToken cancellationToken)
        {
            var employee = new Employee(
                request.EmployeeId,
                request.FirstName,
                request.LastName,
                request.DateOfBirth,
                request.JobTitle);

            return Unit.Value;
        }
    }
}
