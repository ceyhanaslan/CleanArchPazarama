using MediatR;

namespace CreditSystemPazarama.Contracts.Authentication;

public class RegisterCommand : IRequest<bool>
{
    public long IdentityNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}