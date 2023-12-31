﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyItems.Backend;

#nullable disable

namespace MyItems.Backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230720222242_CascadeDelte")]
    partial class CascadeDelte
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyItems.Backend.Models.Collection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Collections");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5d0ca309-3b89-429d-9fbd-d1f30c235086"),
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            ImageUrl = "https://picsum.photos/640/480/?image=1021",
                            Name = "Refined Soft Hat",
                            Theme = "Awesome",
                            UserId = new Guid("1a0b5701-5fae-4a9e-b796-594b2a90c57f")
                        },
                        new
                        {
                            Id = new Guid("9f4c01e7-4ed1-4912-99f8-81ad9e621140"),
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            ImageUrl = "https://picsum.photos/640/480/?image=490",
                            Name = "Fantastic Steel Tuna",
                            Theme = "Handcrafted",
                            UserId = new Guid("a1fc9a76-a6c0-406f-9aae-2e2a8868e664")
                        },
                        new
                        {
                            Id = new Guid("74943104-fa1a-4451-893a-ddce7415937b"),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            ImageUrl = "https://picsum.photos/640/480/?image=807",
                            Name = "Licensed Plastic Chair",
                            Theme = "Handmade",
                            UserId = new Guid("32c96d0d-ae06-4f5b-9699-3742559dc878")
                        },
                        new
                        {
                            Id = new Guid("040bab10-aae1-41dc-8393-0cb7bbc04749"),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            ImageUrl = "https://picsum.photos/640/480/?image=160",
                            Name = "Gorgeous Steel Shoes",
                            Theme = "Awesome",
                            UserId = new Guid("9ce546d6-d68c-471b-aaf9-993f62761d0a")
                        },
                        new
                        {
                            Id = new Guid("eea0fb6d-95a9-439b-917f-2aa46ea4e0a4"),
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            ImageUrl = "https://picsum.photos/640/480/?image=822",
                            Name = "Incredible Frozen Pants",
                            Theme = "Incredible",
                            UserId = new Guid("a1fc9a76-a6c0-406f-9aae-2e2a8868e664")
                        },
                        new
                        {
                            Id = new Guid("1019ce56-587c-401c-b27f-46db35f448e9"),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            ImageUrl = "https://picsum.photos/640/480/?image=757",
                            Name = "Practical Soft Towels",
                            Theme = "Licensed",
                            UserId = new Guid("d94e2b69-6d43-4f2d-bf0a-a4fa3a8d748b")
                        },
                        new
                        {
                            Id = new Guid("e29fc38e-bd3a-4997-a113-0dda5a648d04"),
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            ImageUrl = "https://picsum.photos/640/480/?image=628",
                            Name = "Sleek Frozen Shoes",
                            Theme = "Practical",
                            UserId = new Guid("d94e2b69-6d43-4f2d-bf0a-a4fa3a8d748b")
                        },
                        new
                        {
                            Id = new Guid("358f506d-af6f-4eed-b8d5-39cf4b511769"),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            ImageUrl = "https://picsum.photos/640/480/?image=476",
                            Name = "Sleek Wooden Sausages",
                            Theme = "Rustic",
                            UserId = new Guid("a1fc9a76-a6c0-406f-9aae-2e2a8868e664")
                        },
                        new
                        {
                            Id = new Guid("6a3e72f2-24a0-4020-8212-98d19a5d221e"),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            ImageUrl = "https://picsum.photos/640/480/?image=813",
                            Name = "Handcrafted Steel Hat",
                            Theme = "Ergonomic",
                            UserId = new Guid("1a0b5701-5fae-4a9e-b796-594b2a90c57f")
                        },
                        new
                        {
                            Id = new Guid("49369176-effc-4d68-81ba-b35482ff8fb3"),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            ImageUrl = "https://picsum.photos/640/480/?image=317",
                            Name = "Practical Wooden Soap",
                            Theme = "Unbranded",
                            UserId = new Guid("0049aa2d-1986-4ecb-9a01-38f38255143e")
                        });
                });

            modelBuilder.Entity("MyItems.Backend.Models.CustomProperty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CollectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeProperty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CollectionId");

                    b.ToTable("CustomProperties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c15aa460-5e34-4f7a-96eb-f6bf5abf3596"),
                            CollectionId = new Guid("5d0ca309-3b89-429d-9fbd-d1f30c235086"),
                            Name = "Klocko, Brown and Auer",
                            TypeProperty = "boolean"
                        },
                        new
                        {
                            Id = new Guid("ef90839c-0d71-4625-960a-f0fd3b656d58"),
                            CollectionId = new Guid("9f4c01e7-4ed1-4912-99f8-81ad9e621140"),
                            Name = "Wiegand and Sons",
                            TypeProperty = "string"
                        },
                        new
                        {
                            Id = new Guid("4f27c86e-e760-4d7a-8d37-12ff4580c61d"),
                            CollectionId = new Guid("74943104-fa1a-4451-893a-ddce7415937b"),
                            Name = "Zieme, Lemke and Muller",
                            TypeProperty = "dateTime"
                        },
                        new
                        {
                            Id = new Guid("6ef38b8b-0a33-4270-bfb0-66bbd4f277aa"),
                            CollectionId = new Guid("040bab10-aae1-41dc-8393-0cb7bbc04749"),
                            Name = "Ward LLC",
                            TypeProperty = "string"
                        },
                        new
                        {
                            Id = new Guid("10b83954-8f3d-4915-b9f1-f3a8c1c1a91a"),
                            CollectionId = new Guid("eea0fb6d-95a9-439b-917f-2aa46ea4e0a4"),
                            Name = "Feest - Gottlieb",
                            TypeProperty = "string"
                        },
                        new
                        {
                            Id = new Guid("4fb8042d-d5a4-4d62-8675-abcac6b1df55"),
                            CollectionId = new Guid("1019ce56-587c-401c-b27f-46db35f448e9"),
                            Name = "Kessler, Friesen and Steuber",
                            TypeProperty = "string"
                        },
                        new
                        {
                            Id = new Guid("53780827-cf44-42ff-98b3-f3ea31bd9237"),
                            CollectionId = new Guid("e29fc38e-bd3a-4997-a113-0dda5a648d04"),
                            Name = "Lynch LLC",
                            TypeProperty = "boolean"
                        },
                        new
                        {
                            Id = new Guid("ad1f3a87-e310-420b-a6c3-a35a1f43965f"),
                            CollectionId = new Guid("358f506d-af6f-4eed-b8d5-39cf4b511769"),
                            Name = "Spencer, Dare and Hilpert",
                            TypeProperty = "string"
                        },
                        new
                        {
                            Id = new Guid("f21e8b34-636c-4283-99d7-755125cb89a0"),
                            CollectionId = new Guid("6a3e72f2-24a0-4020-8212-98d19a5d221e"),
                            Name = "Larson LLC",
                            TypeProperty = "number"
                        },
                        new
                        {
                            Id = new Guid("2dc520e2-7197-400b-a1c8-65320c86cb2d"),
                            CollectionId = new Guid("49369176-effc-4d68-81ba-b35482ff8fb3"),
                            Name = "D'Amore - Lehner",
                            TypeProperty = "dateTime"
                        });
                });

            modelBuilder.Entity("MyItems.Backend.Models.CustomPropertyValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomPropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomPropertyId");

                    b.HasIndex("ItemId");

                    b.ToTable("CustomPropertyValues");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a4bacfc1-5815-4c97-9aac-b2c23e761bd0"),
                            CustomPropertyId = new Guid("c15aa460-5e34-4f7a-96eb-f6bf5abf3596"),
                            ItemId = new Guid("d958da33-132f-40ff-a3d5-216c6cebdac3"),
                            Value = "Generic Metal Hat"
                        },
                        new
                        {
                            Id = new Guid("20ae2bfb-30f2-4a3c-b379-3f420232601c"),
                            CustomPropertyId = new Guid("ef90839c-0d71-4625-960a-f0fd3b656d58"),
                            ItemId = new Guid("4cde87f4-ccd9-4591-80b0-1aaa12906591"),
                            Value = "Refined Concrete Salad"
                        },
                        new
                        {
                            Id = new Guid("acafa747-8ac3-4044-87a4-6a6772f335aa"),
                            CustomPropertyId = new Guid("4f27c86e-e760-4d7a-8d37-12ff4580c61d"),
                            ItemId = new Guid("a68f0392-504c-46af-ae42-f0fc23185839"),
                            Value = "Intelligent Frozen Table"
                        },
                        new
                        {
                            Id = new Guid("a76042e3-27f5-4096-8ec8-842a118a782f"),
                            CustomPropertyId = new Guid("6ef38b8b-0a33-4270-bfb0-66bbd4f277aa"),
                            ItemId = new Guid("71ae6c3e-52db-4b08-8275-d4510601afe3"),
                            Value = "Tasty Frozen Towels"
                        },
                        new
                        {
                            Id = new Guid("d4f5ca0a-2241-4056-95fb-087088c2294d"),
                            CustomPropertyId = new Guid("10b83954-8f3d-4915-b9f1-f3a8c1c1a91a"),
                            ItemId = new Guid("4753e100-9671-413d-b217-1aaefdf0f0c1"),
                            Value = "Ergonomic Metal Chips"
                        },
                        new
                        {
                            Id = new Guid("f821dc07-7b16-4346-9910-4d56f2b60272"),
                            CustomPropertyId = new Guid("4fb8042d-d5a4-4d62-8675-abcac6b1df55"),
                            ItemId = new Guid("5c5b918d-6058-40bc-ab1b-27f5479087a3"),
                            Value = "Tasty Wooden Sausages"
                        },
                        new
                        {
                            Id = new Guid("1d3132c3-eaa0-4214-aeb9-a395e0895955"),
                            CustomPropertyId = new Guid("53780827-cf44-42ff-98b3-f3ea31bd9237"),
                            ItemId = new Guid("69583c50-be41-4beb-a94e-d02b7a827cc3"),
                            Value = "Refined Metal Pants"
                        },
                        new
                        {
                            Id = new Guid("a4d80817-85e3-4201-affe-df7e6a5a68bd"),
                            CustomPropertyId = new Guid("ad1f3a87-e310-420b-a6c3-a35a1f43965f"),
                            ItemId = new Guid("3c429245-2b27-42db-9fcb-d5546c036305"),
                            Value = "Gorgeous Granite Chicken"
                        },
                        new
                        {
                            Id = new Guid("814c7c76-7926-486a-a436-8322735b6020"),
                            CustomPropertyId = new Guid("f21e8b34-636c-4283-99d7-755125cb89a0"),
                            ItemId = new Guid("ea8cc440-f897-4f34-92ff-e6d059040cfb"),
                            Value = "Intelligent Plastic Towels"
                        },
                        new
                        {
                            Id = new Guid("6b780fd2-acc7-496b-8310-aca4531147af"),
                            CustomPropertyId = new Guid("2dc520e2-7197-400b-a1c8-65320c86cb2d"),
                            ItemId = new Guid("797ceebe-3836-49bf-a5b3-a6b5175552fa"),
                            Value = "Fantastic Rubber Pizza"
                        });
                });

            modelBuilder.Entity("MyItems.Backend.Models.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CollectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CollectionId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d958da33-132f-40ff-a3d5-216c6cebdac3"),
                            CollectionId = new Guid("5d0ca309-3b89-429d-9fbd-d1f30c235086"),
                            CreatedAt = new DateTime(2022, 10, 11, 4, 18, 18, 576, DateTimeKind.Local).AddTicks(8727),
                            Name = "Handcrafted Plastic Fish"
                        },
                        new
                        {
                            Id = new Guid("4cde87f4-ccd9-4591-80b0-1aaa12906591"),
                            CollectionId = new Guid("9f4c01e7-4ed1-4912-99f8-81ad9e621140"),
                            CreatedAt = new DateTime(2023, 7, 1, 5, 48, 11, 498, DateTimeKind.Local).AddTicks(4886),
                            Name = "Refined Frozen Towels"
                        },
                        new
                        {
                            Id = new Guid("a68f0392-504c-46af-ae42-f0fc23185839"),
                            CollectionId = new Guid("74943104-fa1a-4451-893a-ddce7415937b"),
                            CreatedAt = new DateTime(2023, 5, 30, 5, 55, 54, 380, DateTimeKind.Local).AddTicks(6825),
                            Name = "Unbranded Frozen Chicken"
                        },
                        new
                        {
                            Id = new Guid("71ae6c3e-52db-4b08-8275-d4510601afe3"),
                            CollectionId = new Guid("040bab10-aae1-41dc-8393-0cb7bbc04749"),
                            CreatedAt = new DateTime(2022, 8, 26, 19, 6, 51, 471, DateTimeKind.Local).AddTicks(3196),
                            Name = "Generic Metal Bacon"
                        },
                        new
                        {
                            Id = new Guid("4753e100-9671-413d-b217-1aaefdf0f0c1"),
                            CollectionId = new Guid("eea0fb6d-95a9-439b-917f-2aa46ea4e0a4"),
                            CreatedAt = new DateTime(2023, 3, 30, 23, 27, 44, 172, DateTimeKind.Local).AddTicks(1984),
                            Name = "Ergonomic Fresh Fish"
                        },
                        new
                        {
                            Id = new Guid("5c5b918d-6058-40bc-ab1b-27f5479087a3"),
                            CollectionId = new Guid("1019ce56-587c-401c-b27f-46db35f448e9"),
                            CreatedAt = new DateTime(2023, 1, 28, 10, 26, 49, 809, DateTimeKind.Local).AddTicks(924),
                            Name = "Handmade Concrete Bacon"
                        },
                        new
                        {
                            Id = new Guid("69583c50-be41-4beb-a94e-d02b7a827cc3"),
                            CollectionId = new Guid("e29fc38e-bd3a-4997-a113-0dda5a648d04"),
                            CreatedAt = new DateTime(2023, 6, 6, 23, 4, 51, 205, DateTimeKind.Local).AddTicks(1917),
                            Name = "Incredible Rubber Gloves"
                        },
                        new
                        {
                            Id = new Guid("3c429245-2b27-42db-9fcb-d5546c036305"),
                            CollectionId = new Guid("358f506d-af6f-4eed-b8d5-39cf4b511769"),
                            CreatedAt = new DateTime(2022, 11, 24, 1, 54, 42, 29, DateTimeKind.Local).AddTicks(6447),
                            Name = "Unbranded Frozen Shoes"
                        },
                        new
                        {
                            Id = new Guid("ea8cc440-f897-4f34-92ff-e6d059040cfb"),
                            CollectionId = new Guid("6a3e72f2-24a0-4020-8212-98d19a5d221e"),
                            CreatedAt = new DateTime(2022, 12, 22, 0, 44, 13, 654, DateTimeKind.Local).AddTicks(2836),
                            Name = "Ergonomic Concrete Shoes"
                        },
                        new
                        {
                            Id = new Guid("797ceebe-3836-49bf-a5b3-a6b5175552fa"),
                            CollectionId = new Guid("49369176-effc-4d68-81ba-b35482ff8fb3"),
                            CreatedAt = new DateTime(2023, 3, 29, 20, 0, 15, 429, DateTimeKind.Local).AddTicks(8128),
                            Name = "Ergonomic Wooden Keyboard"
                        });
                });

            modelBuilder.Entity("MyItems.Backend.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7d441a99-aba1-4565-a237-5b6cf66411a1"),
                            Email = "otabek.r743@gmail.com",
                            FirstName = "Admin",
                            IsAdmin = true,
                            IsBlocked = false,
                            LastName = "Admin",
                            PasswordHash = "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw=="
                        },
                        new
                        {
                            Id = new Guid("0049aa2d-1986-4ecb-9a01-38f38255143e"),
                            Email = "Thelma48@gmail.com",
                            FirstName = "Thelma",
                            IsAdmin = false,
                            IsBlocked = false,
                            LastName = "Crooks",
                            PasswordHash = ""
                        },
                        new
                        {
                            Id = new Guid("bd9d2221-58e7-4839-9160-26368be7f668"),
                            Email = "Ann.Kerluke72@gmail.com",
                            FirstName = "Ann",
                            IsAdmin = false,
                            IsBlocked = false,
                            LastName = "Kerluke",
                            PasswordHash = ""
                        },
                        new
                        {
                            Id = new Guid("96e4dde2-c912-4855-9dcd-907f92054908"),
                            Email = "Wallace76@yahoo.com",
                            FirstName = "Wallace",
                            IsAdmin = false,
                            IsBlocked = false,
                            LastName = "Toy",
                            PasswordHash = ""
                        },
                        new
                        {
                            Id = new Guid("32c96d0d-ae06-4f5b-9699-3742559dc878"),
                            Email = "Brett94@hotmail.com",
                            FirstName = "Brett",
                            IsAdmin = false,
                            IsBlocked = false,
                            LastName = "Windler",
                            PasswordHash = ""
                        },
                        new
                        {
                            Id = new Guid("9ce546d6-d68c-471b-aaf9-993f62761d0a"),
                            Email = "Sabrina22@hotmail.com",
                            FirstName = "Sabrina",
                            IsAdmin = false,
                            IsBlocked = false,
                            LastName = "Nicolas",
                            PasswordHash = ""
                        },
                        new
                        {
                            Id = new Guid("d94e2b69-6d43-4f2d-bf0a-a4fa3a8d748b"),
                            Email = "Steven.Casper1@yahoo.com",
                            FirstName = "Steven",
                            IsAdmin = false,
                            IsBlocked = false,
                            LastName = "Casper",
                            PasswordHash = ""
                        },
                        new
                        {
                            Id = new Guid("a1fc9a76-a6c0-406f-9aae-2e2a8868e664"),
                            Email = "Homer91@gmail.com",
                            FirstName = "Homer",
                            IsAdmin = false,
                            IsBlocked = false,
                            LastName = "Feest",
                            PasswordHash = ""
                        },
                        new
                        {
                            Id = new Guid("ad6484ff-376f-4143-9b0c-90929afe8734"),
                            Email = "Shannon_Lemke@hotmail.com",
                            FirstName = "Shannon",
                            IsAdmin = false,
                            IsBlocked = false,
                            LastName = "Lemke",
                            PasswordHash = ""
                        },
                        new
                        {
                            Id = new Guid("7ea14d43-3f78-413a-8e41-8ca7793fe50e"),
                            Email = "Randy_Bradtke3@yahoo.com",
                            FirstName = "Randy",
                            IsAdmin = false,
                            IsBlocked = false,
                            LastName = "Bradtke",
                            PasswordHash = ""
                        },
                        new
                        {
                            Id = new Guid("1a0b5701-5fae-4a9e-b796-594b2a90c57f"),
                            Email = "Raquel.Ritchie@hotmail.com",
                            FirstName = "Raquel",
                            IsAdmin = false,
                            IsBlocked = false,
                            LastName = "Ritchie",
                            PasswordHash = ""
                        });
                });

            modelBuilder.Entity("MyItems.Backend.Models.Collection", b =>
                {
                    b.HasOne("MyItems.Backend.Models.User", "User")
                        .WithMany("Collections")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyItems.Backend.Models.CustomProperty", b =>
                {
                    b.HasOne("MyItems.Backend.Models.Collection", "Collection")
                        .WithMany("CustomProperties")
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collection");
                });

            modelBuilder.Entity("MyItems.Backend.Models.CustomPropertyValue", b =>
                {
                    b.HasOne("MyItems.Backend.Models.CustomProperty", "CustomProperty")
                        .WithMany("CustomPropertyValues")
                        .HasForeignKey("CustomPropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyItems.Backend.Models.Item", "Item")
                        .WithMany("CustomPropertyValues")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CustomProperty");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("MyItems.Backend.Models.Item", b =>
                {
                    b.HasOne("MyItems.Backend.Models.Collection", "Collection")
                        .WithMany("Items")
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collection");
                });

            modelBuilder.Entity("MyItems.Backend.Models.Collection", b =>
                {
                    b.Navigation("CustomProperties");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("MyItems.Backend.Models.CustomProperty", b =>
                {
                    b.Navigation("CustomPropertyValues");
                });

            modelBuilder.Entity("MyItems.Backend.Models.Item", b =>
                {
                    b.Navigation("CustomPropertyValues");
                });

            modelBuilder.Entity("MyItems.Backend.Models.User", b =>
                {
                    b.Navigation("Collections");
                });
#pragma warning restore 612, 618
        }
    }
}
