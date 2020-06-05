using System;

namespace Epg.World
{
    /// <summary>
    /// Useful method extensions for the <see cref="IWorldStorage"/>.
    /// </summary>
    public static class IWorldStorageExtensions
    {
        /// <summary>
        /// Add entity to the world.
        /// </summary>
        /// 
        /// <remarks>
        /// Compared to the <see cref="IWorldStorage.Add(string, object)"/> it allow to omit the
        /// name and it is generated automatically.
        /// </remarks>
        /// 
        /// <returns>Returns generated name</returns>
        public static string Add(this IWorldStorage storage, object entity)
        {
            var name = Guid.NewGuid().ToString("N");

            storage.Add(name, entity);

            return name;
        }
    }
}
