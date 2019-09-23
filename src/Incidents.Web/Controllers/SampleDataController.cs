using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Incidents.Web.Controllers
{
    public class IncidentsController : IncidentsControllerBase
    {
        public override Task<IncidentListDto> GetAll(int? limit, int? offset, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public override Task<ObjectId> Create(IncidentModel request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public override Task<IncidentDto> Get(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}