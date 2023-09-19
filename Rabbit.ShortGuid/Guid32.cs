using System;
using System.Text;

namespace Rabbit.ShortGuid
{
    /// <summary>
    /// A 32 characters representation of 36 characters on original Guid by removing 4 hyphens.
    /// </summary>
    public struct Guid32
    {
        private readonly string _value;

        /// <summary>
        /// Create new instance based on an existing Guid
        /// </summary>
        /// <param name="guid">The existing GUID</param>
        public Guid32(Guid guid)
        {
            _value = guid.ToString().Replace("-", string.Empty);
        }

        /// <summary>
        /// Parse a string to Guid32
        /// </summary>
        /// <param name="guid">Guid string with or without hyphens</param>
        /// <returns>Guid32 instance</returns>
        public static Guid32 Parse(string guid)
        {
            string guidStr;

            if (guid.Contains("-"))
            {
                guidStr = guid;
            }
            else
            {
                guidStr = new StringBuilder(guid).Insert(20, "-").Insert(16, "-").Insert(12, "-").Insert(8, "-").ToString();
            }

            return new Guid32(Guid.Parse(guidStr));
        }

        /// <summary>
        /// Creates a new Guid32
        /// </summary>
        /// <returns>Guid32 instance</returns>
        public static Guid32 NewGuid()
        {
            return new Guid32(Guid.NewGuid());
        }

        /// <summary>
        /// To 32 characters of the Guid (remove hyphens)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _value;
        }

        /// <summary>
        /// Return the hash code from 32 characters
        /// </summary>
        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
    }
}
