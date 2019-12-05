using System;

namespace SpaceRental.Core.Gateways
{
    public interface IRepositoryGateway<TEntity>
    {
        TEntity Get(Guid id);
        TEntity Create(TEntity entity);
    }
}