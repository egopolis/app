namespace Epg.Quest
{
    /// <summary>
    /// Quest (adventure).
    /// </summary>
    ///
    /// <remarks>
    /// This is what we are living for.
    /// </remarks>
    public interface IQuest
    {
        /// <summary>
        /// Quest identifier.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Resource description.
        /// </summary>
        string Description { get; }
    }
}
