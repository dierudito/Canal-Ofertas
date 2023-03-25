using DomainValidation.Validation;
using Moreno.CanalDeOfertas.Domain.Entities;
using Moreno.CanalDeOfertas.Domain.Interfaces;
using Moreno.CanalDeOfertas.Domain.Specifications.CasaInvestimentos;

namespace Moreno.CanalDeOfertas.Domain.Validations.CasasInvestimento;

public class CasaInvestimentoEstaAptoParaCadastroValidation : Validator<CasaInvestimento>
{
    public CasaInvestimentoEstaAptoParaCadastroValidation(ICasaInvestimentoRepository casaInvestimentoRepository)
    {
        var cnpjUnico = new CasaInvestimentoDevePossuirCNPJUnicoSpecification(casaInvestimentoRepository);
        var razaoSocialUnica = new CasaInvestimentoDevePossuirRazaoSocialUnicaSpecification(casaInvestimentoRepository);

        Add("cnpjUnico", new Rule<CasaInvestimento>(cnpjUnico, "Já existe uma casa de investimento com esse CNPJ"));
        Add("razaoSocialUnica", new Rule<CasaInvestimento>(razaoSocialUnica, "Já existe uma casa de investimento com essa Razão Social"));
    }
}
