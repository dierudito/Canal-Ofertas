namespace Moreno.CanalDeOfertas.Domain.Interfaces;

public interface IUnitOfWork
{
    Task CommitAsync();
    Task BeginTransactionAsync();
    Task RollbackAsync();
    Task<bool> SaveChangesAsync();
}
