using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wp.Data.Attributes;

namespace Wp.Data.Entities
{
    /// <summary>
    /// A usermeta entity of Wordpress 
    /// </summary>
    [WpTable("usermeta")]
    public partial class WpUserMeta : WpMeta<ulong>
    {
        [Key]
        [Column("umeta_id")]
        public override ulong Id { get; set; }

        [Column("user_id")]
        public override ulong EntityId { get; set; }

        [Column("meta_key")]
        [StringLength(255)]
        public override string Key { get; set; }

        [Column("meta_value")]
        public override string Value { get; set; }
    }
}
