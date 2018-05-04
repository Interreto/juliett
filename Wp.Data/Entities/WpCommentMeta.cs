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
    public partial class WpCommentMeta : WpMeta<ulong>
    {
        [Key]
        [Column("meta_id")]
        public override ulong Id { get; set; }

        [Column("comment_id")]
        public override ulong EntityId { get; set; }

        [Column("meta_key")]
        [StringLength(255)]
        public override string Key { get; set; }

        [Column("meta_value")]
        public override string Value { get; set; }
    }
}
