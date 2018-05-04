using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wp.Data.Attributes;

namespace Wp.Data.Entities
{
    /// <summary>
    /// A term entity of Wordpress 
    /// </summary>
    [WpTable("terms")]
    public partial class WpTerms : WpEntity<ulong>
    {
        [Key]
        [Column("term_id")]
        public override ulong Id { get; set; }

        [Required]
        [Column("name")]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [Column("slug")]
        [StringLength(200)]
        public string Slug { get; set; }

        [Column("term_group", TypeName = "bigint(10)")]
        public long TermGroup { get; set; }
    }
}
