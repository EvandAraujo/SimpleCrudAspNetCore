using FluentValidation.Results;
using MediatR;
using SimpleCrudBackEndNetCore.Application.Contracts;
using SimpleCrudBackEndNetCore.Application.Extensions;
using SimpleCrudBackEndNetCore.Crosscutting.AbstractClasses;
using SimpleCrudBackEndNetCore.Crosscutting.DataTransferObject.ReadModel;
using SimpleCrudBackEndNetCore.Crosscutting.DataTransferObject.WriteModel;
using SimpleCrudBackEndNetCore.Crosscutting.models;
using SimpleCrudBackEndNetCore.Domain.Commands;
using SimpleCrudBackEndNetCore.Domain.Contracts.Repositories;

namespace SimpleCrudBackEndNetCore.Application.Implementations
{
    public class PersonApplicationService : ApplicationServiceBase, IPersonApplicationService
    {
        private readonly IMediator _mediator;
        private readonly IPersonDapperRespository _personDapperRespository; 

        public PersonApplicationService(
            IMediator mediator,
            IPersonDapperRespository personDapperRespository) 
        {
            _mediator = mediator;
            _personDapperRespository = personDapperRespository;
        }

        public async Task<ValidationResult> CreatePerson(CreatePersonDTO dto)  
        {
            return await _mediator.Send(new CreatePersonCommand(
                dto.Name,
                dto.LastName,
                dto.Email,
                dto.PhoneNumber,
                dto.Nationality,
                dto.ZoneInformationPostalCode,
                dto.BrazilianUfId,
                dto.City,
                dto.PublicPlace));
        }

        public async Task<ValidationResult> UpdatePerson(UpdatePersonDTO dto)   
        {
            return await _mediator.Send(new UpdatePersonCommand(
                dto.Id,
                dto.Name,
                dto.LastName,
                dto.Email,
                dto.PhoneNumber,
                dto.Nationality,
                dto.ZoneInformationPostalCode,
                dto.BrazilianUfId,
                dto.City,
                dto.PublicPlace));
        }

        public async Task<ValidationResult> DeletePerson(Guid id)  
        {
            return await _mediator.Send(new DeletePersonCommand(id));  
        }

        public async Task<GridDTO<PersonReadDTO>> GetAllPersons(int pageIndex, int pageSize, string term) 
        {
            return new()
            {
                Itens = (await _personDapperRespository.GetAllPersons(pageIndex, pageSize, term)).ConvertToDTO(),
                Count = await _personDapperRespository.GetCountAllPersons(term)
            };
        }

        public async Task<PersonReadDTO> GetPersonById(Guid PersonId)  
        {
            return (await _personDapperRespository.GetById(PersonId)).ConvertToDTO();
        }
    }
}
