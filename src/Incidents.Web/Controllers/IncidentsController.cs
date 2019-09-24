using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoFixture;
using Microsoft.AspNetCore.Mvc;

namespace Incidents.Web.Controllers
{
    public class IncidentsController : Controller
    {
        private Fixture _fixture = new Fixture();
        
        [Route("/api/incidents/")]
        [HttpGet]
        public Task<IncidentListDto> GetAll(int? limit, int? offset, CancellationToken cancellationToken)
        {
            _fixture.Customize<IncidentListDto>(c =>
                c.With(dto => dto.Items, () => _fixture.CreateMany<IncidentListItemDto>(offset ?? 100).ToList()));
            return Task.FromResult(_fixture.Create<IncidentListDto>());
        }
        
        [Route("/api/incidents/")]
        [HttpPost]
        public Task<ObjectId> Create(IncidentModel request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_fixture.Create<ObjectId>());
        }

        [Route("/api/incidents/{id}")]
        [HttpGet]
        public Task<IncidentDto> Get(Guid id, CancellationToken cancellationToken)
        {
            _fixture.Customize<IncidentDto>(c =>
                c.With(dto => dto.Id, () => id));

            return Task.FromResult(_fixture.Create<IncidentDto>());
        }
    }
}