using FastEndpoints;
using MinimalService.Web.Models.Requests;
using MinimalService.Web.Models.Responses;

namespace MinimalService.Web.Endpoints;

public class RandomStringEndpoint : Endpoint<RandomStringRequest, RandomStringResponse>
{
    public override void Configure()
    {
        Get("/api/v1/random-string");
        AllowAnonymous();
    }

    public override Task HandleAsync(RandomStringRequest req, CancellationToken ct) =>
        SendOkAsync(
            new RandomStringResponse(req.Prefix ?? "", "abc"),
            ct
        );
}
