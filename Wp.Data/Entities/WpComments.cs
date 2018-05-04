using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wp.Data.Attributes;

namespace Wp.Data.Entities
{
    /// <summary>
    /// A comment entity of Wordpress 
    /// </summary>
    [WpTable("comments")]
    public partial class WpComments : WpEntity<ulong>
    {
        [Key]
        [Column("comment_ID")]
        public override ulong Id { get; set; }

        [Column("comment_post_ID")]
        public ulong CommentPostId { get; set; }

        [Required]
        [Column("comment_author", TypeName = "tinytext")]
        public string CommentAuthor { get; set; }

        [Required]
        [Column("comment_author_email")]
        [StringLength(100)]
        public string CommentAuthorEmail { get; set; }

        [Required]
        [Column("comment_author_url")]
        [StringLength(200)]
        public string CommentAuthorUrl { get; set; }

        [Required]
        [Column("comment_author_IP")]
        [StringLength(100)]
        public string CommentAuthorIp { get; set; }

        [Column("comment_date", TypeName = "datetime")]
        public DateTime CommentDate { get; set; }

        [Column("comment_date_gmt", TypeName = "datetime")]
        public DateTime CommentDateGmt { get; set; }

        [Required]
        [Column("comment_content", TypeName = "text")]
        public string CommentContent { get; set; }

        [Column("comment_karma", TypeName = "int(11)")]
        public int CommentKarma { get; set; }

        [Required]
        [Column("comment_approved")]
        [StringLength(20)]
        public string CommentApproved { get; set; }

        [Required]
        [Column("comment_agent")]
        [StringLength(255)]
        public string CommentAgent { get; set; }

        [Required]
        [Column("comment_type")]
        [StringLength(20)]
        public string CommentType { get; set; }

        [Column("comment_parent")]
        public ulong CommentParent { get; set; }

        [Column("user_id")]
        public ulong UserId { get; set; }
    }
}
