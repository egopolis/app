using Xunit;

namespace Epg.Quest.Banks
{
    /// <summary>
    /// TODO:0
    /// </summary>
    public class BankCreditSpec
    {
        private readonly IQuest _quest;

        public BankCreditSpec()
        {
            _quest = new QuestEntity
            {
                Id = "552176b2-bdc6-4962-96e6-98555d3b3f75",
                Description = "Defeat The Bank credit"
            };
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
