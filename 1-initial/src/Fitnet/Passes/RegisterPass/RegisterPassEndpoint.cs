using Fitnet.Passes.Data;
using Fitnet.Passes.Data.Database;

namespace Fitnet.Passes.RegisterPass;

public static class RegisterPassEndpoint
{
    internal static void MapRegisterPass(this IEndpointRouteBuilder app) =>
        app.MapPost(PassesApiPaths.Passes, (RegisterPassRequest request, PassesPersistence persistence) =>
        {
            var pass = Pass.Register(request.CustomerId, request.From, request.To);
            persistence.Add(pass);
            return Results.Created($"{PassesApiPaths.Passes}/{pass.Id}", pass.Id);
        });
}
