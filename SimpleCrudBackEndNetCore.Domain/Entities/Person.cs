using SimpleCrudBackEndNetCore.Domain.Core.Models;
using SimpleCrudBackEndNetCore.Domain.Entities.Validations;
using SimpleCrudBackEndNetCore.Domain.ValueObjects;

namespace SimpleCrudBackEndNetCore.Domain.Entities
{
    public class Person : AuditEntity
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }        
        public string PhoneNumber { get; private set; }

        public virtual Address Address { get; private set; } 

        public override bool IsValid()
        {
            ValidationResult = new PersonValidation().Validate(this);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Constructor without parameters to EF.
        /// </summary>
        private Person( ) { }

        /// <summary>
        /// Object instance.
        /// </summary>
        public Person(
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
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            CreatedDate = DateTime.Now;
            Address = new Address(
                nationality,
                zoneInformationPostalCode,
                brazilianUfId,
                city, 
                publicPlace);
        }

        public void Update(
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
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            ModifiedDate = DateTime.Now;
            Address = new Address(
                nationality,
                zoneInformationPostalCode,
                brazilianUfId,
                city,
                publicPlace); 
        }
    }
}
