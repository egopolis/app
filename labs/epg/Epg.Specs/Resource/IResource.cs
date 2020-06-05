namespace Epg.Resource
{
    /// <summary>
    /// Resource.
    /// </summary>
    ///
    /// <remarks>
    /// This can be time, money, etc.
    /// </remarks>
    public interface IResource
    {
        /// <summary>
        /// Resource identifier.
        /// </summary>
        string Id { get; }


        /// <summary>
        /// Resource name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Optional parent resource.
        /// </summary>
        public IResource Parent { get; }
    }
}
