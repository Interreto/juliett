using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wp.Data.Attributes;

namespace Wp.Data.Entities
{
    [WpTable("options")]
    public partial class WpOptions : WpEntity<ulong>
    {
        [Key]
        [Column("option_id")]
        public override ulong Id { get; set; }

        [Required]
        [Column("option_name")]
        [StringLength(191)]
        public string OptionName { get; set; }

        [Required]
        [Column("option_value")]
        public string OptionValue { get; set; }

        [Required]
        [Column("autoload")]
        [StringLength(20)]
        public string Autoload { get; set; }
    }
}
