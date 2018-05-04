using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wp.Data.Attributes;

namespace Wp.Data.Entities
{
    [WpTable("users")]
    public partial class WpUsers : WpEntity<ulong>
    {
        [Column("ID")]
        public override ulong Id { get; set; }

        [Required]
        [Column("user_login")]
        [StringLength(60)]
        public string UserLogin { get; set; }

        [Required]
        [Column("user_pass")]
        [StringLength(255)]
        public string UserPass { get; set; }

        [Required]
        [Column("user_nicename")]
        [StringLength(50)]
        public string UserNicename { get; set; }

        [Required]
        [Column("user_email")]
        [StringLength(100)]
        public string UserEmail { get; set; }

        [Required]
        [Column("user_url")]
        [StringLength(100)]
        public string UserUrl { get; set; }

        [Column("user_registered", TypeName = "datetime")]
        public DateTime UserRegistered { get; set; }

        [Required]
        [Column("user_activation_key")]
        [StringLength(255)]
        public string UserActivationKey { get; set; }

        [Column("user_status", TypeName = "int(11)")]
        public int UserStatus { get; set; }

        [Required]
        [Column("display_name")]
        [StringLength(250)]
        public string DisplayName { get; set; }
    }
}
