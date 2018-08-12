using PeopleManagement.Constants;

namespace PeopleManagement.Models.Builders
{
    public class RelationshipBuilder
    {
        private Person owner;
        private Person related;
        private RelationshipType type;

        public static RelationshipBuilder Default()
        {
            return new RelationshipBuilder();
        }

        public RelationshipBuilder UseOwner(Person owner)
        {
            this.owner = owner;
            return this;
        }

        public RelationshipBuilder UseRelated(Person related)
        {
            this.related = related;
            return this;
        }

        public RelationshipBuilder UseType(RelationshipType type)
        {
            this.type = type;
            return this;
        }

        public Relationship Build()
        {
            return new Relationship(owner, related, type);
        }
    }
}