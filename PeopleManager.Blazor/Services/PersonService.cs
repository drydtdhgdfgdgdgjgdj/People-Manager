using PeopleManager.Blazor.Contracts;
using PeopleManager.Blazor.Model;

namespace PeopleManager.Blazor.Services
{
    public class PersonService : IPersonService
    {
        public IList<Person> Find()
        {
            return GetInternalPeople();
        }

        public Person? Get(int id)
        {
            var people = GetInternalPeople();
            return people.FirstOrDefault(p => p.Id == id);
        }

        private IList<Person> GetInternalPeople()
        {
            return new List<Person>
            {
                new Person { Id=1, FirstName = "Emma", LastName = "Peeters", Email = "emma.peeters@example.com" },
                new Person { Id=2, FirstName = "Lucas", LastName = "Janssens", Email = "lucas.janssens@example.com" },
                new Person { Id=3, FirstName = "Olivia", LastName = "Maes", Email = "olivia.maes@example.com" },
                new Person { Id=4, FirstName = "Noah", LastName = "Jacobs", Email = "noah.jacobs@example.com" },
                new Person { Id=5, FirstName = "Mila", LastName = "Mertens", Email = "mila.mertens@example.com" },
                new Person { Id=6, FirstName = "Liam", LastName = "Willems", Email = "liam.willems@example.com" },
                new Person { Id=7, FirstName = "Louise", LastName = "Claes", Email = "louise.claes@example.com" },
                new Person { Id=8, FirstName = "Arthur", LastName = "Goossens", Email = "arthur.goossens@example.com" },
                new Person { Id=9, FirstName = "Alice", LastName = "Wouters", Email = "alice.wouters@example.com" },
                new Person { Id=10, FirstName = "Louis", LastName = "De Smet", Email = "louis.desmet@example.com" },
                new Person { Id=11, FirstName = "Anna", LastName = "Vermeulen", Email = "anna.vermeulen@example.com" },
                new Person { Id=12, FirstName = "Finn", LastName = "Pauwels", Email = "finn.pauwels@example.com" },
                new Person { Id=13, FirstName = "Nora", LastName = "Dubois", Email = "nora.dubois@example.com" },
                new Person { Id=14, FirstName = "Adam", LastName = "Hermans", Email = "adam.hermans@example.com" },
                new Person { Id=15, FirstName = "Lina", LastName = "Michiels", Email = "lina.michiels@example.com" },
                new Person { Id=16, FirstName = "Victor", LastName = "Van den Berg", Email = "victor.vandenberg@example.com" },
                new Person { Id=17, FirstName = "Elena", LastName = "Martens" },
                new Person { Id=18, FirstName = "Oscar", LastName = "Stevens" },
                new Person { Id=19, FirstName = "Sofia", LastName = "Coppens" },
                new Person { Id=20, FirstName = "Jules", LastName = "Dumont" }
            };
        }
    }
}
