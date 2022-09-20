using SimpleCrudBackEndNetCore.Domain.Commands.PersonCommands.Validations;
using SimpleCrudBackEndNetCore.Domain.Core.Models;

namespace SimpleCrudBackEndNetCore.Domain.Commands
{
    public class CreatePersonCommand : Command
    {
        public CreatePersonCommand(string name,
            string lastName,
            string email,
            string phoneNumber,
            string nationality,
            string zoneInformationPostalCode,
            Guid brazilianUfId,
            string city,
            string publicPlace) 
        {
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
            ValidationResult = new CreatePersonCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
