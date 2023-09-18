using System;

namespace Rabbit.ShortGuid
{
    /// <summary>
    /// Extremely short presentation of Guid by using all alphanumeric characters plus some special characters
    /// </summary>
    public class GuidX : GuidBaseN
    {
        private static readonly string _dictionary = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789~!@$%*-_+:";

        public static readonly GuidX Empty = new GuidX(Guid.Empty);

        public GuidX(Guid guid) : base(guid)
        {
            Initialize(_dictionary);
        }

        /// <summary>
        /// Create a new GuidX instance
        /// </summary>
        public static GuidX NewGuid()
        {
            return new GuidX(Guid.NewGuid());
        }

        /// <summary>
        /// Parse GuidX instance from its string
        /// </summary>
        public static GuidX Parse(string guidStr)
        {
            return new GuidX(ParseFromBaseString(guidStr));
        }
    }
}
