using EmployeeManagement.DAL.Feature.Employee.Query;
using EmployeeManagement.DAL.Repository.QueryRepository;
using MediatR;

namespace EmployeeManagement.DAL.Feature.Employee.Handler
{
    public class GetEmployeeHandler : IRequestHandler<GetEmployeeQuery, object>
    {
        private readonly IEmployeeQueryRepository _qryrepo;
        public GetEmployeeHandler(IEmployeeQueryRepository qryrepo)
        {
            _qryrepo = qryrepo;
        }

        public async Task<object> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            if (request.Id.HasValue)
            {
                return await _qryrepo.GetById(request.Id.Value);
            }
            return await _qryrepo.GetAll();
        }
    }
}
