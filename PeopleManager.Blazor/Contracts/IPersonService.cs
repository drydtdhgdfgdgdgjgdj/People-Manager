using PeopleManager.Blazor.Model;

namespace PeopleManager.Blazor.Contracts
{
    public interface IPersonService
    {
        public IList<Person> Find();
        public Person? Get(int id);
    }
}
