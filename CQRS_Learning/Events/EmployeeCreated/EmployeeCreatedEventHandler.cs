using AutoMapper;
using CQRS_Learning.ReadModels;
using CQRS_Learning.Repositories.Interfaces.Employee;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Learning.Events.EmployeeCreated
{
    public class EmployeeCreatedEventHandler : INotificationHandler<EmployeeCreatedEvent>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepo;

        public EmployeeCreatedEventHandler(
            IMapper mapper,
            IEmployeeRepository employeeRepo)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _employeeRepo = employeeRepo ?? throw new ArgumentNullException(nameof(employeeRepo));
        }

        public async Task Handle(
            EmployeeCreatedEvent notification,
            CancellationToken cancellationToken)
        {
            EmployeeRM employee = _mapper.Map<EmployeeRM>(notification);
            _employeeRepo.Save(employee);
        }
    }
}
