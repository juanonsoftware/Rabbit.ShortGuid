using System;

namespace Rabbit.ShortGuid
{
    public class GuidBase36 : GuidBaseN
    {
        private static readonly string _dictionary = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static readonly GuidBase36 Empty = new GuidBase36(Guid.Empty);

        public GuidBase36(Guid guid) : base(guid)
        {
            Initialize(_dictionary);
        }

        public static GuidBase36 NewGuid()
        {
            return new GuidBase36(Guid.NewGuid());
        }

        public static GuidBase36 Parse(string guidStr)
        {
            return new GuidBase36(ParseFromBaseString(guidStr));
        }
    }
}
