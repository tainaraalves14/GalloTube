using GalloTube.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GalloTube.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Video> Videos { get; set; }
        public DbSet<VideoTag> VideoTags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Personalização do Identity
            builder.Entity<IdentityUser>(b => {
                b.ToTable("Users");
            });
            builder.Entity<IdentityUserClaim<string>>(b => {
                b.ToTable("UserClaims");
            });
            builder.Entity<IdentityUserLogin<string>>(b => {
                b.ToTable("UserLogins");
            });
            builder.Entity<IdentityUserToken<string>>(b => {
                b.ToTable("UserTokens");
            });
            builder.Entity<IdentityRole>(b => {
                b.ToTable("Roles");
            });
            builder.Entity<IdentityRoleClaim<string>>(b => {
                b.ToTable("RoleClaims");
            });
            builder.Entity<IdentityUserRole<string>>(b => {
                b.ToTable("UserRoles");
            });

            // Many-to-Many: VideoTag
            builder.Entity<VideoTag>().HasKey(vt => new { vt.VideoId, vt.TagId });
            builder.Entity<VideoTag>()
                .HasOne(vt => vt.Video)
                .WithMany(v => v.Tags)
                .HasForeignKey(vt => vt.VideoId);
            builder.Entity<VideoTag>()
                .HasOne(vt => vt.Tag)
                .WithMany(t => t.Videos)
                .HasForeignKey(vt => vt.TagId);

            // Other configurations...
        }
    }
}
