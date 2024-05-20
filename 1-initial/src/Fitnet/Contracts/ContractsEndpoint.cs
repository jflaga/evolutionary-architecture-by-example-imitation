using Fitnet.Contracts.GetAllContracts;
using Fitnet.Contracts.PrepareContract;

namespace Fitnet.Contracts;

public static class ContractsEndpoint
{
    internal static void Map(WebApplication app)
    {
        app.MapPrepareContract();
        app.MapGetAllContracts();
    }
}
