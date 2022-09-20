namespace SimpleCrudBackEndNetCore.Crosscutting.DataTransferObject.WriteModel 
{
    public class CreatePersonDTO 
    {
        public string Name { get; set; }
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
