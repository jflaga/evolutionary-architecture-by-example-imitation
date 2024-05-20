using Fitnet.Contracts.Data.Database;

namespace Fitnet.Contracts.GetAllContracts;

public static class GetAllContractsEndpoint
{
    internal static void MapGetAllContracts(this IEndpointRouteBuilder app) =>
        app.MapGet(ContractsApiPaths.GetAll, (ContractsPersistence persistence) =>
        {
            return Results.Ok(persistence.Contracts);
        });
}
