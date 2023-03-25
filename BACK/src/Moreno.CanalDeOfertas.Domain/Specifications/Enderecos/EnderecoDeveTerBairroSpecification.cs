using DomainValidation.Interfaces.Specification;
using Moreno.CanalDeOfertas.Domain.Entities;

namespace Moreno.CanalDeOfertas.Domain.Specifications.Enderecos;

public class EnderecoDeveTerBairroSpecification : ISpecification<Endereco>
{
    public async Task<bool> IsSatisfiedByAsync(Endereco endereco) => !string.IsNullOrWhiteSpace(endereco.Bairro);
}
