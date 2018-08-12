using PeopleManagement.Constants;

namespace PeopleManagement.Models
{
    public class Person : BaseModel
    {
        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }
        public Gender Gender { get; }

        public Person(string firstName, string middleName, string lastName, Gender gender)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Gender = gender;
        }
    }
}