using Dapper;
using SimpleCrudBackEndNetCore.Domain.Contracts.Repositories;
using SimpleCrudBackEndNetCore.Domain.DataModels;
using System.Data;
using System.Xml.Linq;

namespace SimpleCrudBackEndNetCore.Infra.Repositories
{
    public class PersonDapperRespository : IPersonDapperRespository
    {
        private readonly IDbConnection _connection;

        public PersonDapperRespository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<PersonDataModel>> GetAllPersons(int pageIndex, int pageSize, string term) 
        {
            string where = "";
            if (term != null)
                where = $@"WHERE[p].[Name] LIKE '%{term}%'";

            string sql = $@"SELECT [p].Id, 
                                  [p].Name, 
                                  [p].LastName, 
                                  [p].Email, 
                                  [p].PhoneNumber,
                                  [p].Nationality,
                                  [p].ZoneInformationPostalCode,
                                  [p].City,
                                  [p].PublicPlace,
                                  [p].BrazilianUfId
                            FROM [dbo].Person [p]
                            {where}
                            ORDER BY [p].Name 
                            OFFSET @PageIndex ROWS FETCH NEXT @PageSize ROWS ONLY"; 
            return await _connection.QueryAsync<PersonDataModel>(sql, new { PageIndex = pageIndex, PageSize = pageSize, Term = term });
        }

        public async Task<int> GetCountAllPersons(string term) 
        {
            string where = "";
            if (term != null)
                where = $@"WHERE[p].[Name] LIKE '%{term}%'";

            string sql = $@"SELECT Count(*)
                            FROM [dbo].Person [p]
                            {where}";
            return (await _connection.QueryAsync<int>(sql)).FirstOrDefault();
        }

        public async Task<PersonDataModel> GetById(Guid PersonId)   
        {
            string sql = @"SELECT 
                            [p].Id,
                            [p].Name,
                            [p].LastName, 
                            [p].Email, 
                            [p].PhoneNumber,
                            [p].Nationality,
                            [p].ZoneInformationPostalCode,
                            [p].City,
                            [p].PublicPlace,
                            [p].BrazilianUfId
                           FROM [dbo].Person [p]
                           WHERE [p].Id = @Id";
            IEnumerable<PersonDataModel> persons = await _connection.QueryAsync<PersonDataModel>(sql, new { Id = PersonId });
            return persons.FirstOrDefault();
        }
    }
}
