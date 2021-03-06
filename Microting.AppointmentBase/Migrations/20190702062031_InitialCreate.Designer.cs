﻿/*
The MIT License (MIT)
Copyright (c) 2007 - 2019 Microting A/S
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microting.AppointmentBase.Infrastructure.Data;

namespace Microting.AppointmentBase.Migrations
{
    [DbContext(typeof(AppointmentPnDbContext))]
    [Migration("20190702062031_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            string autoIDGenStrategy = "SqlServer:ValueGenerationStrategy";
            object autoIDGenStrategyValue = SqlServerValueGenerationStrategy.IdentityColumn;
            if (DbConfig.IsMySQL)
            {
                autoIDGenStrategy = "MySql:ValueGenerationStrategy";
                autoIDGenStrategyValue = MySqlValueGenerationStrategy.IdentityColumn;
            }
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

            modelBuilder.Entity("Microting.AppointmentBase.Infrastructure.Data.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<string>("Body");

                    b.Property<short?>("ColorRule");

                    b.Property<short?>("Completed");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<int?>("Duration");

                    b.Property<string>("ExceptionString");

                    b.Property<DateTime?>("ExpireAt");

                    b.Property<string>("GlobalId");

                    b.Property<string>("Info");

                    b.Property<string>("MicrotingUuid")
                        .HasMaxLength(255);

                    b.Property<string>("ProcessingState")
                        .HasMaxLength(255);

                    b.Property<string>("Replacements");

                    b.Property<string>("Response");

                    b.Property<int?>("SdkeFormId");

                    b.Property<DateTime?>("StartAt");

                    b.Property<string>("Subject")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Microting.AppointmentBase.Infrastructure.Data.Entities.AppointmentPrefillFieldValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int?>("AppointmentFvId");

                    b.Property<int?>("AppointmentId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("FieldId");

                    b.Property<string>("FieldValue");

                    b.Property<int>("MicrotingSiteUid");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.ToTable("AppointmentPrefillFieldValues");
                });

            modelBuilder.Entity("Microting.AppointmentBase.Infrastructure.Data.Entities.AppointmentPrefillFieldValueVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int?>("AppointmentFvId");

                    b.Property<int?>("AppointmentId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("FieldId");

                    b.Property<string>("FieldValue");

                    b.Property<int>("MicrotingSiteUid");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("AppointmentPrefillFieldValueVersions");
                });

            modelBuilder.Entity("Microting.AppointmentBase.Infrastructure.Data.Entities.AppointmentSite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int?>("AppointmentId");

                    b.Property<short?>("Completed");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("ExceptionString");

                    b.Property<int>("MicrotingSiteUid");

                    b.Property<string>("ProcessingState")
                        .HasMaxLength(255);

                    b.Property<string>("SdkCaseId")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.ToTable("AppointmentSites");
                });

            modelBuilder.Entity("Microting.AppointmentBase.Infrastructure.Data.Entities.AppointmentSiteVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int?>("AppointmentId");

                    b.Property<int?>("AppointmentSiteId");

                    b.Property<short?>("Completed");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("ExceptionString");

                    b.Property<int>("MicrotingSiteUid");

                    b.Property<string>("ProcessingState")
                        .HasMaxLength(255);

                    b.Property<string>("SdkCaseId")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("AppointmentSiteVersions");
                });

            modelBuilder.Entity("Microting.AppointmentBase.Infrastructure.Data.Entities.AppointmentVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int?>("AppointmentId");

                    b.Property<string>("Body");

                    b.Property<short?>("ColorRule");

                    b.Property<short?>("Completed");

                    b.Property<short?>("Connected");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<int?>("Duration");

                    b.Property<string>("ExceptionString");

                    b.Property<DateTime?>("ExpireAt");

                    b.Property<string>("GlobalId");

                    b.Property<string>("Info");

                    b.Property<string>("Location")
                        .HasMaxLength(255);

                    b.Property<string>("MicrotingUid")
                        .HasMaxLength(255);

                    b.Property<string>("ProcessingState")
                        .HasMaxLength(255);

                    b.Property<string>("Replacements");

                    b.Property<string>("Response");

                    b.Property<int?>("SdkeFormId");

                    b.Property<string>("SiteIds");

                    b.Property<DateTime?>("StartAt");

                    b.Property<string>("Subject")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("AppointmentVersions");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginConfigurationValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<string>("Value");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("PluginConfigurationValues");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginConfigurationValueVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<string>("Value");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("PluginConfigurationValueVersions");
                });

            modelBuilder.Entity("Microting.AppointmentBase.Infrastructure.Data.Entities.AppointmentPrefillFieldValue", b =>
                {
                    b.HasOne("Microting.AppointmentBase.Infrastructure.Data.Entities.Appointment", "Appointment")
                        .WithMany("AppointmentPrefillFieldValues")
                        .HasForeignKey("AppointmentId");
                });

            modelBuilder.Entity("Microting.AppointmentBase.Infrastructure.Data.Entities.AppointmentSite", b =>
                {
                    b.HasOne("Microting.AppointmentBase.Infrastructure.Data.Entities.Appointment", "Appointment")
                        .WithMany("AppointmentSites")
                        .HasForeignKey("AppointmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
