using SimpleCrudBackEndNetCore.Domain.Commands.PersonCommands.Validations;
using SimpleCrudBackEndNetCore.Domain.Core.Models;

namespace SimpleCrudBackEndNetCore.Domain.Commands
{
    public class DeletePersonCommand : Command
    {
        public DeletePersonCommand(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; private set; } 

        public override bool IsValid()
        {
            ValidationResult = new DeletePersonCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
