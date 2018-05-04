using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wp.Data.Attributes;

namespace Wp.Data.Entities
{
    /// <summary>
    /// A commentmeta entity of Wordpress 
    /// </summary>
    [WpTable("commentmeta")]
    public partial class WpCommentMeta : WpEntity<ulong>, IWpEnitityMeta
    {
        [Key]
        [Column("meta_id")]
        public override ulong Id { get; set; }

        [Column("comment_id")]
        public ulong CommentId { get; set; }

        [Column("meta_key")]
        [StringLength(255)]
        public string Key { get; set; }

        [Column("meta_value")]
        public string Value { get; set; }
    }
}
