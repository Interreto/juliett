namespace Wp.Data
{
    /// <summary>
    /// Post Status
    /// Posts in WordPress can have one of a number of statuses. 
    /// The status of a given post determines how WordPress handles that post. 
    /// For instance, public posts viewable by everyone are assigned the publish status, while drafts are assigned the draft status.
    /// The status is stored in the post_status field in the wp_posts table.
    /// </summary>
    public static class WpPostStatus 
    {
        /// <summary>
        /// Viewable by everyone. (publish)
        /// </summary>
        public const string Publish = "publish";

        /// <summary>
        /// Scheduled to be published in a future date. (future)
        /// </summary>
        public const string Future = "future";

        /// <summary>
        /// Incomplete post viewable by anyone with proper user role. (draft)
        /// </summary>
        public const string Draft = "draft";

        /// <summary>
        /// Awaiting a user with the publish_posts capability (typically a user assigned the Editor role) to publish. (pending)
        /// </summary>
        public const string Pending = "pending";

        /// <summary>
        /// Viewable only to WordPress users at Administrator level. (private)
        /// </summary>
        public const string Private = "private";

        /// <summary>
        /// Posts in the Trash are assigned the trash status. (trash)
        /// </summary>
        public const string Trash = "trash";

        /// <summary>
        /// Revisions that WordPress saves automatically while you are editing. (auto-draft)
        /// </summary>
        public const string AutoDraft = "auto-draft";

        /// <summary>
        /// Used with a child post (such as Attachments and Revisions) to determine the actual status from the parent post. (inherit)
        /// </summary>
        public const string Inherit = "inherit";
    }
}
