using PeopleManagement.Constants;

namespace PeopleManagement.Models.Builders
{
    public sealed class PersonBuilder
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private Gender gender;

        public static PersonBuilder Default()
        {
            return new PersonBuilder();
        }

        public PersonBuilder UseFirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public PersonBuilder UseMiddleName(string middleName)
        {
            this.middleName = middleName;
            return this;
        }

        public PersonBuilder UseLastName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }

        public PersonBuilder Gender(Gender gender)
        {
            this.gender = gender;
            return this;
        }

        public Person Build()
        {
            return new Person(firstName, middleName, lastName, gender);
        }
    }
}