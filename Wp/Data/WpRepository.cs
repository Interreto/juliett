namespace Wp.Data
{
    /// <summary>
    /// A repository of Wordpress
    /// </summary>
    public abstract class WpRepository
    {
    }

    /// <summary>
    /// A entity repository of Wordpress
    /// </summary>
    public abstract class WpRepository<TEntity> : WpRepository 
        where TEntity : WpEntity
    {
    }
}
