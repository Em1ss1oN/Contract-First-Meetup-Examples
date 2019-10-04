using System;
using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace Incidents.gRPC.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClientHandler = new HttpClientHandler();
// Return `true` to allow certificates that are untrusted/invalid
            httpClientHandler.ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            var httpClient = new HttpClient(httpClientHandler);
            var channel = GrpcChannel.ForAddress("https://localhost:5001",
                new GrpcChannelOptions() {HttpClient = httpClient});

            var incidentsClient = new Incidents.IncidentsClient(channel);

            var incidents = await incidentsClient.GetAllAsync(new IncidentsRequest() {Limit = 100, Offset = 0});

            foreach (var item in incidents.Items)
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}