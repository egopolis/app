namespace Epg.World
{
    public interface IWorldStorage
    {
        /// <summary>
        /// Add entity to the world.
        /// </summary>
        void Add(string name, object entity);

        /// <summary>
        /// Get entity by its name.
        /// </summary>
        object Get(string name);
    }
}
