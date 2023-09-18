using Rabbit.ShortGuid;

namespace Rabbit.XGuidTests
{
    [TestClass]
    public class Guid32Tests
    {
        [TestMethod]
        public void CanParseWithHyphens()
        {
            var guid = Guid.NewGuid().ToString();

            var guid32 = Guid32.Parse(guid);

            Assert.AreEqual(guid.Replace("-", string.Empty), guid32.ToString());
        }

        [TestMethod]
        public void CanParseWithoutHyphens()
        {
            var guid = Guid.NewGuid().ToString().Replace("-", string.Empty);

            var guid32 = Guid32.Parse(guid);

            Assert.AreEqual(guid, guid32.ToString());
        }
    }
}