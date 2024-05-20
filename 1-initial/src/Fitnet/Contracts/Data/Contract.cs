namespace Fitnet.Contracts.Data;

public class Contract(Guid id)
{
    public Guid Id { get; } = id;

    internal static Contract Prepare() => new(Guid.NewGuid());
}
