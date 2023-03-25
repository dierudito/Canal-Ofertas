using Moreno.CanalDeOfertas.Domain.Entities;

namespace Moreno.CanalDeOfertas.Domain.Interfaces;

public interface IEnderecoRepository : IRepositoryRead<Endereco>, IRepositoryWrite<Endereco>
{
    Task<IEnumerable<Endereco>> ObterEnderecosDaCasaDeInvestimentoAsync(Guid CasaInvestimentoId);
}

