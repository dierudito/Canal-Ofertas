using DomainValidation.Interfaces.Specification;
using Moreno.CanalDeOfertas.Domain.Entities;
using Moreno.CanalDeOfertas.Domain.Interfaces;

namespace Moreno.CanalDeOfertas.Domain.Specifications.CasaInvestimentos;

public class CasaInvestimentoDevePossuirRazaoSocialUnicaSpecification : ISpecification<CasaInvestimento>
{
    private readonly ICasaInvestimentoRepository _casaInvestimentoRepository;

    public CasaInvestimentoDevePossuirRazaoSocialUnicaSpecification(ICasaInvestimentoRepository casaInvestimentoRepository)
    {
        _casaInvestimentoRepository = casaInvestimentoRepository;
    }
    public async Task<bool> IsSatisfiedByAsync(CasaInvestimento casaInvestimento)
    {
        var casasInvestimento =
            await _casaInvestimentoRepository.BuscarAsync(casa => casa.RazaoSocial == casaInvestimento.RazaoSocial &&
                                                          casa.Id == casaInvestimento.Id);

        return !casasInvestimento.Any();
    }
}
