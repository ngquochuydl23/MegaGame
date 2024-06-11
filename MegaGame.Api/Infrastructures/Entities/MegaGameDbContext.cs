using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MegaGame.Api.Infrastructures.Entities;

public partial class MegaGameDbContext : DbContext
{
    public MegaGameDbContext()
    {
    }

    public MegaGameDbContext(DbContextOptions<MegaGameDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminPermission> AdminPermissions { get; set; }

    public virtual DbSet<AdminPermissionsRoleLink> AdminPermissionsRoleLinks { get; set; }

    public virtual DbSet<AdminRole> AdminRoles { get; set; }

    public virtual DbSet<AdminUser> AdminUsers { get; set; }

    public virtual DbSet<AdminUsersRolesLink> AdminUsersRolesLinks { get; set; }

    public virtual DbSet<Banner> Banners { get; set; }

    public virtual DbSet<BannersComponent> BannersComponents { get; set; }

    public virtual DbSet<CategoriesGamesGamesCategory> CategoriesGamesGamesCategories { get; set; }

    public virtual DbSet<CategoriesGamesLink> CategoriesGamesLinks { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<ComponentsPageButton> ComponentsPageButtons { get; set; }

    public virtual DbSet<ComponentsPageHighlight> ComponentsPageHighlights { get; set; }

    public virtual DbSet<ComponentsPagePopularGame> ComponentsPagePopularGames { get; set; }

    public virtual DbSet<ComponentsPagePopularGamesComponent> ComponentsPagePopularGamesComponents { get; set; }

    public virtual DbSet<ComponentsPagePopularGamesGame> ComponentsPagePopularGamesGames { get; set; }

    public virtual DbSet<ComponentsPageRibbon> ComponentsPageRibbons { get; set; }

    public virtual DbSet<ComponentsPageSection> ComponentsPageSections { get; set; }

    public virtual DbSet<ComponentsPageSectionsComponent> ComponentsPageSectionsComponents { get; set; }

    public virtual DbSet<CoreStore> CoreStores { get; set; }

    public virtual DbSet<Developer> Developers { get; set; }

    public virtual DbSet<DevelopersGamesGamesDeveloper> DevelopersGamesGamesDevelopers { get; set; }

    public virtual DbSet<DevelopersGamesLink> DevelopersGamesLinks { get; set; }

    public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }

    public virtual DbSet<File> Files { get; set; }

    public virtual DbSet<FilesRelatedMorph> FilesRelatedMorphs { get; set; }

    public virtual DbSet<Game> Games { get; set; }

    public virtual DbSet<GamesCategoriesLink> GamesCategoriesLinks { get; set; }

    public virtual DbSet<GamesDevelopersLink> GamesDevelopersLinks { get; set; }

    public virtual DbSet<GamesPlatformsLink> GamesPlatformsLinks { get; set; }

    public virtual DbSet<GamesPlatformsPlatformsGame> GamesPlatformsPlatformsGames { get; set; }

    public virtual DbSet<GamesPublisherLink> GamesPublisherLinks { get; set; }

    public virtual DbSet<Home> Homes { get; set; }

    public virtual DbSet<HomesComponent> HomesComponents { get; set; }

    public virtual DbSet<I18nLocale> I18nLocales { get; set; }

    public virtual DbSet<I18nLocale1> I18nLocales1 { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrdersGame> OrdersGames { get; set; }

    public virtual DbSet<Platform> Platforms { get; set; }

    public virtual DbSet<PlatformsGamesLink> PlatformsGamesLinks { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    public virtual DbSet<Recommended> Recommendeds { get; set; }

    public virtual DbSet<RecommendedsComponent> RecommendedsComponents { get; set; }

    public virtual DbSet<StrapiAdministrator> StrapiAdministrators { get; set; }

    public virtual DbSet<StrapiApiToken> StrapiApiTokens { get; set; }

    public virtual DbSet<StrapiCoreStoreSetting> StrapiCoreStoreSettings { get; set; }

    public virtual DbSet<StrapiDatabaseSchema> StrapiDatabaseSchemas { get; set; }

    public virtual DbSet<StrapiMigration> StrapiMigrations { get; set; }

    public virtual DbSet<StrapiPermission> StrapiPermissions { get; set; }

    public virtual DbSet<StrapiRole> StrapiRoles { get; set; }

    public virtual DbSet<StrapiUsersRole> StrapiUsersRoles { get; set; }

    public virtual DbSet<StrapiWebhook> StrapiWebhooks { get; set; }

    public virtual DbSet<UpPermission> UpPermissions { get; set; }

    public virtual DbSet<UpPermissionsRoleLink> UpPermissionsRoleLinks { get; set; }

    public virtual DbSet<UpRole> UpRoles { get; set; }

    public virtual DbSet<UpUser> UpUsers { get; set; }

    public virtual DbSet<UpUsersRoleLink> UpUsersRoleLinks { get; set; }

    public virtual DbSet<UploadFile> UploadFiles { get; set; }

    public virtual DbSet<UploadFileMorph> UploadFileMorphs { get; set; }

    public virtual DbSet<UsersPermissionsPermission> UsersPermissionsPermissions { get; set; }

    public virtual DbSet<UsersPermissionsRole> UsersPermissionsRoles { get; set; }

    public virtual DbSet<UsersPermissionsUser> UsersPermissionsUsers { get; set; }

    public virtual DbSet<Wishlist> Wishlists { get; set; }

    public virtual DbSet<WishlistsGame> WishlistsGames { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=server-1.pgonevn.com;Port=5432;Database=MegaGameDb;User ID=postgres;Password=720798d5-aa5a-476e-a3a3-5e3392324052");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminPermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("admin_permissions");

            entity.Property(e => e.Action)
                .HasMaxLength(255)
                .HasColumnName("action");
            entity.Property(e => e.Conditions)
                .HasColumnType("jsonb")
                .HasColumnName("conditions");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedById).HasColumnName("created_by_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Properties)
                .HasColumnType("jsonb")
                .HasColumnName("properties");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasColumnName("subject");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");
        });

        modelBuilder.Entity<AdminPermissionsRoleLink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("admin_permissions_role_links");

            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
        });

        modelBuilder.Entity<AdminRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("admin_roles");

            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedById).HasColumnName("created_by_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");
        });

        modelBuilder.Entity<AdminUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("admin_users");

            entity.Property(e => e.Blocked).HasColumnName("blocked");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedById).HasColumnName("created_by_id");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .HasColumnName("firstname");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .HasColumnName("lastname");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.PreferedLanguage)
                .HasMaxLength(255)
                .HasColumnName("prefered_language");
            entity.Property(e => e.RegistrationToken)
                .HasMaxLength(255)
                .HasColumnName("registration_token");
            entity.Property(e => e.ResetPasswordToken)
                .HasMaxLength(255)
                .HasColumnName("reset_password_token");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        modelBuilder.Entity<AdminUsersRolesLink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("admin_users_roles_links");

            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Banner>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("banners");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.PublishedAt).HasColumnName("published_at");
            entity.Property(e => e.Subtitle).HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
        });

        modelBuilder.Entity<BannersComponent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("banners_components");

            entity.Property(e => e.BannerId).HasColumnName("banner_id");
            entity.Property(e => e.ComponentId).HasColumnName("component_id");
            entity.Property(e => e.ComponentType)
                .HasMaxLength(255)
                .HasColumnName("component_type");
            entity.Property(e => e.Field)
                .HasMaxLength(255)
                .HasColumnName("field");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Order).HasColumnName("order");
        });

        modelBuilder.Entity<CategoriesGamesGamesCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("categories_games__games_categories");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.GameId).HasColumnName("game_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<CategoriesGamesLink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("categories_games_links");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.GameId).HasColumnName("game_id");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("categories");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreatedById).HasColumnName("created_by_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PublishedAt).HasColumnName("published_at");
            entity.Property(e => e.Slug)
                .HasMaxLength(255)
                .HasColumnName("slug");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");
        });

        modelBuilder.Entity<ComponentsPageButton>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("components_page_buttons");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Label)
                .HasMaxLength(255)
                .HasColumnName("label");
            entity.Property(e => e.Link)
                .HasMaxLength(255)
                .HasColumnName("link");
        });

        modelBuilder.Entity<ComponentsPageHighlight>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("components_page_highlights");

            entity.Property(e => e.Alignment)
                .HasMaxLength(255)
                .HasColumnName("alignment");
            entity.Property(e => e.ButtonLabel)
                .HasMaxLength(255)
                .HasColumnName("buttonLabel");
            entity.Property(e => e.ButtonLink)
                .HasMaxLength(255)
                .HasColumnName("buttonLink");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Subtitle).HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        modelBuilder.Entity<ComponentsPagePopularGame>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("components_page_popular_games");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        modelBuilder.Entity<ComponentsPagePopularGamesComponent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("components_page_popular_games_components");

            entity.Property(e => e.ComponentId).HasColumnName("component_id");
            entity.Property(e => e.ComponentType)
                .HasMaxLength(255)
                .HasColumnName("component_type");
            entity.Property(e => e.ComponentsPagePopularGameId).HasColumnName("components_page_popular_game_id");
            entity.Property(e => e.Field)
                .HasMaxLength(255)
                .HasColumnName("field");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Order).HasColumnName("order");
        });

        modelBuilder.Entity<ComponentsPagePopularGamesGame>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("components_page_popular_games__games");

            entity.Property(e => e.ComponentsPagePopularGameId).HasColumnName("components_page_popular_game_id");
            entity.Property(e => e.GameId).HasColumnName("game_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<ComponentsPageRibbon>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("components_page_ribbons");

            entity.Property(e => e.Color)
                .HasMaxLength(255)
                .HasColumnName("color");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Size)
                .HasMaxLength(255)
                .HasColumnName("size");
            entity.Property(e => e.Text)
                .HasMaxLength(255)
                .HasColumnName("text");
        });

        modelBuilder.Entity<ComponentsPageSection>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("components_page_sections");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        modelBuilder.Entity<ComponentsPageSectionsComponent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("components_page_sections_components");

            entity.Property(e => e.ComponentId).HasColumnName("component_id");
            entity.Property(e => e.ComponentType)
                .HasMaxLength(255)
                .HasColumnName("component_type");
            entity.Property(e => e.ComponentsPageSectionId).HasColumnName("components_page_section_id");
            entity.Property(e => e.Field)
                .HasMaxLength(255)
                .HasColumnName("field");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Order).HasColumnName("order");
        });

        modelBuilder.Entity<CoreStore>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("core_store");

            entity.Property(e => e.Environment)
                .HasMaxLength(255)
                .HasColumnName("environment");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Key)
                .HasMaxLength(255)
                .HasColumnName("key");
            entity.Property(e => e.Tag)
                .HasMaxLength(255)
                .HasColumnName("tag");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<Developer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("developers");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreatedById).HasColumnName("created_by_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PublishedAt).HasColumnName("published_at");
            entity.Property(e => e.Slug)
                .HasMaxLength(255)
                .HasColumnName("slug");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");
        });

        modelBuilder.Entity<DevelopersGamesGamesDeveloper>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("developers_games__games_developers");

            entity.Property(e => e.DeveloperId).HasColumnName("developer_id");
            entity.Property(e => e.GameId).HasColumnName("game_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<DevelopersGamesLink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("developers_games_links");

            entity.Property(e => e.DeveloperId).HasColumnName("developer_id");
            entity.Property(e => e.GameId).HasColumnName("game_id");
        });

        modelBuilder.Entity<EmailTemplate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("email_templates");

            entity.Property(e => e.BodyHtml).HasColumnName("bodyHtml");
            entity.Property(e => e.BodyText).HasColumnName("bodyText");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Design)
                .HasColumnType("jsonb")
                .HasColumnName("design");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasColumnName("subject");
            entity.Property(e => e.Tags)
                .HasColumnType("jsonb")
                .HasColumnName("tags");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
        });

        modelBuilder.Entity<File>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("files");

            entity.Property(e => e.AlternativeText)
                .HasMaxLength(255)
                .HasColumnName("alternative_text");
            entity.Property(e => e.Caption)
                .HasMaxLength(255)
                .HasColumnName("caption");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedById).HasColumnName("created_by_id");
            entity.Property(e => e.Ext)
                .HasMaxLength(255)
                .HasColumnName("ext");
            entity.Property(e => e.Formats)
                .HasColumnType("jsonb")
                .HasColumnName("formats");
            entity.Property(e => e.Hash)
                .HasMaxLength(255)
                .HasColumnName("hash");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Mime)
                .HasMaxLength(255)
                .HasColumnName("mime");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PreviewUrl)
                .HasMaxLength(255)
                .HasColumnName("preview_url");
            entity.Property(e => e.Provider)
                .HasMaxLength(255)
                .HasColumnName("provider");
            entity.Property(e => e.ProviderMetadata)
                .HasColumnType("jsonb")
                .HasColumnName("provider_metadata");
            entity.Property(e => e.Size)
                .HasPrecision(10, 2)
                .HasColumnName("size");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
            entity.Property(e => e.Width).HasColumnName("width");
        });

        modelBuilder.Entity<FilesRelatedMorph>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("files_related_morphs");

            entity.Property(e => e.Field)
                .HasMaxLength(255)
                .HasColumnName("field");
            entity.Property(e => e.FileId).HasColumnName("file_id");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.RelatedId).HasColumnName("related_id");
            entity.Property(e => e.RelatedType)
                .HasMaxLength(255)
                .HasColumnName("related_type");
        });

        modelBuilder.Entity<Game>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("games");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreatedById).HasColumnName("created_by_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
            entity.Property(e => e.PublishedAt).HasColumnName("published_at");
            entity.Property(e => e.Publisher).HasColumnName("publisher");
            entity.Property(e => e.Rating)
                .HasMaxLength(255)
                .HasColumnName("rating");
            entity.Property(e => e.ReleaseDate).HasColumnName("release_date");
            entity.Property(e => e.ShortDescription).HasColumnName("short_description");
            entity.Property(e => e.Slug)
                .HasMaxLength(255)
                .HasColumnName("slug");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");
        });

        modelBuilder.Entity<GamesCategoriesLink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("games_categories_links");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.GameId).HasColumnName("game_id");
        });

        modelBuilder.Entity<GamesDevelopersLink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("games_developers_links");

            entity.Property(e => e.DeveloperId).HasColumnName("developer_id");
            entity.Property(e => e.GameId).HasColumnName("game_id");
        });

        modelBuilder.Entity<GamesPlatformsLink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("games_platforms_links");

            entity.Property(e => e.GameId).HasColumnName("game_id");
            entity.Property(e => e.PlatformId).HasColumnName("platform_id");
        });

        modelBuilder.Entity<GamesPlatformsPlatformsGame>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("games_platforms__platforms_games");

            entity.Property(e => e.GameId).HasColumnName("game_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.PlatformId).HasColumnName("platform_id");
        });

        modelBuilder.Entity<GamesPublisherLink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("games_publisher_links");

            entity.Property(e => e.GameId).HasColumnName("game_id");
            entity.Property(e => e.PublisherId).HasColumnName("publisher_id");
        });

        modelBuilder.Entity<Home>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("homes");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.PublishedAt).HasColumnName("published_at");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
        });

        modelBuilder.Entity<HomesComponent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("homes_components");

            entity.Property(e => e.ComponentId).HasColumnName("component_id");
            entity.Property(e => e.ComponentType)
                .HasMaxLength(255)
                .HasColumnName("component_type");
            entity.Property(e => e.Field)
                .HasMaxLength(255)
                .HasColumnName("field");
            entity.Property(e => e.HomeId).HasColumnName("home_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Order).HasColumnName("order");
        });

        modelBuilder.Entity<I18nLocale>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("i18n_locale");

            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedById).HasColumnName("created_by_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");
        });

        modelBuilder.Entity<I18nLocale1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("i18n_locales");

            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("orders");

            entity.Property(e => e.CardBrand)
                .HasMaxLength(255)
                .HasColumnName("card_brand");
            entity.Property(e => e.CardLast4)
                .HasMaxLength(255)
                .HasColumnName("card_last4");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.PaymentIntentId)
                .HasMaxLength(255)
                .HasColumnName("payment_intent_id");
            entity.Property(e => e.TotalInCents).HasColumnName("total_in_cents");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.User).HasColumnName("user");
        });

        modelBuilder.Entity<OrdersGame>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("orders__games");

            entity.Property(e => e.GameId).HasColumnName("game_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
        });

        modelBuilder.Entity<Platform>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("platforms");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreatedById).HasColumnName("created_by_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PublishedAt).HasColumnName("published_at");
            entity.Property(e => e.Slug)
                .HasMaxLength(255)
                .HasColumnName("slug");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");
        });

        modelBuilder.Entity<PlatformsGamesLink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("platforms_games_links");

            entity.Property(e => e.GameId).HasColumnName("game_id");
            entity.Property(e => e.PlatformId).HasColumnName("platform_id");
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("publishers");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreatedById).HasColumnName("created_by_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PublishedAt).HasColumnName("published_at");
            entity.Property(e => e.Slug)
                .HasMaxLength(255)
                .HasColumnName("slug");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");
        });

        modelBuilder.Entity<Recommended>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("recommendeds");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.PublishedAt).HasColumnName("published_at");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
        });

        modelBuilder.Entity<RecommendedsComponent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("recommendeds_components");

            entity.Property(e => e.ComponentId).HasColumnName("component_id");
            entity.Property(e => e.ComponentType)
                .HasMaxLength(255)
                .HasColumnName("component_type");
            entity.Property(e => e.Field)
                .HasMaxLength(255)
                .HasColumnName("field");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.RecommendedId).HasColumnName("recommended_id");
        });

        modelBuilder.Entity<StrapiAdministrator>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("strapi_administrator");

            entity.Property(e => e.Blocked).HasColumnName("blocked");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .HasColumnName("firstname");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .HasColumnName("lastname");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.PreferedLanguage)
                .HasMaxLength(255)
                .HasColumnName("preferedLanguage");
            entity.Property(e => e.RegistrationToken)
                .HasMaxLength(255)
                .HasColumnName("registrationToken");
            entity.Property(e => e.ResetPasswordToken)
                .HasMaxLength(255)
                .HasColumnName("resetPasswordToken");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        modelBuilder.Entity<StrapiApiToken>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("strapi_api_tokens");

            entity.Property(e => e.AccessKey)
                .HasMaxLength(255)
                .HasColumnName("access_key");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedById).HasColumnName("created_by_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");
        });

        modelBuilder.Entity<StrapiCoreStoreSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("strapi_core_store_settings");

            entity.Property(e => e.Environment)
                .HasMaxLength(255)
                .HasColumnName("environment");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Key)
                .HasMaxLength(255)
                .HasColumnName("key");
            entity.Property(e => e.Tag)
                .HasMaxLength(255)
                .HasColumnName("tag");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<StrapiDatabaseSchema>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("strapi_database_schema");

            entity.Property(e => e.Hash)
                .HasMaxLength(255)
                .HasColumnName("hash");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Schema)
                .HasColumnType("json")
                .HasColumnName("schema");
            entity.Property(e => e.Time)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("time");
        });

        modelBuilder.Entity<StrapiMigration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("strapi_migrations");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Time)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("time");
        });

        modelBuilder.Entity<StrapiPermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("strapi_permission");

            entity.Property(e => e.Action)
                .HasMaxLength(255)
                .HasColumnName("action");
            entity.Property(e => e.Conditions)
                .HasColumnType("jsonb")
                .HasColumnName("conditions");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("created_at");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Properties)
                .HasColumnType("jsonb")
                .HasColumnName("properties");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasColumnName("subject");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<StrapiRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("strapi_role");

            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<StrapiUsersRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("strapi_users_roles");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<StrapiWebhook>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("strapi_webhooks");

            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Events)
                .HasColumnType("jsonb")
                .HasColumnName("events");
            entity.Property(e => e.Headers)
                .HasColumnType("jsonb")
                .HasColumnName("headers");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Url).HasColumnName("url");
        });

        modelBuilder.Entity<UpPermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("up_permissions");

            entity.Property(e => e.Action)
                .HasMaxLength(255)
                .HasColumnName("action");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedById).HasColumnName("created_by_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");
        });

        modelBuilder.Entity<UpPermissionsRoleLink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("up_permissions_role_links");

            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
        });

        modelBuilder.Entity<UpRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("up_roles");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedById).HasColumnName("created_by_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");
        });

        modelBuilder.Entity<UpUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("up_users");

            entity.Property(e => e.Blocked).HasColumnName("blocked");
            entity.Property(e => e.ConfirmationToken)
                .HasMaxLength(255)
                .HasColumnName("confirmation_token");
            entity.Property(e => e.Confirmed).HasColumnName("confirmed");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedById).HasColumnName("created_by_id");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Provider)
                .HasMaxLength(255)
                .HasColumnName("provider");
            entity.Property(e => e.ResetPasswordToken)
                .HasMaxLength(255)
                .HasColumnName("reset_password_token");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        modelBuilder.Entity<UpUsersRoleLink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("up_users_role_links");

            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UploadFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("upload_file");

            entity.Property(e => e.AlternativeText)
                .HasMaxLength(255)
                .HasColumnName("alternativeText");
            entity.Property(e => e.Caption)
                .HasMaxLength(255)
                .HasColumnName("caption");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Ext)
                .HasMaxLength(255)
                .HasColumnName("ext");
            entity.Property(e => e.Formats)
                .HasColumnType("jsonb")
                .HasColumnName("formats");
            entity.Property(e => e.Hash)
                .HasMaxLength(255)
                .HasColumnName("hash");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Mime)
                .HasMaxLength(255)
                .HasColumnName("mime");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PreviewUrl)
                .HasMaxLength(255)
                .HasColumnName("previewUrl");
            entity.Property(e => e.Provider)
                .HasMaxLength(255)
                .HasColumnName("provider");
            entity.Property(e => e.ProviderMetadata)
                .HasColumnType("jsonb")
                .HasColumnName("provider_metadata");
            entity.Property(e => e.Size)
                .HasPrecision(10, 2)
                .HasColumnName("size");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
            entity.Property(e => e.Width).HasColumnName("width");
        });

        modelBuilder.Entity<UploadFileMorph>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("upload_file_morph");

            entity.Property(e => e.Field).HasColumnName("field");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.RelatedId).HasColumnName("related_id");
            entity.Property(e => e.RelatedType).HasColumnName("related_type");
            entity.Property(e => e.UploadFileId).HasColumnName("upload_file_id");
        });

        modelBuilder.Entity<UsersPermissionsPermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("users-permissions_permission");

            entity.Property(e => e.Action)
                .HasMaxLength(255)
                .HasColumnName("action");
            entity.Property(e => e.Controller)
                .HasMaxLength(255)
                .HasColumnName("controller");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Policy)
                .HasMaxLength(255)
                .HasColumnName("policy");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
        });

        modelBuilder.Entity<UsersPermissionsRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("users-permissions_role");

            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
        });

        modelBuilder.Entity<UsersPermissionsUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("users-permissions_user");

            entity.Property(e => e.Blocked).HasColumnName("blocked");
            entity.Property(e => e.ConfirmationToken)
                .HasMaxLength(255)
                .HasColumnName("confirmationToken");
            entity.Property(e => e.Confirmed).HasColumnName("confirmed");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Provider)
                .HasMaxLength(255)
                .HasColumnName("provider");
            entity.Property(e => e.ResetPasswordToken)
                .HasMaxLength(255)
                .HasColumnName("resetPasswordToken");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Wishlist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("wishlists");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.User).HasColumnName("user");
        });

        modelBuilder.Entity<WishlistsGame>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("wishlists__games");

            entity.Property(e => e.GameId).HasColumnName("game_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.WishlistId).HasColumnName("wishlist_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
