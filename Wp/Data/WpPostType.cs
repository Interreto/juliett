namespace Wp.Data
{
    /// <summary>
    /// Post Types
    /// WordPress can hold and display many different types of content. 
    /// A single item of such a content is generally called a post, although post is also a specific post type. 
    /// Internally, all the post types are stored in the same place, in the wp_posts database table, but are differentiated by a column called post_type.
    /// </summary>
    public static class WpPostType
    {
        /// <summary>
        /// Post in WordPress is a post type that is typical for and most used by blogs.
        /// </summary>
        public const string Post = "post";

        /// <summary>
        /// Page in WordPress is like post, but it lives outside the normal time-based listings of posts.
        /// </summary>
        public const string Page = "page";

        /// <summary>
        /// Attachment is a special post that holds information about a file uploaded through the WordPress media upload system, such as its description and name. 
        /// </summary>
        public const string Attachment = "attachment";

        /// <summary>
        /// Revision is used to hold a draft post as well as any past revisions of a published post.
        /// </summary>
        public const string Revision = "revision";

        /// <summary>
        /// Navigation Menu is a type that holds information about a single item in the WordPress navigation menu system.
        /// </summary>
        public const string NavigationMenu = "nav_menu_item";

        /// <summary>
        /// Custom CSS is a theme specific post used to store CSS saved from The Customizer's "Additional CSS" screen.
        /// </summary>
        public const string CustomCss = "custom_css";

        /// <summary>
        /// Changesets is similar to auto-saves but specifically for The Customizer. This is to keep The Customizer in a persistent state. 
        /// </summary>
        public const string Changesets = "customize_changeset";
    }
}
