using Epg.World;

namespace Epg.Quest
{
    /// <summary>
    /// Useful method extensions for <see cref="IWorldStorage"/>.
    /// </summary>
    public static class IWorldStorageExtensions
    {
        public static string Quest(
            this IWorldStorage storage,
            string description,
            string win = null
        )
        {
            return storage.Add(new QuestEntity
            {
                Description = description,
                Win = win
            });
        }
    }
}
