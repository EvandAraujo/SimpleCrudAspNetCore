using FluentValidation.Results;
using SimpleCrudBackEndNetCore.Crosscutting.DataTransferObject.ReadModel;
using SimpleCrudBackEndNetCore.Crosscutting.DataTransferObject.WriteModel;
using SimpleCrudBackEndNetCore.Crosscutting.models;

namespace SimpleCrudBackEndNetCore.Application.Contracts
{
    public interface IPersonApplicationService
    {
        Task<ValidationResult> CreatePerson(CreatePersonDTO dto);
        Task<ValidationResult> UpdatePerson(UpdatePersonDTO dto); 
        Task<ValidationResult> DeletePerson(Guid id);
        Task<GridDTO<PersonReadDTO>> GetAllPersons(int pageIndex, int pageSize, string term);
        Task<PersonReadDTO> GetPersonById(Guid PersonId);  
    }
}
