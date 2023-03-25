using Moreno.CanalDeOfertas.Domain.Entities.Base;

namespace Moreno.CanalDeOfertas.Domain.Interfaces
{
    public interface IServiceBase<TEntity> : IDisposable where TEntity : Entity
    {
        Task<Entity> AdicionarAsync(Entity entity);
        Task<Entity> AtualizarAsync(Entity entity);
        Task RemoverAsync(Guid id);
    }
}
