namespace Epg.Quest
{
    public class QuestEntity
        : IQuest
    {
        /// <summary>
        /// <see cref="IQuest.Id"/> implementation.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// <see cref="IQuest.Description"/> implementation.
        /// </summary>
        public string Description { get; set; }
    }
}
