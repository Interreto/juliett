namespace Wp.Data
{
    /// <summary>
    /// A database entity of Wordpress 
    /// </summary>
    public abstract class WpEntity
    {
    }

    /// <summary>
    /// A database entity of Wordpress with key
    /// </summary>
    public abstract class WpEntity<T> : WpEntity where T : struct
    {
        public abstract T Id { get; set; }
    }
}
