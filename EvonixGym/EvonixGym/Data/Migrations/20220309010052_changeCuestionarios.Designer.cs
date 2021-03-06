// <auto-generated />
using System;
using EvonixGym.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EvonixGym.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220309010052_changeCuestionarios")]
    partial class changeCuestionarios
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EvonixGym.Data.Modelos.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"), 1L, 1);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Fechanacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdEntrenamiento")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Imageperfil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provincia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.Entrenador", b =>
                {
                    b.Property<int>("IdEntrenador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEntrenador"), 1L, 1);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Baja")
                        .HasColumnType("bit");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaAltaContrato")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FechaProxPago")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEntrenador");

                    b.ToTable("Entrenadores");
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.Rol", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ae20379c-fe59-44c7-9c5f-23c502a5e225",
                            ConcurrencyStamp = "5efe59cc-1b42-4315-8346-3ac9537f16c5",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "195d2aa0-d998-4e8d-bb9e-a23d7baab3f6",
                            ConcurrencyStamp = "4b8d91d6-7b31-45bc-8ea3-865f1ef05662",
                            Name = "Entrenador",
                            NormalizedName = "ENTRENADOR"
                        },
                        new
                        {
                            Id = "95b53714-8125-44e3-8d69-392bd910f0dd",
                            ConcurrencyStamp = "5eea21ac-c056-459d-99e1-abea5ebacd2a",
                            Name = "Cliente",
                            NormalizedName = "CLIENTE"
                        });
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "4c52f832-f912-4f9b-a4e9-92975a0d96d2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9e7cd035-ff8c-4e36-a46a-f988de31e856",
                            Email = "usuadmin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USUADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERUSUARIO",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "91033d89-2c7d-42be-ae71-991d6a20ee90",
                            TwoFactorEnabled = false,
                            UserName = "SuperUsuario"
                        },
                        new
                        {
                            Id = "40cdef9b-92f9-401e-a05c-128430c1e0f9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "91b387c1-a514-4d07-92f8-0b179523a135",
                            Email = "entrenador@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ENTRENADOR@GMAIL.COM",
                            NormalizedUserName = "JUAN",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fcfa62e8-d093-4650-ab75-c3a507429080",
                            TwoFactorEnabled = false,
                            UserName = "Juan"
                        },
                        new
                        {
                            Id = "555a7de8-140a-46f8-99dc-8adf7a0305d3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "971cd602-8e3f-4bf7-bc67-7cdfa5aa4453",
                            Email = "cliente@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "CLIENTE@GMAIL.COM",
                            NormalizedUserName = "FRAN",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a8c22b00-9cc7-4f62-bf8d-1b8ece8e6a49",
                            TwoFactorEnabled = false,
                            UserName = "fran"
                        });
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.UsuarioClientes", b =>
                {
                    b.Property<int>("UsuarioClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioClienteID"), 1L, 1);

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UsuarioClienteID");

                    b.HasIndex("IdCliente");

                    b.HasIndex("UserId");

                    b.ToTable("UsuarioClientes");
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.UsuarioEntrenadores", b =>
                {
                    b.Property<int>("UsuarioEntrenadorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioEntrenadorID"), 1L, 1);

                    b.Property<int>("IdEntrenador")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UsuarioEntrenadorID");

                    b.HasIndex("IdEntrenador");

                    b.HasIndex("UserId");

                    b.ToTable("UsuarioEntrenadores");
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.UsuarioRol", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "4c52f832-f912-4f9b-a4e9-92975a0d96d2",
                            RoleId = "ae20379c-fe59-44c7-9c5f-23c502a5e225"
                        },
                        new
                        {
                            UserId = "40cdef9b-92f9-401e-a05c-128430c1e0f9",
                            RoleId = "195d2aa0-d998-4e8d-bb9e-a23d7baab3f6"
                        },
                        new
                        {
                            UserId = "555a7de8-140a-46f8-99dc-8adf7a0305d3",
                            RoleId = "95b53714-8125-44e3-8d69-392bd910f0dd"
                        });
                });

            modelBuilder.Entity("EvonixGym.Modelos.Archivo", b =>
                {
                    b.Property<int>("IdArchivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdArchivo"), 1L, 1);

                    b.Property<int?>("IdPregunta")
                        .HasColumnType("int");

                    b.Property<int?>("IdPreguntas")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkVideo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PreguntaIdPreguntas")
                        .HasColumnType("int");

                    b.Property<int?>("PreguntaIdPreguntas1")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdArchivo");

                    b.HasIndex("PreguntaIdPreguntas");

                    b.HasIndex("PreguntaIdPreguntas1");

                    b.ToTable("Archivos");
                });

            modelBuilder.Entity("EvonixGym.Modelos.Archivoresp", b =>
                {
                    b.Property<int>("IdArchivoResp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdArchivoResp"), 1L, 1);

                    b.Property<int?>("IdPregunta")
                        .HasColumnType("int");

                    b.Property<int?>("IdRespuesta")
                        .HasColumnType("int");

                    b.Property<int?>("IdRespuestaNavigationIdRespuesta")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkVideo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdArchivoResp");

                    b.HasIndex("IdRespuestaNavigationIdRespuesta");

                    b.ToTable("archivoresps");
                });

            modelBuilder.Entity("EvonixGym.Modelos.ComposicionCorporal", b =>
                {
                    b.Property<int>("IdComposicion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdComposicion"), 1L, 1);

                    b.Property<int?>("CueIdCuestionario")
                        .HasColumnType("int");

                    b.Property<int?>("CueIdCuestionarioNavigationIdCuestionario")
                        .HasColumnType("int");

                    b.Property<string>("IdCuestionario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdComposicion");

                    b.HasIndex("CueIdCuestionarioNavigationIdCuestionario");

                    b.ToTable("composicionCorporals");
                });

            modelBuilder.Entity("EvonixGym.Modelos.ComposicionCorporalClient", b =>
                {
                    b.Property<int>("IdCcCliente")
                        .HasColumnType("int");

                    b.Property<int?>("IdComposicion")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("IdCcCliente");

                    b.HasIndex("IdComposicion");

                    b.ToTable("composicionCorporalClients");
                });

            modelBuilder.Entity("EvonixGym.Modelos.Cuestionario", b =>
                {
                    b.Property<int>("IdCuestionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCuestionario"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdEntrenador")
                        .HasColumnType("int");

                    b.Property<int?>("IdEntrenadorNavigationIdEntrenador")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCuestionario");

                    b.HasIndex("IdEntrenadorNavigationIdEntrenador");

                    b.ToTable("Cuestionarios");
                });

            modelBuilder.Entity("EvonixGym.Modelos.CuestionarioClientes", b =>
                {
                    b.Property<int>("IdCuestionarioClientes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCuestionarioClientes"), 1L, 1);

                    b.Property<int?>("CuestionarioIdCuestionario")
                        .HasColumnType("int");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int?>("IdCuestionario")
                        .HasColumnType("int");

                    b.HasKey("IdCuestionarioClientes");

                    b.HasIndex("CuestionarioIdCuestionario");

                    b.ToTable("CuestionarioClientes");
                });

            modelBuilder.Entity("EvonixGym.Modelos.Perimetro", b =>
                {
                    b.Property<int>("IdPerimetro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPerimetro"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnidadDeMedida")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPerimetro");

                    b.ToTable("Perimetros");
                });

            modelBuilder.Entity("EvonixGym.Modelos.PerimetroDelCliente", b =>
                {
                    b.Property<int>("IdPerimetroCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPerimetroCliente"), 1L, 1);

                    b.Property<int?>("IdCliente")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("IdPerimetro")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("MedidaActual")
                        .HasColumnType("int");

                    b.Property<double?>("MedidaDeseada")
                        .HasColumnType("float");

                    b.HasKey("IdPerimetroCliente");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdPerimetro");

                    b.ToTable("perimetroDelClientes");
                });

            modelBuilder.Entity("EvonixGym.Modelos.PerimetrosCuestionario", b =>
                {
                    b.Property<int>("IdPerimetrosCuest")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPerimetrosCuest"), 1L, 1);

                    b.Property<int?>("IdCuestionario")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("IdPerimetro")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("IdPerimetrosCuest");

                    b.HasIndex("IdCuestionario");

                    b.HasIndex("IdPerimetro");

                    b.ToTable("PerimetrosCuestionarios");
                });

            modelBuilder.Entity("EvonixGym.Modelos.Pregunta", b =>
                {
                    b.Property<int>("IdPreguntas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPreguntas"), 1L, 1);

                    b.Property<int?>("IdCuestionario")
                        .HasColumnType("int");

                    b.Property<int?>("IdCuestionarioNavigationIdCuestionario")
                        .HasColumnType("int");

                    b.Property<string>("Pregunta1")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPreguntas");

                    b.HasIndex("IdCuestionarioNavigationIdCuestionario");

                    b.ToTable("Preguntas");
                });

            modelBuilder.Entity("EvonixGym.Modelos.Respuestum", b =>
                {
                    b.Property<int>("IdRespuesta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRespuesta"), 1L, 1);

                    b.Property<int?>("IdPregunta")
                        .HasColumnType("int");

                    b.Property<int?>("IdPreguntas")
                        .HasColumnType("int");

                    b.Property<int?>("IdPreguntasNavigationIdPreguntas")
                        .HasColumnType("int");

                    b.Property<string>("Respuesta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRespuesta");

                    b.HasIndex("IdPreguntasNavigationIdPreguntas");

                    b.ToTable("Respuesta");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.UsuarioClientes", b =>
                {
                    b.HasOne("EvonixGym.Data.Modelos.Cliente", "Cliente")
                        .WithMany("UsuarioClientes")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvonixGym.Data.Modelos.Usuario", "Usuario")
                        .WithMany("UsuarioClientes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.UsuarioEntrenadores", b =>
                {
                    b.HasOne("EvonixGym.Data.Modelos.Entrenador", "Entrenador")
                        .WithMany("UsuarioEntrenadores")
                        .HasForeignKey("IdEntrenador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvonixGym.Data.Modelos.Usuario", "Usuario")
                        .WithMany("UsuarioEntrenadores")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entrenador");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.UsuarioRol", b =>
                {
                    b.HasOne("EvonixGym.Data.Modelos.Rol", "Rol")
                        .WithMany("UsuarioRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvonixGym.Data.Modelos.Usuario", "Usuario")
                        .WithMany("UsuarioRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("EvonixGym.Modelos.Archivo", b =>
                {
                    b.HasOne("EvonixGym.Modelos.Pregunta", null)
                        .WithMany("Archivos")
                        .HasForeignKey("PreguntaIdPreguntas");

                    b.HasOne("EvonixGym.Modelos.Pregunta", null)
                        .WithMany("imagenes")
                        .HasForeignKey("PreguntaIdPreguntas1");
                });

            modelBuilder.Entity("EvonixGym.Modelos.Archivoresp", b =>
                {
                    b.HasOne("EvonixGym.Modelos.Respuestum", "IdRespuestaNavigation")
                        .WithMany("Archivoresps")
                        .HasForeignKey("IdRespuestaNavigationIdRespuesta");

                    b.Navigation("IdRespuestaNavigation");
                });

            modelBuilder.Entity("EvonixGym.Modelos.ComposicionCorporal", b =>
                {
                    b.HasOne("EvonixGym.Modelos.Cuestionario", "CueIdCuestionarioNavigation")
                        .WithMany("ComposicionCorporals")
                        .HasForeignKey("CueIdCuestionarioNavigationIdCuestionario");

                    b.Navigation("CueIdCuestionarioNavigation");
                });

            modelBuilder.Entity("EvonixGym.Modelos.ComposicionCorporalClient", b =>
                {
                    b.HasOne("EvonixGym.Data.Modelos.Cliente", "Cliente")
                        .WithMany("ComposicionCorporalClient")
                        .HasForeignKey("IdCcCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvonixGym.Modelos.ComposicionCorporal", "IdComposicionNavigation")
                        .WithMany("ComposicionCorporalClients")
                        .HasForeignKey("IdComposicion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("IdComposicionNavigation");
                });

            modelBuilder.Entity("EvonixGym.Modelos.Cuestionario", b =>
                {
                    b.HasOne("EvonixGym.Data.Modelos.Entrenador", "IdEntrenadorNavigation")
                        .WithMany()
                        .HasForeignKey("IdEntrenadorNavigationIdEntrenador");

                    b.Navigation("IdEntrenadorNavigation");
                });

            modelBuilder.Entity("EvonixGym.Modelos.CuestionarioClientes", b =>
                {
                    b.HasOne("EvonixGym.Modelos.Cuestionario", null)
                        .WithMany("CuestionarioClientes")
                        .HasForeignKey("CuestionarioIdCuestionario");
                });

            modelBuilder.Entity("EvonixGym.Modelos.PerimetroDelCliente", b =>
                {
                    b.HasOne("EvonixGym.Data.Modelos.Cliente", "Cliente")
                        .WithMany("PerimetroDelClientes")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvonixGym.Modelos.Perimetro", "IdPerimetroNavigation")
                        .WithMany("PerimetroDelClientes")
                        .HasForeignKey("IdPerimetro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("IdPerimetroNavigation");
                });

            modelBuilder.Entity("EvonixGym.Modelos.PerimetrosCuestionario", b =>
                {
                    b.HasOne("EvonixGym.Modelos.Cuestionario", "IdCuestionarioNavigation")
                        .WithMany("PerimetrosCuestionarios")
                        .HasForeignKey("IdCuestionario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvonixGym.Modelos.Perimetro", "Perimetro")
                        .WithMany("PerimetrosCuestionario")
                        .HasForeignKey("IdPerimetro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdCuestionarioNavigation");

                    b.Navigation("Perimetro");
                });

            modelBuilder.Entity("EvonixGym.Modelos.Pregunta", b =>
                {
                    b.HasOne("EvonixGym.Modelos.Cuestionario", "IdCuestionarioNavigation")
                        .WithMany("Pregunta")
                        .HasForeignKey("IdCuestionarioNavigationIdCuestionario");

                    b.Navigation("IdCuestionarioNavigation");
                });

            modelBuilder.Entity("EvonixGym.Modelos.Respuestum", b =>
                {
                    b.HasOne("EvonixGym.Modelos.Pregunta", "IdPreguntasNavigation")
                        .WithMany("Respuesta")
                        .HasForeignKey("IdPreguntasNavigationIdPreguntas");

                    b.Navigation("IdPreguntasNavigation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("EvonixGym.Data.Modelos.Rol", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EvonixGym.Data.Modelos.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EvonixGym.Data.Modelos.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EvonixGym.Data.Modelos.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.Cliente", b =>
                {
                    b.Navigation("ComposicionCorporalClient");

                    b.Navigation("PerimetroDelClientes");

                    b.Navigation("UsuarioClientes");
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.Entrenador", b =>
                {
                    b.Navigation("UsuarioEntrenadores");
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.Rol", b =>
                {
                    b.Navigation("UsuarioRoles");
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.Usuario", b =>
                {
                    b.Navigation("UsuarioClientes");

                    b.Navigation("UsuarioEntrenadores");

                    b.Navigation("UsuarioRoles");
                });

            modelBuilder.Entity("EvonixGym.Modelos.ComposicionCorporal", b =>
                {
                    b.Navigation("ComposicionCorporalClients");
                });

            modelBuilder.Entity("EvonixGym.Modelos.Cuestionario", b =>
                {
                    b.Navigation("ComposicionCorporals");

                    b.Navigation("CuestionarioClientes");

                    b.Navigation("PerimetrosCuestionarios");

                    b.Navigation("Pregunta");
                });

            modelBuilder.Entity("EvonixGym.Modelos.Perimetro", b =>
                {
                    b.Navigation("PerimetroDelClientes");

                    b.Navigation("PerimetrosCuestionario");
                });

            modelBuilder.Entity("EvonixGym.Modelos.Pregunta", b =>
                {
                    b.Navigation("Archivos");

                    b.Navigation("Respuesta");

                    b.Navigation("imagenes");
                });

            modelBuilder.Entity("EvonixGym.Modelos.Respuestum", b =>
                {
                    b.Navigation("Archivoresps");
                });
#pragma warning restore 612, 618
        }
    }
}
