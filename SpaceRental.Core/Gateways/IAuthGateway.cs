using System;
using SpaceRental.Core.Entities;

namespace SpaceRental.Core.Gateways
{
    public interface IAuthGateway
    {
        string Login(string email, string password);
    }
}