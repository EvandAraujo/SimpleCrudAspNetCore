using SimpleCrudBackEndNetCore.Domain.Entities;

namespace SimpleCrudBackEndNetCore.Domain.ValueObjects
{
    public class Address
    {
        public string Nationality { get; private set; }
        public string ZoneInformationPostalCode { get; private set; }
        public string City { get; private set; }
        public string PublicPlace { get; private set; }
        public Guid BrazilianUfId { get; private set; }
        public virtual BrazilianUf BrazilianUf { get; private set; }

        /// <summary>
        /// Constructor without parameters to EF.
        /// </summary>
        private Address() { }

        /// <summary>
        /// Object instance.
        /// </summary>
        public Address(
            string nationality,
            string zoneInformationPostalCode,
            Guid brazilianUfId, 
            string city,
            string publicPlace)  
        {
            Nationality = nationality;
            ZoneInformationPostalCode = zoneInformationPostalCode;
            BrazilianUfId = brazilianUfId;
            City = city;
            PublicPlace = publicPlace;
        } 
    }
}
