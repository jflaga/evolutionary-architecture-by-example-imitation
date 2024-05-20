using Fitnet.Contracts.Data;
using Fitnet.Contracts.Data.Database;

namespace Fitnet.Contracts.PrepareContract;

public static class PrepareContractEndpoint
{
    internal static void MapPrepareContract(this IEndpointRouteBuilder app) => 
        app.MapPost(ContractsApiPaths.Prepare, (ContractsPersistence persistence) =>
        {
            var contract = Contract.Prepare();
            persistence.Add(contract);

            return Results.Created($"/{ContractsApiPaths.Prepare}/{contract.Id}", contract.Id);
        })
        .WithOpenApi(operation => new(operation)
        {
            Summary = "Prepare Contract",
        });
}
