using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wp.Data.Attributes;

namespace Wp.Data.Entities
{
    /// <summary>
    /// A post entity of Wordpress 
    /// </summary>
    [WpTable("posts")]
    public partial class WpPosts : WpEntity<ulong>
    {
        [Column("ID")]
        public override ulong Id { get; set; }

        [Column("post_author")]
        public ulong PostAuthor { get; set; }

        [Column("post_date", TypeName = "datetime")]
        public DateTime PostDate { get; set; }

        [Column("post_date_gmt", TypeName = "datetime")]
        public DateTime PostDateGmt { get; set; }

        [Required]
        [Column("post_content")]
        public string PostContent { get; set; }

        [Required]
        [Column("post_title", TypeName = "text")]
        public string PostTitle { get; set; }

        [Required]
        [Column("post_excerpt", TypeName = "text")]
        public string PostExcerpt { get; set; }

        [Required]
        [Column("post_status")]
        [StringLength(20)]
        public string PostStatus { get; set; }

        [Required]
        [Column("comment_status")]
        [StringLength(20)]
        public string CommentStatus { get; set; }

        [Required]
        [Column("ping_status")]
        [StringLength(20)]
        public string PingStatus { get; set; }

        [Required]
        [Column("post_password")]
        [StringLength(255)]
        public string PostPassword { get; set; }

        [Required]
        [Column("post_name")]
        [StringLength(200)]
        public string PostName { get; set; }

        [Required]
        [Column("to_ping", TypeName = "text")]
        public string ToPing { get; set; }

        [Required]
        [Column("pinged", TypeName = "text")]
        public string Pinged { get; set; }

        [Column("post_modified", TypeName = "datetime")]
        public DateTime PostModified { get; set; }

        [Column("post_modified_gmt", TypeName = "datetime")]
        public DateTime PostModifiedGmt { get; set; }

        [Required]
        [Column("post_content_filtered")]
        public string PostContentFiltered { get; set; }

        [Column("post_parent")]
        public ulong PostParent { get; set; }

        [Required]
        [Column("guid")]
        [StringLength(255)]
        public string Guid { get; set; }

        [Column("menu_order", TypeName = "int(11)")]
        public int MenuOrder { get; set; }

        [Required]
        [Column("post_type")]
        [StringLength(20)]
        public string PostType { get; set; }

        [Required]
        [Column("post_mime_type")]
        [StringLength(100)]
        public string PostMimeType { get; set; }

        [Column("comment_count", TypeName = "bigint(20)")]
        public long CommentCount { get; set; }
    }
}
