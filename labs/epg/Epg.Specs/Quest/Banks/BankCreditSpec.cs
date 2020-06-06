using Epg.World;
using Xunit;

namespace Epg.Quest.Banks
{
    /// <summary>
    /// TODO:0
    /// </summary>
    public class BankCreditSpec
    {
        private readonly SimpleWorldStorage _world;

        public BankCreditSpec()
        {
            _world = new SimpleWorldStorage();

            var questMain = _world.Quest("Defeat The Bank credit");
            var questPayInFull = _world.Quest("Pay credit in full", win: questMain);
            var questPayInSteps = _world.Quest("Pay credit step-by-step", win: questMain);
        }

        /// <summary>
        /// TODO:0
        /// </summary>
        [Fact]
        public void Foo()
        {
            Assert.True(false);
        }
    }
}
