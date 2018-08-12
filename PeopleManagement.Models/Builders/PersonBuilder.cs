using System.Collections.Generic;
using PeopleManagement.Constants;

namespace PeopleManagement.Models.Builders
{
    public sealed class PersonBuilder
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private Gender gender = Gender.Unspecified;
        private List<ImportantDate> importantDates = new List<ImportantDate>();
        private List<Relationship> relationships = new List<Relationship>();

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

        public PersonBuilder UseGender(Gender gender)
        {
            this.gender = gender;
            return this;
        }

        public PersonBuilder UseImportantDates(List<ImportantDate> importantDates)
        {
            this.importantDates = importantDates;
            return this;
        }

        public PersonBuilder UseRelationships(List<Relationship> relationships)
        {
            this.relationships = relationships;
            return this;
        }

        public Person Build()
        {
            return new Person(firstName, middleName, lastName, gender, importantDates, relationships);
        }
    }
}