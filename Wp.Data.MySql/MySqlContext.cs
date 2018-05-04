using Microsoft.EntityFrameworkCore;
using Wp.Data.Entities;

namespace Wp.Data.MySql
{
    public partial class MySqlContext : WpContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=1;database=www");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WpCommentMeta>(entity =>
            {
                entity.HasIndex(e => e.CommentId)
                    .HasName("comment_id");

                entity.HasIndex(e => e.Key)
                    .HasName("meta_key");

                entity.Property(e => e.CommentId).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<WpComments>(entity =>
            {
                entity.HasIndex(e => e.CommentAuthorEmail)
                    .HasName("comment_author_email");

                entity.HasIndex(e => e.CommentDateGmt)
                    .HasName("comment_date_gmt");

                entity.HasIndex(e => e.CommentParent)
                    .HasName("comment_parent");

                entity.HasIndex(e => e.CommentPostId)
                    .HasName("comment_post_ID");

                entity.HasIndex(e => new { e.CommentApproved, e.CommentDateGmt })
                    .HasName("comment_approved_date_gmt");

                entity.Property(e => e.CommentAgent).HasDefaultValueSql("''");

                entity.Property(e => e.CommentApproved).HasDefaultValueSql("'1'");

                entity.Property(e => e.CommentAuthorEmail).HasDefaultValueSql("''");

                entity.Property(e => e.CommentAuthorIp).HasDefaultValueSql("''");

                entity.Property(e => e.CommentAuthorUrl).HasDefaultValueSql("''");

                entity.Property(e => e.CommentDate).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CommentDateGmt).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CommentKarma).HasDefaultValueSql("'0'");

                entity.Property(e => e.CommentParent).HasDefaultValueSql("'0'");

                entity.Property(e => e.CommentPostId).HasDefaultValueSql("'0'");

                entity.Property(e => e.CommentType).HasDefaultValueSql("''");

                entity.Property(e => e.UserId).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<WpLinks>(entity =>
            {
                entity.HasIndex(e => e.LinkVisible)
                    .HasName("link_visible");

                entity.Property(e => e.LinkDescription).HasDefaultValueSql("''");

                entity.Property(e => e.LinkImage).HasDefaultValueSql("''");

                entity.Property(e => e.LinkName).HasDefaultValueSql("''");

                entity.Property(e => e.LinkOwner).HasDefaultValueSql("'1'");

                entity.Property(e => e.LinkRating).HasDefaultValueSql("'0'");

                entity.Property(e => e.LinkRel).HasDefaultValueSql("''");

                entity.Property(e => e.LinkRss).HasDefaultValueSql("''");

                entity.Property(e => e.LinkTarget).HasDefaultValueSql("''");

                entity.Property(e => e.LinkUpdated).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LinkUrl).HasDefaultValueSql("''");

                entity.Property(e => e.LinkVisible).HasDefaultValueSql("'Y'");
            });

            modelBuilder.Entity<WpOptions>(entity =>
            {
                entity.HasIndex(e => e.OptionName)
                    .HasName("option_name")
                    .IsUnique();

                entity.Property(e => e.Autoload).HasDefaultValueSql("'yes'");

                entity.Property(e => e.OptionName).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<WpPostMeta>(entity =>
            {
                entity.HasIndex(e => e.Key)
                    .HasName("meta_key");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.Property(e => e.PostId).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<WpPosts>(entity =>
            {
                entity.HasIndex(e => e.PostAuthor)
                    .HasName("post_author");

                entity.HasIndex(e => e.PostName)
                    .HasName("post_name");

                entity.HasIndex(e => e.PostParent)
                    .HasName("post_parent");

                entity.HasIndex(e => new { e.PostType, e.PostStatus, e.PostDate, e.Id })
                    .HasName("type_status_date");

                entity.Property(e => e.CommentCount).HasDefaultValueSql("'0'");

                entity.Property(e => e.CommentStatus).HasDefaultValueSql("'open'");

                entity.Property(e => e.Guid).HasDefaultValueSql("''");

                entity.Property(e => e.MenuOrder).HasDefaultValueSql("'0'");

                entity.Property(e => e.PingStatus).HasDefaultValueSql("'open'");

                entity.Property(e => e.PostAuthor).HasDefaultValueSql("'0'");

                entity.Property(e => e.PostDate).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostDateGmt).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostMimeType).HasDefaultValueSql("''");

                entity.Property(e => e.PostModified).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostModifiedGmt).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostName).HasDefaultValueSql("''");

                entity.Property(e => e.PostParent).HasDefaultValueSql("'0'");

                entity.Property(e => e.PostPassword).HasDefaultValueSql("''");

                entity.Property(e => e.PostStatus).HasDefaultValueSql("'publish'");

                entity.Property(e => e.PostType).HasDefaultValueSql("'post'");
            });

            modelBuilder.Entity<WpTermMeta>(entity =>
            {
                entity.HasIndex(e => e.Key)
                    .HasName("meta_key");

                entity.HasIndex(e => e.TermId)
                    .HasName("term_id");

                entity.Property(e => e.TermId).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<WpTermRelationships>(entity =>
            {
                entity.HasKey(e => new { e.ObjectId, e.TermTaxonomyId });

                entity.HasIndex(e => e.TermTaxonomyId)
                    .HasName("term_taxonomy_id");

                entity.Property(e => e.ObjectId).HasDefaultValueSql("'0'");

                entity.Property(e => e.TermTaxonomyId).HasDefaultValueSql("'0'");

                entity.Property(e => e.TermOrder).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<WpTerms>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.Slug)
                    .HasName("slug");

                entity.Property(e => e.Name).HasDefaultValueSql("''");

                entity.Property(e => e.Slug).HasDefaultValueSql("''");

                entity.Property(e => e.TermGroup).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<WpTermTaxonomy>(entity =>
            {
                entity.HasIndex(e => e.Taxonomy)
                    .HasName("taxonomy");

                entity.HasIndex(e => new { e.TermId, e.Taxonomy })
                    .HasName("term_id_taxonomy")
                    .IsUnique();

                entity.Property(e => e.Count).HasDefaultValueSql("'0'");

                entity.Property(e => e.Parent).HasDefaultValueSql("'0'");

                entity.Property(e => e.Taxonomy).HasDefaultValueSql("''");

                entity.Property(e => e.TermId).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<WpUserMeta>(entity =>
            {
                entity.HasIndex(e => e.Key)
                    .HasName("meta_key");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.UserId).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<WpUsers>(entity =>
            {
                entity.HasIndex(e => e.UserEmail)
                    .HasName("user_email");

                entity.HasIndex(e => e.UserLogin)
                    .HasName("user_login_key");

                entity.HasIndex(e => e.UserNicename)
                    .HasName("user_nicename");

                entity.Property(e => e.DisplayName).HasDefaultValueSql("''");

                entity.Property(e => e.UserActivationKey).HasDefaultValueSql("''");

                entity.Property(e => e.UserEmail).HasDefaultValueSql("''");

                entity.Property(e => e.UserLogin).HasDefaultValueSql("''");

                entity.Property(e => e.UserNicename).HasDefaultValueSql("''");

                entity.Property(e => e.UserPass).HasDefaultValueSql("''");

                entity.Property(e => e.UserRegistered).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UserStatus).HasDefaultValueSql("'0'");

                entity.Property(e => e.UserUrl).HasDefaultValueSql("''");
            });
        }
    }
}
