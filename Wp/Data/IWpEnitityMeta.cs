namespace Wp.Data
{
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
