namespace Wp.Data
{
    /// <summary>
    /// A database entity meta interface
    /// </summary>
    public interface IWpEnitityMeta
    {
        /// <summary>
        /// Gets or sets meta key
        /// </summary>
        string Key { get; set; }

        /// <summary>
        /// Gets or sets meta value
        /// </summary>
        string Value { get; set; }
    }
}
