using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Rabbit.ShortGuid
{
    public abstract class GuidBaseN
    {
        private static string _dictionary = string.Empty;

        private readonly Guid _guid;
        private string _value;

        public GuidBaseN(Guid guid)
        {
            _guid = guid;
        }

        public string Value
        {
            get
            {
                if (string.IsNullOrEmpty(_value))
                {
                    _value = ConvertToBaseString(_guid);
                }
                return _value;
            }
        }

        public override string ToString()
        {
            return Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        protected static Guid ParseFromBaseString(string guidStr)
        {
            int baseN = _dictionary.Length;
            int count = guidStr.Length;
            BigInteger number = 0;

            for (int i = 0; i < count; i++)
            {
                number = number * baseN + (BigInteger)_dictionary.IndexOf(guidStr.ElementAt(i));
            }

            return new Guid(number.ToByteArray());
        }

        protected static void Initialize(string dictionary)
        {
            _dictionary = dictionary;
        }

        protected static string ConvertToBaseString(Guid guid)
        {
            int baseN = _dictionary.Length;
            var number = new BigInteger(guid.ToByteArray());
            var sb = new StringBuilder();

            while (number != 0)
            {
                BigInteger remainder;
                number = BigInteger.DivRem(number, baseN, out remainder);
                sb.Insert(0, _dictionary.ElementAt(Math.Abs((int)remainder)));
            }

            return sb.ToString();
        }
    }
}
