namespace Wp.Data
{
    /// <summary>
    /// A database entity meta interface
    /// </summary>
    public abstract class WpMeta<T> : WpEntity<T>
        where T : struct
    {
        /// <summary>
        /// Foreign key
        /// </summary>
        public abstract T EntityId { get; set; }

        /// <summary>
        /// Gets or sets meta key
        /// </summary>
        public abstract string Key { get; set; }

        /// <summary>
        /// Gets or sets meta value
        /// </summary>
        public abstract string Value { get; set; }
    }
}
