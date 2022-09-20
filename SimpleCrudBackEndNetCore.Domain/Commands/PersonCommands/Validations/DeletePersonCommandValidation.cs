using FluentValidation;

namespace SimpleCrudBackEndNetCore.Domain.Commands.PersonCommands.Validations
{
    public class DeletePersonCommandValidation : AbstractValidator<DeletePersonCommand> 
    {
        public DeletePersonCommandValidation() 
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty)
                .WithMessage("É obrigatório ter um Id!");
        }
    }
}
