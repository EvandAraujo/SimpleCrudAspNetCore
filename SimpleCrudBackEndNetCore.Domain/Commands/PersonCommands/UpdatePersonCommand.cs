using SimpleCrudBackEndNetCore.Domain.Commands.PersonCommands.Validations;
using SimpleCrudBackEndNetCore.Domain.Core.Models;

namespace SimpleCrudBackEndNetCore.Domain.Commands
{
    public class UpdatePersonCommand : Command 
    {
        public UpdatePersonCommand(
            Guid id,
            string name,
            string lastName,
            string email,
            string phoneNumber,
            string nationality,
            string zoneInformationPostalCode,
            Guid brazilianUfId,
            string city,
            string publicPlace) 
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Nationality = nationality;
            ZoneInformationPostalCode = zoneInformationPostalCode;
            BrazilianUfId = brazilianUfId;
            City = city;
            PublicPlace = publicPlace;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Nationality { get; private set; }
        public string ZoneInformationPostalCode { get; private set; }
        public string City { get; private set; }
        public string PublicPlace { get; private set; }
        public Guid BrazilianUfId { get; private set; }

        public override bool IsValid()
        {
            ValidationResult = new UpdatePersonCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
