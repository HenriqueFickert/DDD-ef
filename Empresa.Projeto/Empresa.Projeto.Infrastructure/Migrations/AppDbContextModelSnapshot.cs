﻿// <auto-generated />
using System;
using Empresa.Projeto.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Empresa.Projeto.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CapituloUnidade", b =>
                {
                    b.Property<long>("CapitulosId")
                        .HasColumnType("bigint");

                    b.Property<long>("UnidadesId")
                        .HasColumnType("bigint");

                    b.HasKey("CapitulosId", "UnidadesId");

                    b.HasIndex("UnidadesId");

                    b.ToTable("CapituloUnidade");
                });

            modelBuilder.Entity("Empresa.Projeto.Domain.Entitys.AlunoB64", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("CaminhoAbsoluto")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("CaminhoAbsoluto");

                    b.Property<string>("CaminhoRelativo")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("CaminhoRelativo");

                    b.Property<DateTime?>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdGuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Nome");

                    b.Property<string>("Sobrenome")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Sobrenome");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("AlunoB64");
                });

            modelBuilder.Entity("Empresa.Projeto.Domain.Entitys.Capitulo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumeroCapitulo")
                        .HasMaxLength(1000)
                        .HasColumnType("int")
                        .HasColumnName("NumeroCapitulo");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("Capitulo");
                });

            modelBuilder.Entity("Empresa.Projeto.Domain.Entitys.ClienteForm", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("CaminhoAbsoluto")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("CaminhoAbsoluto");

                    b.Property<string>("CaminhoRelativo")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("CaminhoRelativo");

                    b.Property<string>("ContentType")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("ContentType");

                    b.Property<DateTime?>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExtensaoArquivo")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("ExtensaoArquivo");

                    b.Property<Guid>("IdGuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Nome");

                    b.Property<string>("NomeArquivoOriginal")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("NomeArquivoOriginal");

                    b.Property<string>("Sobrenome")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Sobrenome");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("Status");

                    b.Property<string>("TamanhoEmBytes")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("TamanhoEmBytes");

                    b.HasKey("Id");

                    b.ToTable("ClienteForm");
                });

            modelBuilder.Entity("Empresa.Projeto.Domain.Entitys.Especialidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Descricao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Nome");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("Especialidade");
                });

            modelBuilder.Entity("Empresa.Projeto.Domain.Entitys.Permissao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Descricao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Nome");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("Permissao");
                });

            modelBuilder.Entity("Empresa.Projeto.Domain.Entitys.Progresso", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CapituloId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("Status");

                    b.Property<int>("TotalProgresso")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("TotalProgresso");

                    b.HasKey("Id");

                    b.HasIndex("CapituloId");

                    b.ToTable("Progresso");
                });

            modelBuilder.Entity("Empresa.Projeto.Domain.Entitys.Unidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumeroUnidade")
                        .HasMaxLength(1000)
                        .HasColumnType("int")
                        .HasColumnName("NumeroCapitulo");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("Unidade");
                });

            modelBuilder.Entity("Empresa.Projeto.Domain.Entitys.UploadB64", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("CaminhoAbsoluto")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("CaminhoAbsoluto");

                    b.Property<string>("CaminhoRelativo")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("CaminhoRelativo");

                    b.Property<DateTime?>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdGuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("UploadB64");
                });

            modelBuilder.Entity("Empresa.Projeto.Domain.Entitys.UploadForm", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("CaminhoAbsoluto")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("CaminhoAbsoluto");

                    b.Property<string>("CaminhoRelativo")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("CaminhoRelativo");

                    b.Property<string>("ContentType")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("ContentType");

                    b.Property<DateTime?>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExtensaoArquivo")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("ExtensaoArquivo");

                    b.Property<Guid>("IdGuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("NomeArquivoOriginal")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("NomeArquivoOriginal");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("Status");

                    b.Property<string>("TamanhoEmBytes")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("TamanhoEmBytes");

                    b.HasKey("Id");

                    b.ToTable("UploadForm");
                });

            modelBuilder.Entity("Empresa.Projeto.Domain.Entitys.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Apelido")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Apelido");

                    b.Property<DateTime?>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Nome");

                    b.Property<long>("PermissaoId")
                        .HasColumnType("bigint")
                        .HasColumnName("PermissaoId");

                    b.Property<string>("Senha")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("Senha");

                    b.Property<string>("Sobrenome")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Sobrenome");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("Status");

                    b.Property<DateTime?>("UltimoAcessoEm")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PermissaoId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("EspecialidadeUsuario", b =>
                {
                    b.Property<long>("EspecialidadesId")
                        .HasColumnType("bigint");

                    b.Property<long>("UsuariosId")
                        .HasColumnType("bigint");

                    b.HasKey("EspecialidadesId", "UsuariosId");

                    b.HasIndex("UsuariosId");

                    b.ToTable("EspecialidadeUsuario");
                });

            modelBuilder.Entity("CapituloUnidade", b =>
                {
                    b.HasOne("Empresa.Projeto.Domain.Entitys.Capitulo", null)
                        .WithMany()
                        .HasForeignKey("CapitulosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Empresa.Projeto.Domain.Entitys.Unidade", null)
                        .WithMany()
                        .HasForeignKey("UnidadesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Empresa.Projeto.Domain.Entitys.Progresso", b =>
                {
                    b.HasOne("Empresa.Projeto.Domain.Entitys.Capitulo", "Capitulo")
                        .WithMany("Progressos")
                        .HasForeignKey("CapituloId");

                    b.Navigation("Capitulo");
                });

            modelBuilder.Entity("Empresa.Projeto.Domain.Entitys.Usuario", b =>
                {
                    b.HasOne("Empresa.Projeto.Domain.Entitys.Permissao", "Permissao")
                        .WithMany("Usuarios")
                        .HasForeignKey("PermissaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permissao");
                });

            modelBuilder.Entity("EspecialidadeUsuario", b =>
                {
                    b.HasOne("Empresa.Projeto.Domain.Entitys.Especialidade", null)
                        .WithMany()
                        .HasForeignKey("EspecialidadesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Empresa.Projeto.Domain.Entitys.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuariosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Empresa.Projeto.Domain.Entitys.Capitulo", b =>
                {
                    b.Navigation("Progressos");
                });

            modelBuilder.Entity("Empresa.Projeto.Domain.Entitys.Permissao", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}