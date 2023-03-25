using DomainValidation.Validation;
using Moreno.CanalDeOfertas.Domain.Entities;
using Moreno.CanalDeOfertas.Domain.Interfaces;
using Moreno.CanalDeOfertas.Domain.Specifications.Enderecos;

namespace Moreno.CanalDeOfertas.Domain.Validations.Enderecos;

public class EnderecoEstaAptoParaCadastroValidation : Validator<Endereco>
{
    public EnderecoEstaAptoParaCadastroValidation(IEnderecoRepository enderecoRepository)
    {
        var enderecoUnicoParaCasaDoInvestimento = new EnderecoDeveSerUnicoParaCasaDeInvestimentoSpecification(enderecoRepository);

        Add("enderecoUnicoParaCasaDoInvestimento", 
            new Rule<Endereco>(enderecoUnicoParaCasaDoInvestimento, 
            "Endereço já cadastrado para esta casa de investimento"));
    }
}
