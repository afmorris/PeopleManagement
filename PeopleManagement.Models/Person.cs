using System.Collections.Generic;
using PeopleManagement.Constants;

namespace PeopleManagement.Models
{
    public class Person : BaseModel
    {
        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }
        public Gender Gender { get; }
        public List<ImportantDate> ImportantDates { get; }
        public List<Relationship> Relationships { get; }

        public Person(string firstName, string middleName, string lastName, Gender gender, List<ImportantDate> importantDates, List<Relationship> relationships)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Gender = gender;
            ImportantDates = importantDates;
            Relationships = relationships;
        }
    }
}