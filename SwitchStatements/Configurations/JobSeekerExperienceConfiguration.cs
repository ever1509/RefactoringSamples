using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwitchStatements.Entities;
using SwitchStatements.Enums;

namespace SwitchStatements.Configurations
{
    public class JobSeekerExperienceConfiguration:IEntityTypeConfiguration<JobSeekerExperience>
    {
        public JobSeekerExperienceConfiguration(Site site)
        {
            _site = site;
        }

        public Site _site { get; set; }
        public void Configure(EntityTypeBuilder<JobSeekerExperience> builder)
        {
            switch (_site)
            {
                case Site.Jobsie:
                    builder.ToTable("JobSeeker_WorkExperience");

                    builder.HasKey(e => e.Id);

                    builder.Property(e => e.Company).HasColumnName("CompanyName").IsRequired();

                    builder.Property(e => e.Company).HasMaxLength(200);

                    builder.Property(e => e.Experience).HasColumnName("Description");

                    builder.Property(e => e.Title).HasColumnName("JobTitle").IsRequired();

                    builder.Property(e => e.CompanyIndustryId).HasColumnName("IndustryId").IsRequired(false);

                    builder.Property(e => e.Title).HasMaxLength(200);

                    builder.Property(e => e.LocationName).HasColumnName("Location").HasMaxLength(200);

                    builder.Property(e => e.StrtDate).HasColumnType("datetime").HasColumnName("StartDate").IsRequired(false);

                    builder.Property(e => e.FromDate).HasColumnType("datetime").HasColumnName("FromDate").IsRequired();

                    builder.Property(e => e.ToDate).HasColumnType("datetime").HasColumnName("ToDate").IsRequired(false);

                    builder.HasOne(d => d.JobSeekerProfile)
                        .WithMany(p => p.JobSeekerExperience)
                        .HasForeignKey(k => k.JobSeekerId)
                        .HasConstraintName("FK_JobSeeker_WorkExperience_JobSeekerProfile")
                        .IsRequired();                    

                    builder.Ignore(e => e.JobSeeker);
                    builder.Ignore(e => e.StartDate);
                    builder.Ignore(e => e.EndDate);
                    builder.Ignore(e => e.CompanyId);
                    builder.Ignore(e => e.LocationId);

                    break;

                case Site.JobsLu:
                    break;

                case Site.NiJobs:
                case Site.IrishJobs:
                    builder.ToTable("JobSeekerExperience");
                    builder.HasIndex(e => e.JobSeekerId);

                    builder.Property(e => e.Company).HasMaxLength(200);

                    builder.Property(e => e.Experience).HasMaxLength(200);

                    builder.Property(e => e.Title)
                        .IsRequired()
                        .HasMaxLength(200);

                    builder.HasOne(d => d.JobSeeker)
                        .WithMany(p => p.JobSeekerExperience)
                        .HasForeignKey(d => d.JobSeekerId)
                        .HasConstraintName("FK_JobSeekerExperience_JobSeeker");                   

                    builder.Ignore(e => e.StrtDate);
                    builder.Ignore(e => e.FromDate);
                    builder.Ignore(e => e.ToDate);
                    builder.Ignore(e => e.LocationName);
                    builder.Ignore(e => e.JobSeekerProfile);
                    break;
            }
        }
    }
}
