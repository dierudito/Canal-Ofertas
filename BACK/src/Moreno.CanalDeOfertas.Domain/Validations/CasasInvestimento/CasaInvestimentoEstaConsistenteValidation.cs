using DomainValidation.Validation;
using Moreno.CanalDeOfertas.Domain.Entities;
using Moreno.CanalDeOfertas.Domain.Specifications;
using Moreno.CanalDeOfertas.Domain.Specifications.CasaInvestimentos;
using Moreno.CanalDeOfertas.Domain.Value_Objects;

namespace Moreno.CanalDeOfertas.Domain.Validations.CasasInvestimento;

public class CasaInvestimentoEstaConsistenteValidation : Validator<CasaInvestimento>
{
    public CasaInvestimentoEstaConsistenteValidation()
    {
        var razaoSocial = new CasaInvestimentoDeveTerRazaoSocialSpecification();
        var telefone = new CasaInvestimentoDeveTerTelefoneSpecification();
        var emailValido = new GenericSpecification<CasaInvestimento>(casa => Email.Validar(casa.Email));
        var cnpjValido = new GenericSpecification<CasaInvestimento>(casa => CNPJ.Validar(casa.Cnpj));

        Add("razaoSocial", new Rule<CasaInvestimento>(razaoSocial, "Informe a razão social"));
        Add("telefone", new Rule<CasaInvestimento>(telefone, "Informe o telefone"));
        Add("emailValido", new Rule<CasaInvestimento>(emailValido, "Informe um e-mail válido"));
        Add("cnpjValido", new Rule<CasaInvestimento>(cnpjValido, "Informe um cnpj válido"));
    }
}
