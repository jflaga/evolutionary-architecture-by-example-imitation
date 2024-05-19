namespace Fitnet.Passes.Data.Database;

public class PassesPersistence
{
    internal static List<Pass> passes { get; } = [];

    internal List<Pass> Passes { get; } = passes;

    internal void Add(Pass pass)
    {
        Passes.Add(pass);
    }
}
