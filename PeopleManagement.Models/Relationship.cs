using PeopleManagement.Constants;

namespace PeopleManagement.Models
{
    public class Relationship : BaseModel
    {
        public Person Owner { get; }
        public Person Related { get; }
        public RelationshipType Type { get; }

        public Relationship(Person owner, Person related, RelationshipType type)
        {
            Owner = owner;
            Related = related;
            Type = type;
        }
    }
}