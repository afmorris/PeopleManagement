using PeopleManagement.Data.Interfaces;

namespace PeopleManagement.Data
{
    public class PersonRepository : IPersonRepository
    {
        private string connectionString;

        public PersonRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}