using Rabbit.ShortGuid;

namespace Rabbit.XGuidTests
{
    [TestClass]
    public class GuidXTests
    {
        [TestMethod]
        public void CanGetValue()
        {
            var guid = new GuidX(Guid.NewGuid());

            var value = guid.Value;
        }

        [TestMethod]
        public void CanParseFromString()
        {
            var guid = Guid.Parse("b80deec0-a636-4af7-a10a-2f2251e30d4e");

            var guidCustom = new GuidX(guid);
            var guidCustomStr = guidCustom.ToString();

            var guidCustomParsed = GuidX.Parse(guidCustomStr);

            Assert.AreEqual(guidCustomStr, guidCustomParsed.Value);
        }
    }
}