using System;

namespace Rabbit.ShortGuid
{
    /// <summary>
    /// Guid representation based on 62 upper and lower alphanumeric characters
    /// </summary>
    public class GuidBase62 : GuidBaseN
    {
        private static readonly string _dictionary = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        /// <summary>
        /// Create a new instance
        /// </summary>
        public GuidBase62(Guid guid) : base(guid)
        {
            Initialize(_dictionary);
        }

        /// <summary>
        /// Generate a new Guid
        /// </summary>
        public static GuidBase62 NewGuid()
        {
            return new GuidBase62(Guid.NewGuid());
        }

        /// <summary>
        /// Parse from generated string
        /// </summary>
        public static GuidBase62 Parse(string guidStr)
        {
            return new GuidBase62(ParseFromBaseString(guidStr));
        }
    }
}
