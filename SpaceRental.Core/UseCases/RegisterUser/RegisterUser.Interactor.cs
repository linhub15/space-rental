using SpaceRental.Core.Entities;
using SpaceRental.Core.Gateways;

namespace SpaceRental.Core.UseCases
{
    public interface IRegisterUserInteractor
        : IUseCaseInteractor<RegisterUserRequest, RegisterUserResponse>
    { }

    public class RegisterUserInteractor : IRegisterUserInteractor
    {
        private IRepositoryGateway<User> _users;
        private IAuthGateway _auth;
        public RegisterUserInteractor(
            IRepositoryGateway<User> userRepository,
            IAuthGateway auth)
        {
            _users = userRepository;
            _auth = auth;
        }

        public RegisterUserResponse Handle(RegisterUserRequest request)
        {
            // Save the new user
            var user = new User();
            _users.Create(user);

            // return the JWT so they can continue in the app
            var jwt = _auth.Login(user.Email, user.Password);
            return new RegisterUserResponse() { jwt = jwt };
        }
    }
}
