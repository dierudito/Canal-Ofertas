using Moreno.CanalDeOfertas.Domain.Entities.Base;
using Moreno.CanalDeOfertas.Domain.Validations.CasasInvestimento;

namespace Moreno.CanalDeOfertas.Domain.Entities
{
    public class CasaInvestimento : Entity
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public ContaBancaria ContaBancaria { get; private set; }
        public virtual ICollection<Endereco> Enderecos { get; private set; }

        public CasaInvestimento()
        {

        }

        public CasaInvestimento(string razaoSocial, string cnpj, string telefone, string email, ContaBancaria contaBancaria)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            Email = email;
            Telefone = telefone;
            Enderecos = new List<Endereco>();
            DefinirContaBancaria(contaBancaria).Wait();
        }

        private async Task DefinirContaBancaria(ContaBancaria contaBancaria)
        {
            if(await contaBancaria.EhValidoAsync())
                ContaBancaria = contaBancaria;
        }

        public async Task AdicionarEnderecoAsync(Endereco endereco)
        {
            if (await endereco.EhValidoAsync())
                Enderecos.Add(endereco);
        }


        public override async Task<bool> EhValidoAsync()
        {
            ValidationResult = await new CasaInvestimentoEstaConsistenteValidation().ValidateAsync(this);
            return ValidationResult.IsValid;
        }
    }
}
