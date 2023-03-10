// <auto-generated />
using System;
using Drugovich.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Drugovich.Data.Migrations
{
    [DbContext(typeof(DrugovichContext))]
    partial class DrugovichContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Drugovich.Domain.Entities.ClienteEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("CreatAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataFundacao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GrupoRef")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.HasIndex("GrupoRef");

                    b.ToTable("Cliente", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CNPJ = "95195019000147",
                            Codigo = "CLiente0001",
                            CreatAt = new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(6008),
                            DataFundacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GrupoRef = 1,
                            Nome = "Cliente 1"
                        },
                        new
                        {
                            Id = 2,
                            CNPJ = "43514821000159",
                            Codigo = "CLiente0002",
                            CreatAt = new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(6015),
                            DataFundacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GrupoRef = 2,
                            Nome = "Cliente 2"
                        },
                        new
                        {
                            Id = 3,
                            CNPJ = "15693178000132",
                            Codigo = "CLiente0003",
                            CreatAt = new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(6021),
                            DataFundacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GrupoRef = 3,
                            Nome = "Cliente 3"
                        });
                });

            modelBuilder.Entity("Drugovich.Domain.Entities.GerenteEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("CreatAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Nivel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Gerente", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Codigo = "GR0001",
                            CreatAt = new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(5943),
                            Email = "gerentenivel1@drugovich.com",
                            Nivel = 0,
                            Nome = "Gerente nivel Um"
                        },
                        new
                        {
                            Id = 2,
                            Codigo = "GR0002",
                            CreatAt = new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(5974),
                            Email = "gerentenivel2@drugovich.com",
                            Nivel = 1,
                            Nome = "Gerente nivel Dois"
                        });
                });

            modelBuilder.Entity("Drugovich.Domain.Entities.GrupoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("CreatAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.ToTable("Grupo", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Codigo = "Grupo000A",
                            CreatAt = new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(5986),
                            Nome = "Grupo A"
                        },
                        new
                        {
                            Id = 2,
                            Codigo = "Grupo000B",
                            CreatAt = new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(5994),
                            Nome = "Grupo B"
                        },
                        new
                        {
                            Id = 3,
                            Codigo = "Grupo000C",
                            CreatAt = new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(6000),
                            Nome = "Grupo C"
                        });
                });

            modelBuilder.Entity("Drugovich.Domain.Entities.UsuarioEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("CreatAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GerenteRef")
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("GerenteRef")
                        .IsUnique();

                    b.HasIndex("Login")
                        .IsUnique();

                    b.ToTable("Usuario", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            CreatAt = new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(6032),
                            GerenteRef = 1,
                            Login = "user1",
                            Senha = "0a84e19c7d8defe8"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            CreatAt = new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(6040),
                            GerenteRef = 2,
                            Login = "user2",
                            Senha = "0a84e19c7d8defe8"
                        });
                });

            modelBuilder.Entity("Drugovich.Domain.Entities.ClienteEntity", b =>
                {
                    b.HasOne("Drugovich.Domain.Entities.GrupoEntity", "Grupo")
                        .WithMany("Clientes")
                        .HasForeignKey("GrupoRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grupo");
                });

            modelBuilder.Entity("Drugovich.Domain.Entities.UsuarioEntity", b =>
                {
                    b.HasOne("Drugovich.Domain.Entities.GerenteEntity", "Gerente")
                        .WithOne("Usuario")
                        .HasForeignKey("Drugovich.Domain.Entities.UsuarioEntity", "GerenteRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gerente");
                });

            modelBuilder.Entity("Drugovich.Domain.Entities.GerenteEntity", b =>
                {
                    b.Navigation("Usuario")
                        .IsRequired();
                });

            modelBuilder.Entity("Drugovich.Domain.Entities.GrupoEntity", b =>
                {
                    b.Navigation("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
