using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wp.Data.Attributes;

namespace Wp.Data.Entities
{
    /// <summary>
    /// A term_taxonomy entity of Wordpress 
    /// </summary>
    [WpTable("term_taxonomy")]
    public partial class WpTermTaxonomy : WpEntity<ulong>
    {
        [Key]
        [Column("term_taxonomy_id")]
        public override ulong Id { get; set; }

        [Column("term_id")]
        public ulong TermId { get; set; }

        [Required]
        [Column("taxonomy")]
        [StringLength(32)]
        public string Taxonomy { get; set; }

        [Required]
        [Column("description")]
        public string Description { get; set; }

        [Column("parent")]
        public ulong Parent { get; set; }

        [Column("count", TypeName = "bigint(20)")]
        public long Count { get; set; }
    }
}
