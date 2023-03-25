using DomainValidation.Interfaces.Specification;
using Moreno.CanalDeOfertas.Domain.Entities;

namespace Moreno.CanalDeOfertas.Domain.Specifications.CasaInvestimentos;

public class CasaInvestimentoDeveTerRazaoSocialSpecification : ISpecification<CasaInvestimento>
{
    public async Task<bool> IsSatisfiedByAsync(CasaInvestimento casaInvestimento) => 
        !string.IsNullOrWhiteSpace(casaInvestimento.RazaoSocial) && casaInvestimento.RazaoSocial.Length > 4;
}
