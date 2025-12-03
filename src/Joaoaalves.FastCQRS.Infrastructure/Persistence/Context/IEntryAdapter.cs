namespace Joaoaalves.FastCQRS.Infrastructure.Persistence.Context
{
    public interface IEntryAdapter
    {
        EntityState State { get; set; }
    }
}