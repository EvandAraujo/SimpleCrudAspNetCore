using FluentValidation.Results;
using MediatR;
using SimpleCrudBackEndNetCore.Domain.Commands;
using SimpleCrudBackEndNetCore.Domain.Contracts.Repositories;
using SimpleCrudBackEndNetCore.Domain.Entities;

namespace SimpleCrudBackEndNetCore.Domain.CommandHandlers
{
    public class PersonCommandHandler :
        IRequestHandler<CreatePersonCommand, ValidationResult>,
        IRequestHandler<UpdatePersonCommand, ValidationResult>,
        IRequestHandler<DeletePersonCommand, ValidationResult>
    {
        private readonly IPersonRepository _personRepository;

        public PersonCommandHandler(IPersonRepository personRepository)  
        {
            _personRepository = personRepository;
        }

        public async Task<ValidationResult> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
                return request.ValidationResult; 

            Person person = new(
                request.Name,
                request.LastName,
                request.Email,
                request.PhoneNumber,
                request.Nationality,
                request.ZoneInformationPostalCode,
                request.BrazilianUfId,
                request.City,
                request.PublicPlace); 

            if (person.IsValid())
            {
                _personRepository.Add(person);
            }

            return await Task.FromResult(person.ValidationResult);
        }

        public async Task<ValidationResult> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
                return request.ValidationResult; 

            Person person = _personRepository.GetById(request.Id);

            if (person == null)
            {
                request.AddValidationError("Post", "Pessoa não foi encontrado!");
                return request.ValidationResult;
            }

            person.Update(
                request.Name,
                request.LastName,
                request.Email,
                request.PhoneNumber,
                request.Nationality,
                request.ZoneInformationPostalCode,
                request.BrazilianUfId,
                request.City,
                request.PublicPlace); 

            if (person.IsValid())
            {
                _personRepository.Update(person); 
            }

            return await Task.FromResult(person.ValidationResult);
        }

        public async Task<ValidationResult> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
                return request.ValidationResult;

            Person person = _personRepository.GetById(request.Id);

            if (person == null)
            {
                request.AddValidationError("Delete", "Pessoa não foi encontrado!"); 
                return request.ValidationResult;
            }

            _personRepository.Remove(person);

            return await Task.FromResult(person.ValidationResult);
        }
    }
}
