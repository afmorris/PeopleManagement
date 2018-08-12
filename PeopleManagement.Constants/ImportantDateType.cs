namespace PeopleManagement.Constants
{
    public class ImportantDateType
    {
        private readonly string importantDateType;

        internal ImportantDateType(string importantDateType) => this.importantDateType = importantDateType;

        public static ImportantDateType Birthday = new ImportantDateType(nameof(Birthday));
        public static ImportantDateType Engagement = new ImportantDateType(nameof(Engagement));
        public static ImportantDateType Graduation = new ImportantDateType(nameof(Graduation));
        public static ImportantDateType Marriage = new ImportantDateType(nameof(Marriage));

        public override string ToString() => importantDateType;

        public bool Equals(ImportantDateType other) => !(other is null) && (ReferenceEquals(this, other) || string.Equals(importantDateType, other.importantDateType));

        public bool Equals(string other) => !(other is null) && (ReferenceEquals(importantDateType, other) || string.Equals(importantDateType, other));

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case ImportantDateType rt:
                    return rt.ToString() == importantDateType;
                case string s:
                    return s == importantDateType;
                default:
                    return false;
            }
        }

        public static bool operator ==(ImportantDateType importantDateType1, ImportantDateType importantDateType2) => importantDateType1?.Equals(importantDateType2) ?? importantDateType2 is null;

        public static bool operator !=(ImportantDateType importantDateType1, ImportantDateType importantDateType2) => !importantDateType1?.Equals(importantDateType2) ?? !(importantDateType2 is null);

        public static bool operator ==(ImportantDateType importantDateType1, string importantDateType2) => importantDateType1?.Equals(importantDateType2) ?? importantDateType2 is null;

        public static bool operator !=(ImportantDateType importantDateType1, string importantDateType2) => !importantDateType1?.Equals(importantDateType2) ?? !(importantDateType2 is null);

        public override int GetHashCode() => importantDateType != null ? importantDateType.GetHashCode() : 0;
    }
}