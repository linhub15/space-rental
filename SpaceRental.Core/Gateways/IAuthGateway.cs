using System;
using SpaceRental.Core.Entities;

namespace SpaceRental.Core.Gateways
{
    public interface IAuthGateway
    {
        Guid CreateUser(User user);
    }
}