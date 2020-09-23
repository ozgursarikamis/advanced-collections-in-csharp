using System;

namespace TourBooker.Logic
{
    public class CountryCode
    {
        public string Value { get; }

        public CountryCode(string value)
        {
            Value = value;
        }

        public override string ToString() => Value;
        public override bool Equals(object obj)
        {
            if (obj is CountryCode other)
            {
                return StringComparer.OrdinalIgnoreCase.Equals(Value, other.Value);
            }

            return false;
        }

        protected bool Equals(CountryCode other)
        {
            return Value == other.Value;
        }

        public override int GetHashCode()
        {
            return Value != null ? Value.GetHashCode() : 0;
        }

        public static bool operator ==(CountryCode left, CountryCode right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CountryCode left, CountryCode right)
        {
            return !Equals(left, right);
        }
    }
}