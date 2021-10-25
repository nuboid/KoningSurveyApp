﻿// <auto-generated />
using System;
using KoningsSurveyApp.EfDBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KoningsSurveyApp.EfDBContext.Migrations
{
    [DbContext(typeof(SurveyContext))]
    [Migration("20211018142418_SecondCreate")]
    partial class SecondCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KoningsSurveyApp.EfDBContext.SurveyGroup", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SurveyTemplateId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SurveyTemplateId");

                    b.ToTable("SurveyGroups");
                });

            modelBuilder.Entity("KoningsSurveyApp.EfDBContext.SurveyQuestion", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurveyGroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SurveyQuestionType")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SurveyGroupId");

                    b.ToTable("SurveyQuestions");
                });

            modelBuilder.Entity("KoningsSurveyApp.EfDBContext.SurveyTemplate", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AnotherField")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SurveyTemplates");
                });

            modelBuilder.Entity("KoningsSurveyApp.EfDBContext.SurveyGroup", b =>
                {
                    b.HasOne("KoningsSurveyApp.EfDBContext.SurveyTemplate", null)
                        .WithMany("SurveyGroups")
                        .HasForeignKey("SurveyTemplateId");
                });

            modelBuilder.Entity("KoningsSurveyApp.EfDBContext.SurveyQuestion", b =>
                {
                    b.HasOne("KoningsSurveyApp.EfDBContext.SurveyGroup", null)
                        .WithMany("Questions")
                        .HasForeignKey("SurveyGroupId");
                });

            modelBuilder.Entity("KoningsSurveyApp.EfDBContext.SurveyGroup", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("KoningsSurveyApp.EfDBContext.SurveyTemplate", b =>
                {
                    b.Navigation("SurveyGroups");
                });
#pragma warning restore 612, 618
        }
    }
}