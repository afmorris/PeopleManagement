using System;
using Newtonsoft.Json;
using PeopleManagement.Constants.SerializationConverters;

namespace PeopleManagement.Constants
{
    [JsonConverter(typeof(RelationshipTypeSerializationConverter))]
    public class RelationshipType : IEquatable<RelationshipType>, IEquatable<string>
    {
        private readonly string relationshipType;

        internal RelationshipType(string relationshipType) => this.relationshipType = relationshipType;

        public static RelationshipType Acquaintance = new RelationshipType(nameof(Acquaintance));
        public static RelationshipType Child = new RelationshipType(nameof(Child));
        public static RelationshipType Fiancé = new RelationshipType(nameof(Fiancé));
        public static RelationshipType Fiancée = new RelationshipType(nameof(Fiancée));
        public static RelationshipType Grandchild = new RelationshipType(nameof(Grandchild));
        public static RelationshipType Grandparent = new RelationshipType(nameof(Grandparent));
        public static RelationshipType Parent = new RelationshipType(nameof(Parent));
        public static RelationshipType Partner = new RelationshipType(nameof(Partner));
        public static RelationshipType Sibling = new RelationshipType(nameof(Sibling));
        public static RelationshipType Spouse = new RelationshipType(nameof(Spouse));

        public override string ToString() => relationshipType;

        public bool Equals(RelationshipType other) => !(other is null) && (ReferenceEquals(this, other) || string.Equals(relationshipType, other.relationshipType));

        public bool Equals(string other) => !(other is null) && (ReferenceEquals(relationshipType, other) || string.Equals(relationshipType, other));

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case RelationshipType rt:
                    return rt.ToString() == relationshipType;
                case string s:
                    return s == relationshipType;
                default:
                    return false;
            }
        }
        
        public static bool operator ==(RelationshipType relationshipType1, RelationshipType relationshipType2) => relationshipType1?.Equals(relationshipType2) ?? relationshipType2 is null;

        public static bool operator !=(RelationshipType relationshipType1, RelationshipType relationshipType2) => !relationshipType1?.Equals(relationshipType2) ?? !(relationshipType2 is null);

        public static bool operator ==(RelationshipType relationshipType1, string relationshipType2) => relationshipType1?.Equals(relationshipType2) ?? relationshipType2 is null;

        public static bool operator !=(RelationshipType relationshipType1, string relationshipType2) => !relationshipType1?.Equals(relationshipType2) ?? !(relationshipType2 is null);

        public override int GetHashCode() => relationshipType != null ? relationshipType.GetHashCode() : 0;
    }
}