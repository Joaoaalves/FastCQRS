namespace Joaoaalves.FastCQRS.Infrastructure.Persistence.Context
{
    public interface IChangeTracker
    {
        IEnumerable<IEntryAdapter> Entries();
    }
}