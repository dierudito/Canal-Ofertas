using DomainValidation.Interfaces.Specification;
using Moreno.CanalDeOfertas.Domain.Entities;

namespace Moreno.CanalDeOfertas.Domain.Specifications.CasaInvestimentos;

public class CasaInvestimentoDeveTerTelefoneSpecification : ISpecification<CasaInvestimento>
{
    private const int TELEFONE_COM_DDD_SEM_9 = 10;
    private const int TELEFONE_COM_DDD_COM_9 = 11;

    public async Task<bool> IsSatisfiedByAsync(CasaInvestimento casaInvestimento) =>
        !string.IsNullOrWhiteSpace(casaInvestimento.Telefone) && 
        (casaInvestimento.Telefone.Length == TELEFONE_COM_DDD_COM_9 ||
        casaInvestimento.Telefone.Length == TELEFONE_COM_DDD_SEM_9);
}