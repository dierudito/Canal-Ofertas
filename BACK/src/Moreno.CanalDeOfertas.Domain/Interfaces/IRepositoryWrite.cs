using Moreno.CanalDeOfertas.Domain.Entities.Base;

namespace Moreno.CanalDeOfertas.Domain.Interfaces;

public interface IRepositoryWrite<TEntity> : IDisposable where TEntity : Entity
{
    Task AdicionarAsync(TEntity obj);
    Task AtualizarAsync(TEntity obj);
    Task RemoverAsync(Guid id);
    Task<int> SaveChangesAsync();
}
