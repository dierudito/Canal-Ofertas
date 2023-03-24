using Moreno.CanalDeOfertas.Domain.Entities.Base;

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
            ContaBancaria = contaBancaria;
            Enderecos = new List<Endereco>();
        }

        public void AdicionarEndereco(Endereco endereco)
        {
            if (endereco.EhValido())
                Enderecos.Add(endereco);
        }


        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
