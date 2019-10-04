using System.Linq;
using System.Threading.Tasks;
using AutoFixture;
using Google.Protobuf.Collections;
using Grpc.Core;

namespace Incidents.gRPC.Services
{
    public class IncidentsService : Incidents.IncidentsBase
    {
        private Fixture _fixture = new Fixture();
        
        public override Task<ObjectId> Create(IncidentModel request, ServerCallContext context)
        {
            return Task.FromResult(_fixture.Create<ObjectId>());
        }

        public override Task<IncidentDto> Get(IncidentRequest request, ServerCallContext context)
        {
            _fixture.Customize<IncidentDto>(c =>
                c.With(dto => dto.Id, () => request.Id));

            return Task.FromResult(_fixture.Create<IncidentDto>());        }

        public override Task<IncidentsListReply> GetAll(IncidentsRequest request, ServerCallContext context)
        {
            _fixture.Customize<IncidentsListReply>(c =>
                c.Do(dto =>
                {
                    var result = _fixture.CreateMany<IncidentsListItem>(request.Limit > 0 ? request.Limit : 100)
                        .ToList();
                    dto.Items.AddRange(result);
                }));
            return Task.FromResult(_fixture.Create<IncidentsListReply>());
        }
    }
}