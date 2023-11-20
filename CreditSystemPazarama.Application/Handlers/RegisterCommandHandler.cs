using System.Threading;
using System.Threading.Tasks;
using CreditSystemPazarama.Contracts.Authentication;
using CreditSystemPazarama.Domain.Entity;
using CreditSystemPazarama.Infrastructure;
using MediatR;

namespace CreditSystemPazarama.Application.Handlers;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, bool>
{
    private readonly PazaramaContext _dbContext;

    public RegisterCommandHandler(PazaramaContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<bool> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        var customer = new Customer
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            IdentityNumber = request.IdentityNumber
        };

        _dbContext.Customers.Add(customer);
        await _dbContext.SaveChangesAsync();
        return true;
    }
}