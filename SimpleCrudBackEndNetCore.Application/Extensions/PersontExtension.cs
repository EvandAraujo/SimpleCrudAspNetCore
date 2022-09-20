using SimpleCrudBackEndNetCore.Crosscutting.DataTransferObject.ReadModel;
using SimpleCrudBackEndNetCore.Domain.DataModels;

namespace SimpleCrudBackEndNetCore.Application.Extensions
{
    public static class PersontExtension 
    {
        public static IEnumerable<PersonReadDTO> ConvertToDTO(this IEnumerable<PersonDataModel> entities)
        {
            return entities.Select(ConvertToDTO);
        }

        public static PersonReadDTO ConvertToDTO(this PersonDataModel entity)
        {
            return new PersonReadDTO
            {
                Id = entity.Id,
                Name = entity.Name,
                LastName = entity.LastName,
                Email = entity.Email,
                PhoneNumber = entity.PhoneNumber,
                Nationality = entity.Nationality,
                ZoneInformationPostalCode = entity.ZoneInformationPostalCode,
                BrazilianUfId = entity.BrazilianUfId,
                City = entity.City,
                PublicPlace = entity.PublicPlace
            };
        }
    }
}
