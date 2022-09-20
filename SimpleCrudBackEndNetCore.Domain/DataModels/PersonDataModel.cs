namespace SimpleCrudBackEndNetCore.Domain.DataModels
{
    public class PersonDataModel
    {
        public Guid Id { get; set; }
        public string Name { get; private set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string ZoneInformationPostalCode { get; set; }
        public string City { get; set; }
        public string PublicPlace { get; set; }
        public Guid BrazilianUfId { get; set; }
    }
}
