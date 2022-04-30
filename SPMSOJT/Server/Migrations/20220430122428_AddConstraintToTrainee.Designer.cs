﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SPMSOJT.Server.Data;

namespace SPMSOJT.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220430122428_AddConstraintToTrainee")]
    partial class AddConstraintToTrainee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SPMSOJT.Shared.Coordinator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("barangay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phonenum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("schoolemail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zipcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("coordinator_info");
                });

            modelBuilder.Entity("SPMSOJT.Shared.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("branch_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_person")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("org_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("organization_info");
                });

            modelBuilder.Entity("SPMSOJT.Shared.Supervisor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("barangay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("citizenship")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("college")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("middle_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phonenum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("school_barangay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("school_city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("school_province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("school_zipcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("schoolemail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("schoolname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("suffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zipcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("supervisor_info");
                });

            modelBuilder.Entity("SPMSOJT.Shared.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("organizationId")
                        .HasColumnType("int");

                    b.Property<string>("school_year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.Property<int>("supervisorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("trainee_info");
                });

            modelBuilder.Entity("SPMSOJT.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("barangay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("citizenship")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("college")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idnumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("middle_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phonenum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("school_barangay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("school_city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("school_province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("school_zipcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("schoolemail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("schoolname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("suffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zipcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("user_info");
                });
#pragma warning restore 612, 618
        }
    }
}
