using Bogus.Extensions.Brazil;

using Moreno.CanalDeOfertas.Domain.Entities;

namespace Moreno.CanalDeOfertas.UnityTests.Domain.Entities;

public class CasaInvestimentoTest
{
    private readonly Faker _faker;

    public CasaInvestimentoTest()
    {
        _faker = new Faker();
    }
    [Fact]
    public async Task DeveAdicionarEnderecoComSucesso()
    {
        // Arrange
        var contaBancaria = 
            new ContaBancaria(_faker.Random.Number(1, 999), _faker.Random.Number(1, 999), 
            _faker.Random.Number(1, 999), CanalDeOfertas.Domain.Enums.TipoContaBancariaEnum.Corrente);
        var casaInvestimento = new CasaInvestimento(_faker.Company.CompanyName(), _faker.Company.Cnpj(), 
            _faker.Phone.PhoneNumber(), _faker.Internet.Email(), contaBancaria);
        var cep = $"{_faker.Random.Number(11111, 99999)}-{_faker.Random.Number(111, 999)}";
        var endereco = new Endereco(_faker.Address.CityPrefix(), _faker.Address.City(), 
            _faker.Random.AlphaNumeric(2), cep, casaInvestimento.Id);

        // Act
        await casaInvestimento.AdicionarEnderecoAsync(endereco);

        // Asset
        casaInvestimento.Enderecos.Should().HaveCount(1);
        casaInvestimento.Enderecos.FirstOrDefault().Should().BeEquivalentTo(endereco);
    }
}
