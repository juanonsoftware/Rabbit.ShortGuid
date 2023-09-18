using Rabbit.ShortGuid;

namespace Rabbit.XGuidTests
{
    [TestClass]
    public class GuidBase62Tests
    {
        [TestMethod]
        public void CanGetValue()
        {
            var guid = new GuidBase62(Guid.NewGuid());

            Assert.IsNotNull(guid.Value);
        }
    }
}