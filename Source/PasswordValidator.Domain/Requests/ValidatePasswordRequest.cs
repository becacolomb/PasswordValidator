using MediatR;
using PasswordValidator.Domain.Models.Passwords;
using PasswordValidator.Domain.Results;

namespace PasswordValidator.Domain.Requests
{
    public class ValidatePasswordRequest : IRequest<ValidatePasswordResult>
    {
        public ValidatePasswordRequest(Password password)
        {
            Password = password;
        }

        public Password Password { get; private set; }
    }
}
