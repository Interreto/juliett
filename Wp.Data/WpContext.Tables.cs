using Microsoft.EntityFrameworkCore;
using Wp.Data.Entities;

namespace Wp.Data
{
    partial class WpContext
    {
        public virtual DbSet<WpCommentMeta> CommentMeta { get; set; }

        public virtual DbSet<WpComments> Comments { get; set; }

        public virtual DbSet<WpLinks> Links { get; set; }

        public virtual DbSet<WpOptions> Options { get; set; }

        public virtual DbSet<WpPostMeta> PostMeta { get; set; }

        public virtual DbSet<WpPosts> Posts { get; set; }

        public virtual DbSet<WpTermMeta> TermMeta { get; set; }

        public virtual DbSet<WpTermRelationships> TermRelationships { get; set; }

        public virtual DbSet<WpTerms> Terms { get; set; }

        public virtual DbSet<WpTermTaxonomy> TermTaxonomy { get; set; }

        public virtual DbSet<WpUserMeta> UserMeta { get; set; }

        public virtual DbSet<WpUsers> Users { get; set; }
    }
}
