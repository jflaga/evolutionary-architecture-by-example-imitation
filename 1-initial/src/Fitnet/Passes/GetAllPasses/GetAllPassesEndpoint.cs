using Fitnet.Passes.Data;
using Fitnet.Passes.Data.Database;

namespace Fitnet.Passes.GetAllPasses;

public static class GetAllPassesEndpoint
{
    internal static void MapGetAllPasses(this IEndpointRouteBuilder app) =>
        app.MapGet(PassesApiPaths.Passes, (PassesPersistence persistence) =>
        {
            return Results.Ok(persistence.Passes);
        });
}
