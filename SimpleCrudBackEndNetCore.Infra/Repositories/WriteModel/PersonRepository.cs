using SimpleCrudBackEndNetCore.Domain.Contracts.Repositories;
using SimpleCrudBackEndNetCore.Domain.Entities;
using SimpleCrudBackEndNetCore.Infra.Context;

namespace SimpleCrudBackEndNetCore.Infra.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(MicroServiceContext context) : base(context) 
        {
        }
    }
}
