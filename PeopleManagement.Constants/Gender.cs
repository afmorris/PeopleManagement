using System;

namespace PeopleManagement.Constants
{
    public class Gender : IEquatable<Gender>, IEquatable<string>
    {
        private readonly string gender;

        internal Gender(string gender) => this.gender = gender;

        public static Gender Female = new Gender(nameof(Female));
        public static Gender Male = new Gender(nameof(Male));
        public static Gender Unspecified = new Gender(nameof(Unspecified));

        public override string ToString() => gender;

        public bool Equals(Gender other) => !(other is null) && (ReferenceEquals(this, other) || string.Equals(gender, other.gender));

        public bool Equals(string other) => !(other is null) && (ReferenceEquals(gender, other) || string.Equals(gender, other));

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case Gender g:
                    return g.ToString() == gender;
                case string s:
                    return s == gender;
                default:
                    return false;
            }
        }

        public static bool operator ==(Gender gender1, Gender gender2) => gender1?.Equals(gender2) ?? gender2 is null;

        public static bool operator !=(Gender gender1, Gender gender2) => !gender1?.Equals(gender2) ?? !(gender2 is null);

        public static bool operator ==(Gender gender1, string gender2) => gender1?.Equals(gender2) ?? gender2 is null;

        public static bool operator !=(Gender gender1, string gender2) => !gender1?.Equals(gender2) ?? !(gender2 is null);

        public override int GetHashCode() => gender != null ? gender.GetHashCode() : 0;
    }
}