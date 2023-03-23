using DomainValidationCore.Validation;

namespace Moreno.CanalDeOfertas.Domain.Entities.Base
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
            ValidationResult = new ValidationResult();
        }
        public ValidationResult ValidationResult { get; set; }

        public void AdicionarErroValidacao(string erro, string mensagem)
        {
            ValidationResult.Add(new ValidationError(erro, mensagem));
        }

        public void AdicionarErrosValidacao(ValidationResult validationResult)
        {
            ValidationResult.Add(validationResult);
        }

        public void ZerarListaErros()
        {
            ValidationResult = new ValidationResult();
        }

        public abstract bool EhValido();
    }
}
