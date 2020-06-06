namespace Epg.Quest
{
    public class QuestEntity
        : IQuest
    {
        /// <summary>
        /// <see cref="IQuest.Description"/> implementation.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// <see cref="IQuest.Win"/> implementation.
        /// </summary>
        public string Win { get; set; }
    }
}
