using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Incidents.Web.Controllers
{
    public class IncidentsController : Controller
    {
        public Task<IncidentListDto> GetAll(int? limit, int? offset, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ObjectId> Create(IncidentModel request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IncidentDto> Get(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}