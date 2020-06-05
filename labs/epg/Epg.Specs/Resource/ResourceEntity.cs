using System;

namespace Epg.Resource
{
    /// <summary>
    /// Basic <see cref="IResource"/> implementation.
    /// </summary>
    public class ResourceEntity
        : IResource
    {
        /// <summary>
        /// <see cref="IResource.Id"/> implementation.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// <see cref="IResource.Name"/> implementation.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// <see cref="IResource.Parent"/> implementation.
        /// </summary>
        public IResource Parent { get; set; }

        /// <summary>
        /// Construct.
        /// </summary>
        public ResourceEntity()
        {

        }

        /// <summary>
        /// Construct using name.
        /// </summary>
        public ResourceEntity(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Id = name.ToLower();
            Name = name;
        }
    }
}
