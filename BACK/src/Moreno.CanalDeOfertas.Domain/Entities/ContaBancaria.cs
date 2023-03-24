using Moreno.CanalDeOfertas.Domain.Entities.Base;
using Moreno.CanalDeOfertas.Domain.Enums;

namespace Moreno.CanalDeOfertas.Domain.Entities
{
    public class ContaBancaria : Entity
    {
        public int CodigoBanco { get; private set; }
        public int Agencia { get; private set; }
        public int NumeroConta { get; private set; }
        public TipoContaBancariaEnum TipoContaBancaria { get; private set; }
        public TipoChavePixEnum TipoChavePix { get; private set; }
        public string ChavePix { get; private set; }
        public virtual CasaInvestimento CasaInvestimento { get; private set; }
        public ContaBancaria() { }
        public ContaBancaria(int codigoBanco, int agencia, int numeroConta, TipoContaBancariaEnum tipoContaBancaria)
        {
            CodigoBanco = codigoBanco;
            Agencia = agencia;
            NumeroConta = numeroConta;
            TipoContaBancaria = tipoContaBancaria;
        }

        public void DefinirChavePix(TipoChavePixEnum tipoChavePix, string chavePix)
        {
            TipoChavePix = tipoChavePix;
            ChavePix = chavePix;
        }
        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}