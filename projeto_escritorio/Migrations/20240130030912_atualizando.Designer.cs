﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projeto_escritorio.Data;

#nullable disable

namespace projeto_escritorio.Migrations
{
    [DbContext(typeof(ClienteContext))]
    [Migration("20240130030912_atualizando")]
    partial class atualizando
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("projeto_escritorio.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("projeto_escritorio.Models.Divida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("LojaId")
                        .HasColumnType("int");

                    b.Property<float>("valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("LojaId");

                    b.ToTable("Dividas");
                });

            modelBuilder.Entity("projeto_escritorio.Models.Loja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("varchar(18)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Lojas");
                });

            modelBuilder.Entity("projeto_escritorio.Models.Divida", b =>
                {
                    b.HasOne("projeto_escritorio.Models.Cliente", "Cliente")
                        .WithMany("Dividas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("projeto_escritorio.Models.Loja", "Loja")
                        .WithMany("Dividas")
                        .HasForeignKey("LojaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Loja");
                });

            modelBuilder.Entity("projeto_escritorio.Models.Cliente", b =>
                {
                    b.Navigation("Dividas");
                });

            modelBuilder.Entity("projeto_escritorio.Models.Loja", b =>
                {
                    b.Navigation("Dividas");
                });
#pragma warning restore 612, 618
        }
    }
}
