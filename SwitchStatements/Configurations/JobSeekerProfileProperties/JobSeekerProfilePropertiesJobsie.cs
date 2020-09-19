using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwitchStatements.Entities;

namespace SwitchStatements.Configurations.JobSeekerProfileProperties
{
    public class JobSeekerProfilePropertiesJobsie : JobSeekerProfilePropertiesBase
    {
        public override void GetConfigurationsProperties(EntityTypeBuilder<JobSeekerProfile> builder)
        {
            builder.ToTable("JobSeekerProfile");

            builder.HasKey(e => e.JobSeekerId);

            builder.HasIndex(e => e.Cvid);

            builder.Property(e => e.JobSeekerId).ValueGeneratedNever();

            builder.Property(e => e.Cvid).HasColumnName("CVId");

            builder.Property(e => e.Headline)
                .HasMaxLength(200);

            builder.Property(e => e.IsPublic).IsRequired();

            builder.Property(e => e.KeySkillSet).HasColumnName("KeySkills")
                .HasMaxLength(200);

            builder.Property(e => e.MobilePhone).HasMaxLength(10);

            builder.Property(e => e.LinkedIn).HasMaxLength(200);

            builder.Property(e => e.ParsedDt)
                .HasColumnName("ParsedDT")
                .HasColumnType("datetime");

            builder.Property(e => e.ModifiedDt)
                .HasColumnName("ModifiedDT")
                .HasColumnType("datetime");

            builder.HasOne(d => d.JobSeeker)
                .WithOne(p => p.JobSeekerProfile)
                .HasForeignKey<JobSeeker>(d => d.Id)
                .HasConstraintName("FK_JobSeekerProfile_JobSeeker");


            builder.Ignore(e => e.Associations);
            builder.Ignore(e => e.CreationSource);
            builder.Ignore(e => e.ExpirationPeriod);
            builder.Ignore(e => e.GooglePlus);
            builder.Ignore(e => e.HomePhone);
            builder.Ignore(e => e.InterestedIn);
            builder.Ignore(e => e.LocationId);
            builder.Ignore(e => e.ModificationSource);
            builder.Ignore(e => e.ProfessionId);
            builder.Ignore(e => e.PublicDt);
            builder.Ignore(e => e.SalaryRangeId);
            builder.Ignore(e => e.SearchModifiedDt);
            builder.Ignore(e => e.Twitter);
        }
    }
}
