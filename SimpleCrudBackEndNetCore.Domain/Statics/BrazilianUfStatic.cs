using SimpleCrudBackEndNetCore.Domain.Entities;

namespace SimpleCrudBackEndNetCore.Domain.Statics
{
    public class BrazilianUfStatic
    {
        /// <summary>
        /// Object instance.
        /// </summary>
        public BrazilianUfStatic(Guid ufId, int ufCode, string ufName, string uf, string country)
        {
            Id = ufId;
            UfCode = ufCode;
            UfName = ufName;
            Uf = uf;
            Country = country;
        }

        public Guid Id { get; private set; }
        public int UfCode { get; private set; }
        public string UfName { get; private set; }
        public string Uf { get; private set; }
        public string Country { get; private set; }

        public static BrazilianUfStatic Rondonia { get; } = new(Guid.Parse("156c834a-7300-4c7b-8a45-a87df774f900"), 11, "Rondônia", "RO", "BR");
        public static BrazilianUfStatic Acre { get; } = new(Guid.Parse("9d9e728f-02bd-4260-95a5-8df655d434d0"), 12, "Acre", "AC", "BR");
        public static BrazilianUfStatic Amazonas { get; } = new(Guid.Parse("085f7465-387a-42d5-a4b5-82e5be81ca7c"), 13, "Amazonas", "AM", "BR");
        public static BrazilianUfStatic Roraima { get; } = new(Guid.Parse("5192f341-c245-43ed-9567-1ef291d53485"), 14, "Roraima", "RR", "BR");
        public static BrazilianUfStatic Para { get; } = new(Guid.Parse("1207c116-bf8c-41b2-9cfa-b28c42371ff3"), 15, "Pará", "PA", "BR");
        public static BrazilianUfStatic Amapa { get; } = new(Guid.Parse("790e3c57-596d-46db-98fc-0eb1fbd16516"), 16, "Amapá", "AP", "BR");
        public static BrazilianUfStatic Tocantins { get; } = new(Guid.Parse("e0ff5f07-eec9-4161-9657-5c38dd230dd3"), 17, "Tocantins", "TO", "BR");
        public static BrazilianUfStatic Maranhao { get; } = new(Guid.Parse("425b7437-cf6b-44e3-b708-c0fc869998d6"), 21, "Maranhão", "MA", "BR");
        public static BrazilianUfStatic Piaui { get; } = new(Guid.Parse("02b4f971-6c52-4d7c-a438-9914c3c6a89b"), 22, "Piauí", "PI", "BR");
        public static BrazilianUfStatic Ceara { get; } = new(Guid.Parse("4d46948c-c8d6-408b-847a-c98957a3df9f"), 23, "Ceará", "CE", "BR");
        public static BrazilianUfStatic RioGrandeDoNorte { get; } = new(Guid.Parse("6657eaf7-78f1-4f74-85e1-0944594adb22"), 24, "Rio Grande do Norte", "RN", "BR");
        public static BrazilianUfStatic Paraiba { get; } = new(Guid.Parse("276ad231-4150-4bca-9c6d-ff1181746e85"), 25, "Paraíba", "PB", "BR");
        public static BrazilianUfStatic Pernambuco { get; } = new(Guid.Parse("2a3c6bf7-4044-445f-8a24-8b938d66c437"), 26, "Pernambuco", "PE", "BR");
        public static BrazilianUfStatic Alagoas { get; } = new(Guid.Parse("cd8c355e-992b-4d84-bbd9-87e388294772"), 27, "Alagoas", "AL", "BR");
        public static BrazilianUfStatic Sergipe { get; } = new(Guid.Parse("e6dc1a76-56ff-4462-a5d5-6b8c5eac2d5c"), 28, "Sergipe", "SE", "BR");
        public static BrazilianUfStatic Bahia { get; } = new(Guid.Parse("217c3406-b20a-4224-a243-94549accfbe3"), 29, "Bahia", "BA", "BR");
        public static BrazilianUfStatic MinasGerais { get; } = new(Guid.Parse("b53b6ae9-87d8-4d9f-94fc-a7e01ca1b6ae"), 31, "Minas Gerais", "MG", "BR");
        public static BrazilianUfStatic EspiritoSanto { get; } = new(Guid.Parse("e8eeba35-7581-4b54-9ee6-6fabd7a5dfb1"), 32, "Espírito Santo", "ES", "BR");
        public static BrazilianUfStatic RioDeJaneiro { get; } = new(Guid.Parse("c69ed4b3-54c0-456c-a2e0-56b1300120c4"), 33, "Rio de Janeiro", "RJ", "BR");
        public static BrazilianUfStatic SaoPaulo { get; } = new(Guid.Parse("52a9afdb-ee0f-4008-875a-45bdb99ca7b0"), 35, "São Paulo", "SP", "BR");
        public static BrazilianUfStatic Parana { get; } = new(Guid.Parse("5cdc9548-9638-4b10-ab85-4e0058920110"), 41, "Paraná", "PR", "BR");
        public static BrazilianUfStatic SantaCatarina { get; } = new(Guid.Parse("a073ffd3-36f0-410b-96de-c26e838e5249"), 42, "Santa Catarina", "SC", "BR");
        public static BrazilianUfStatic RioGrandeDoSul { get; } = new(Guid.Parse("6c92b0ef-9567-4d54-b0cc-02b7e041d53c"), 43, "Rio Grande do Sul", "RS", "BR");
        public static BrazilianUfStatic MatoGrossoDoSul { get; } = new(Guid.Parse("cd0c5d23-d0cd-4663-a829-79e98a0aa5e0"), 50, "Mato Grosso do Sul", "MS", "BR");
        public static BrazilianUfStatic MatoGrosso { get; } = new(Guid.Parse("a7b033f0-6376-4c05-8438-899e87b2b71e"), 51, "Mato Grosso", "MT", "BR");
        public static BrazilianUfStatic Goias { get; } = new(Guid.Parse("0679caf3-a9f4-4ab5-9872-a74aa69ab97d"), 52, "Goiás", "GO", "BR");
        public static BrazilianUfStatic DistritoFederal { get; } = new(Guid.Parse("e40c2b75-93ef-47e4-9b9d-ff302d2f04d6"), 53, "Distrito Federal", "DF", "BR");


        public static List<BrazilianUfStatic> GetAll { get; } = new List<BrazilianUfStatic>()
        {
            Rondonia,
            Acre,
            Amazonas,
            Roraima,
            Para,
            Amapa,
            Tocantins,
            Maranhao,
            Piaui,
            Ceara,
            RioGrandeDoNorte,
            Paraiba,
            Pernambuco,
            Alagoas,
            Sergipe,
            Bahia,
            MinasGerais,
            EspiritoSanto,
            RioDeJaneiro,
            SaoPaulo,
            Parana,
            SantaCatarina,
            RioGrandeDoSul ,
            MatoGrossoDoSul,
            MatoGrosso,
            Goias,
            DistritoFederal
        };

        public static BrazilianUfStatic? GetById(Guid id)
        {
            return GetAll.FirstOrDefault(x => x.Id == id);
        }

        public static BrazilianUf[] DataArray()
        {
            return GetAll.Select(x => new BrazilianUf(x.Id, x.UfCode, x.UfName, x.Uf, x.Country)).ToArray();
        }
    }
}
