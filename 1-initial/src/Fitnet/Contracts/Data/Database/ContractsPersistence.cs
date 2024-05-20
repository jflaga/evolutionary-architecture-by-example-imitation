namespace Fitnet.Contracts.Data.Database;

public class ContractsPersistence
{
    internal static List<Contract> contracts { get; } = [];

    internal List<Contract> Contracts { get; } = contracts;

    internal void Add(Contract contract)
    {
        Contracts.Add(contract);
    }
}
