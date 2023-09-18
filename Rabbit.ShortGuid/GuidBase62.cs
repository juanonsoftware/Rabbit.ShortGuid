using System;

namespace Rabbit.ShortGuid
{
    public class GuidBase62 : GuidBaseN
    {
        private static readonly string _dictionary = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public static readonly GuidBase62 Empty = new GuidBase62(Guid.Empty);

        public GuidBase62(Guid guid) : base(guid)
        {
            Initialize(_dictionary);
        }

        public static GuidBase62 NewGuid()
        {
            return new GuidBase62(Guid.NewGuid());
        }

        public static GuidBase62 Parse(string guidStr)
        {
            return new GuidBase62(ParseFromBaseString(guidStr));
        }
    }
}
