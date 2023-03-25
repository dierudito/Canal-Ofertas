using DomainValidation.Interfaces.Specification;
using Moreno.CanalDeOfertas.Domain.Entities;

namespace Moreno.CanalDeOfertas.Domain.Specifications.Enderecos;

public class EnderecoDeveTerUFValidoSpecification : ISpecification<Endereco>
{
    public async Task<bool> IsSatisfiedByAsync(Endereco endereco) => !string.IsNullOrWhiteSpace(endereco.Uf) && endereco.Uf.Length == 2;
}
