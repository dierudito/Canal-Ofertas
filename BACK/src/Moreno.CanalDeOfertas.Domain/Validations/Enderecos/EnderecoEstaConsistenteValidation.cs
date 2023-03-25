using DomainValidation.Validation;
using Moreno.CanalDeOfertas.Domain.Entities;
using Moreno.CanalDeOfertas.Domain.Specifications;
using Moreno.CanalDeOfertas.Domain.Specifications.Enderecos;
using Moreno.CanalDeOfertas.Domain.Value_Objects;

namespace Moreno.CanalDeOfertas.Domain.Validations.Enderecos;

public class EnderecoEstaConsistenteValidation : Validator<Endereco>
{
    public EnderecoEstaConsistenteValidation()
    {
        var enderecoBairro = new EnderecoDeveTerBairroSpecification();
        var enderecoMunicipio = new EnderecoDeveTerMunicipioSpecification();
        var enderecoUF = new EnderecoDeveTerUFValidoSpecification();
        var enderecoCep = new GenericSpecification<Endereco>(endereco => CEP.ValidaCEP(endereco.Cep));

        Add("enderecoBairro", new Rule<Endereco>(enderecoBairro, "O bairro do endereço deve ser informado"));
        Add("enderecoMunicipio", new Rule<Endereco>(enderecoMunicipio, "O município do endereço deve ser informado"));
        Add("enderecoUF", new Rule<Endereco>(enderecoUF, "O UF do endereço deve ser informado"));
        Add("enderecoCep", new Rule<Endereco>(enderecoCep, "Informe um cep válido para o endereço"));
    }
}
