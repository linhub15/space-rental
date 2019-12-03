using System;

namespace SpaceRental.Core.UseCases
{
    public interface IRegisterUserInteractor
        : IUseCaseInteractor<RegisterUserRequest, RegisterUserResponse>
    {}

    public class RegisterUserInteractor : IRegisterUserInteractor
    {
        public RegisterUserResponse Handle(RegisterUserRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
