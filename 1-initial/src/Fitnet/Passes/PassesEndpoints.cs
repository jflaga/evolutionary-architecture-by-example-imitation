using Fitnet.Passes.GetAllPasses;
using Fitnet.Passes.RegisterPass;

namespace Fitnet.Passes;

public static class PassesEndpoints
{
    internal static void Map(WebApplication app)
    {
        app.MapRegisterPass();
        app.MapGetAllPasses();
    }
}
