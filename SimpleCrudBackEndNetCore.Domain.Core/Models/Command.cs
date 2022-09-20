using FluentValidation.Results;
using MediatR;


namespace SimpleCrudBackEndNetCore.Domain.Core.Models
{
    public class Command : IRequest<ValidationResult>
    {
        public ValidationResult ValidationResult { get; protected set; }

        protected Command()
        {
            ValidationResult = new ValidationResult();
        }

        public void AddValidationError(string error, string description)
        {
            ValidationResult.Errors.Add(new ValidationFailure(error, description));
        }

        public virtual bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
