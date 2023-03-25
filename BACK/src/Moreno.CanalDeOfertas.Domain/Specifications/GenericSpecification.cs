using DomainValidation.Interfaces.Specification;
using Moreno.CanalDeOfertas.Domain.Entities.Base;
using System.Linq.Expressions;

namespace Moreno.CanalDeOfertas.Domain.Specifications;


public class GenericSpecification<T> : ISpecification<T> where T : Entity
{
    public Expression<Func<T, bool>> Expression { get; }

    public GenericSpecification(Expression<Func<T, bool>> expression)
    {
        Expression = expression;
    }

    public async Task<bool> IsSatisfiedByAsync(T entity) => Expression.Compile().Invoke(entity);
}