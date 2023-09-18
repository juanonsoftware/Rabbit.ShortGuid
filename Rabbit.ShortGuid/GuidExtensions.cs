using System;

namespace Rabbit.ShortGuid
{
    public static class GuidExtensions
    {
        /// <summary>
        /// Get 32 HEX characters of the Guid
        /// </summary>
        public static string ToGuid32Chars(this Guid guid)
        {
            return new Guid32(guid).ToString();
        }

        /// <summary>
        /// Get 26 lower alphanumberic characters of the Guid using GuidBase36 instance
        /// </summary>
        public static string ToGuid26Chars(this Guid guid)
        {
            return new GuidBase36(guid).ToString();
        }

        /// <summary>
        /// Get 22 alphanumberic and special characters of the Guid using GuidBase36 instance.
        /// This includes lower/upper/number/special characters.
        /// </summary>
        public static string ToGuid22Chars(this Guid guid)
        {
            return new GuidX(guid).ToString();
        }
    }
}
