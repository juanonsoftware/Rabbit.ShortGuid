using System;

namespace Rabbit.ShortGuid
{
    /// <summary>
    /// Guid representation based on 36 alphanumeric characters
    /// </summary>
    public class GuidBase36 : GuidBaseN
    {
        private static readonly string _dictionary = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        /// <summary>
        /// Create new instance
        /// </summary>
        public GuidBase36(Guid guid) : base(guid)
        {
            Initialize(_dictionary);
        }

        /// <summary>
        /// Generate a new Guid
        /// </summary>
        public static GuidBase36 NewGuid()
        {
            return new GuidBase36(Guid.NewGuid());
        }

        /// <summary>
        /// Parse a string to Guid36
        /// </summary>
        public static GuidBase36 Parse(string guidStr)
        {
            return new GuidBase36(ParseFromBaseString(guidStr));
        }
    }
}
