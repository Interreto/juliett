using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wp.Data.Attributes;

namespace Wp.Data.Entities
{
    /// <summary>
    /// A term to object relationship entity of Wordpress 
    /// </summary>
    [WpTable("term_relationships")]
    public partial class WpTermRelationships : WpEntity
    {
        [Column("object_id")]
        public ulong ObjectId { get; set; }

        [Column("term_taxonomy_id")]
        public ulong TermTaxonomyId { get; set; }

        [Column("term_order", TypeName = "int(11)")]
        public int TermOrder { get; set; }
    }
}
