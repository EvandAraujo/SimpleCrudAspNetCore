using SimpleCrudBackEndNetCore.Domain.DataModels;

namespace SimpleCrudBackEndNetCore.Domain.Contracts.Repositories
{
    public interface IPersonDapperRespository
    {
        Task<IEnumerable<PersonDataModel>> GetAllPersons(int pageIndex, int pageSize, string term);
        Task<int> GetCountAllPersons(string term);
        Task<PersonDataModel> GetById(Guid PersonId);
    }
}
