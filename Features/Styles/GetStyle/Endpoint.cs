using FastEndpoints;

namespace Crosshair.Features.Styles.GetStyle;

internal sealed class Endpoint : EndpointWithoutRequest<Response>
{
    public override void Configure()
    {
        Get("api/styles");
        AllowAnonymous();
    }

    public override Task HandleAsync(CancellationToken ct)
    {
        return SendOkAsync(Data.GetStyle(), ct);
    }
}