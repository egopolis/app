using Xunit;

namespace Epg.World
{
    public class WorldStorageSpecs
    {
        [Fact]
        public void Add_WithSameName_ThrowDuplicateException()
        {
            Assert.True(false);
        }

        [Fact]
        public void Get_MissingName_ThrowNotExistsException()
        {
            Assert.True(false);
        }
    }
}
