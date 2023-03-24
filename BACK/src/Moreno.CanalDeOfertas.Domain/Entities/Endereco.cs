using Moreno.CanalDeOfertas.Domain.Entities.Base;

namespace Moreno.CanalDeOfertas.Domain.Entities;

public class Endereco : Entity
{
    public string Logradouro { get; private set; }
    public string NumeroLogradouro { get; private set; }
    public string Complemento { get; private set; }
    public string Bairro { get; private set; }
    public string Municipio { get; private set; }
    public string Cep { get; private set; }
    public string Uf { get; private set; }

    public virtual CasaInvestimento CasaInvestimento { get; private set; }

    public Endereco()
    {
        
    }

    public Endereco(string bairro, string municipio, string uf, string cep)
    {
        Bairro = bairro;
        Municipio = municipio;
        Uf = uf;
        Cep = cep;
    }

    public void DefinirLogradouro(string logradouro)
    {
        Logradouro = logradouro;
    }

    public void DefinirNumeroLogradouro(string numeroLogradouro)
    {
        NumeroLogradouro = numeroLogradouro;
    }

    public void DefinirComplemento(string complemento)
    {
        Complemento = complemento;
    }

    public override bool EhValido()
    {
        return true;
    }
}