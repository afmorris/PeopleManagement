using PeopleManagement.Constants;

namespace PeopleManagement.Models
{
    public class Relationship : BaseModel
    {
        public Person Owner { get; set; }
        public Person RelatedPerson { get; set; }
        public RelationshipType Type { get; set; }
    }
}