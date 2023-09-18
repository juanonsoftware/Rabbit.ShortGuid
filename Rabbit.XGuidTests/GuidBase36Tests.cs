using Rabbit.ShortGuid;

namespace Rabbit.XGuidTests
{
    [TestClass]
    public class GuidBase36Tests
    {
        [TestMethod]
        public void CanGetValue()
        {
            var guid = new GuidBase36(Guid.NewGuid());

            Assert.IsNotNull(guid.Value);
        }
    }
}