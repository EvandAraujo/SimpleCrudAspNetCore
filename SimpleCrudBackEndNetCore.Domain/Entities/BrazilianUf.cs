using SimpleCrudBackEndNetCore.Domain.Core.Models;

namespace SimpleCrudBackEndNetCore.Domain.Entities
{
    public class BrazilianUf : Entity
    {
        public string Name { get; private set; }
        public string Uf { get; private set; }
        public int UfCode { get; private set; }
        public string Country { get; private set; }

        /// <summary>
        /// Constructor without parameters to EF.
        /// </summary>
        private BrazilianUf( ) { }

        /// <summary>
        /// Object instance.
        /// </summary>
        public BrazilianUf(Guid id, int ufCode, string name, string uf, string country)
        {
            Id = id;
            UfCode = ufCode;
            Name = name;
            Uf = uf;
            Country = country;
        }
    }
}
