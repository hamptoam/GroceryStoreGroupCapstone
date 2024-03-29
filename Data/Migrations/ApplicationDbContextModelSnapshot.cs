﻿// <auto-generated />
using System;
using GroceryStoreRewards.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroceryStoreRewards.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GroceryStoreRewards.Models.ConvertAmounts", b =>
                {
                    b.Property<string>("type")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("answer");

                    b.Property<int>("sourceAmount");

                    b.Property<string>("sourceUnit");

                    b.Property<int>("targetAmount");

                    b.Property<string>("targetUnit");

                    b.HasKey("type");

                    b.ToTable("ConvertAmounts");
                });

            modelBuilder.Entity("GroceryStoreRewards.Models.Customer", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<int?>("Ingredients");

                    b.Property<string>("LastName");

                    b.Property<string>("Preference");

                    b.Property<bool>("customerLikes");

                    b.HasKey("UserId");

                    b.HasIndex("Ingredients")
                        .IsUnique()
                        .HasFilter("[Ingredients] IS NOT NULL");

                    b.ToTable("Customer");
                });


            modelBuilder.Entity("GroceryStoreRewards.Models.CustomerRecipes", b =>
                {
                    b.Property<int>("RecipeId");

                    b.Property<string>("CustomerId");

                    b.HasKey("RecipeId", "CustomerId");

                    b.HasAlternateKey("RecipeId");

                    b.HasIndex("CustomerId");

                    b.ToTable("customerRecipes");
                });


            modelBuilder.Entity("GroceryStoreRewards.Models.Ingredients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");


                    b.Property<string>("WeightValue");

                    b.Property<int>("unit");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });


            modelBuilder.Entity("GroceryStoreRewards.Models.Likes", b =>
                {
                    b.Property<bool>("customerLikes");

                    b.HasKey("customerLikes");

                    b.ToTable("Likes");
                });


            modelBuilder.Entity("GroceryStoreRewards.Models.RecipeIngredient", b =>
                {
                    b.Property<string>("ingredient")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("count");

                    b.Property<string>("measurementType");

                    b.HasKey("ingredient");

                    b.ToTable("RecipeIngredient");
                });

            modelBuilder.Entity("GroceryStoreRewards.Models.Recipes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Customer");

                    b.Property<double>("ingredientAmounts");

                    b.Property<string>("ingredients");

                    b.HasKey("Id");

                    b.HasIndex("Customer");

                    b.ToTable("Recipes");

                    b.HasData(
                        new { Id = 1, ingredientAmounts = 2.0, ingredients = "pasta" },
                        new { Id = 2, ingredientAmounts = 2.0, ingredients = "chicken" },
                        new { Id = 3, ingredientAmounts = 4.0, ingredients = "chickenBreast" },
                        new { Id = 4, ingredientAmounts = 3.0, ingredients = "leanChicken" },
                        new { Id = 5, ingredientAmounts = 10.0, ingredients = "ChickenBroth" },
                        new { Id = 6, ingredientAmounts = 20.0, ingredients = "CondensedChicken" },
                        new { Id = 7, ingredientAmounts = 5.0, ingredients = "chickenSoup" },
                        new { Id = 8, ingredientAmounts = 4.0, ingredients = "breadedChicken" }
                    );
                });

            modelBuilder.Entity("GroceryStoreRewards.Models.ShoppingList", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("Ingredients");

                    b.HasKey("UserId");

                    b.ToTable("ShoppingLists");
                });

            modelBuilder.Entity("GroceryStoreRewards.Models.SummarizeRecipeAPI", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("summary");

                    b.Property<string>("title");

                    b.HasKey("id");

                    b.ToTable("SummarizeRecipeAPI");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GroceryStoreRewards.Models.Customer", b =>
                {
                    b.HasOne("GroceryStoreRewards.Models.Ingredients", "ingredients")
                        .WithOne("Customer")
                        .HasForeignKey("GroceryStoreRewards.Models.Customer", "Ingredients");
                });

            modelBuilder.Entity("GroceryStoreRewards.Models.CustomerRecipes", b =>
                {
                    b.HasOne("GroceryStoreRewards.Models.Customer", "customer")
                        .WithMany("customerRecipes")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GroceryStoreRewards.Models.Recipes", "Recipes")
                        .WithMany("customerRecipes")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GroceryStoreRewards.Models.Recipes", b =>
                {
                    b.HasOne("GroceryStoreRewards.Models.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("Customer");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
