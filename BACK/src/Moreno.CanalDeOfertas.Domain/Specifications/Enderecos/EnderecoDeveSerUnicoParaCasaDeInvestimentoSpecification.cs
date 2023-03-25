using DomainValidation.Interfaces.Specification;
using Moreno.CanalDeOfertas.Domain.Entities;
using Moreno.CanalDeOfertas.Domain.Interfaces;

namespace Moreno.CanalDeOfertas.Domain.Specifications.Enderecos;

public class EnderecoDeveSerUnicoParaCasaDeInvestimentoSpecification : ISpecification<Endereco>
{
    private readonly IEnderecoRepository _enderecoRepository;

    public EnderecoDeveSerUnicoParaCasaDeInvestimentoSpecification(IEnderecoRepository enderecoRepository)
    {
        _enderecoRepository = enderecoRepository;
    }

    public async Task<bool> IsSatisfiedByAsync(Endereco endereco)
    {
        var enderecoExistente = 
            await _enderecoRepository.BuscarAsync(e => e.Logradouro == endereco.Logradouro && 
            e.NumeroLogradouro == endereco.NumeroLogradouro && e.Complemento == endereco.Complemento &&
            e.Municipio == endereco.Municipio && e.Bairro == endereco.Bairro && 
            e.CasaInvestimentoId == endereco.CasaInvestimentoId && e.Uf == endereco.Uf && 
            e.Cep == endereco.Cep);
        return !enderecoExistente.Any();
    }
}
