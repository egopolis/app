using Epg.World;

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
        /// Resource description.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The quest to be succesfully finished.
        /// </summary>
        /// 
        /// <remarks>
        /// Quest with this <see cref="IEntity.Name"/> will be considered as successfully finished
        /// if current one is done. So it is like a dependency. And referenced in this way there
        /// can be multiple win conditions.
        /// </remarks>
        string Win { get; }
    }
}
