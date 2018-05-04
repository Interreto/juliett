using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wp.Data.Attributes;

namespace Wp.Data.Entities
{
    [WpTable("links")]
    public partial class WpLinks : WpEntity<ulong>
    {
        [Key]
        [Column("link_id")]
        public override ulong Id { get; set; }

        [Required]
        [Column("link_url")]
        [StringLength(255)]
        public string LinkUrl { get; set; }

        [Required]
        [Column("link_name")]
        [StringLength(255)]
        public string LinkName { get; set; }

        [Required]
        [Column("link_image")]
        [StringLength(255)]
        public string LinkImage { get; set; }

        [Required]
        [Column("link_target")]
        [StringLength(25)]
        public string LinkTarget { get; set; }

        [Required]
        [Column("link_description")]
        [StringLength(255)]
        public string LinkDescription { get; set; }

        [Required]
        [Column("link_visible")]
        [StringLength(20)]
        public string LinkVisible { get; set; }

        [Column("link_owner")]
        public ulong LinkOwner { get; set; }

        [Column("link_rating", TypeName = "int(11)")]
        public int LinkRating { get; set; }

        [Column("link_updated", TypeName = "datetime")]
        public DateTime LinkUpdated { get; set; }

        [Required]
        [Column("link_rel")]
        [StringLength(255)]
        public string LinkRel { get; set; }

        [Required]
        [Column("link_notes", TypeName = "mediumtext")]
        public string LinkNotes { get; set; }

        [Required]
        [Column("link_rss")]
        [StringLength(255)]
        public string LinkRss { get; set; }
    }
}
