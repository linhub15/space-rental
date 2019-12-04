using System;
using SpaceRental.Core.Entities;
using SpaceRental.Core.Gateways;

namespace SpaceRental.Core.UseCases
{
    public interface IRegisterUserInteractor
        : IUseCaseInteractor<RegisterUserRequest, RegisterUserResponse>
    {}

    public class RegisterUserInteractor : IRegisterUserInteractor
    {
        private IAuthGateway _authGateway; 
        public RegisterUserInteractor(IAuthGateway auth)
        {
            _authGateway = auth;
        }

        public RegisterUserResponse Handle(RegisterUserRequest request)
        {
            // Build user object to send to auth gateway.
            var user = new User();
            _authGateway.CreateUser(user);

            // return the JWT so they can continue in the app

            throw new NotImplementedException();
        }
    }
}
