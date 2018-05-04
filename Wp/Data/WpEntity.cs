namespace Wp.Data
{
    /// <summary>
    /// A database entity of Wordpress 
    /// </summary>
    public abstract class WpEntity
    {
    }

    /// <summary>
    /// A database entity of Wordpress with primary key 
    /// </summary>
    public abstract class WpEntity<T> : WpEntity
        where T : struct
    {
        /// <summary>
        /// Primary key 
        /// </summary>
        public abstract T Id { get; set; }
    }
}
