using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwitchStatements.Entities;

namespace SwitchStatements.Configurations.JobSeekerProfileProperties
{
    public class JobSeekerProfilePropertiesNiJobs : JobSeekerProfilePropertiesBase
    {
        public override void GetConfigurationsProperties(EntityTypeBuilder<JobSeekerProfile> builder)
        {
            builder.ToTable("JobSeekerProfile");
            builder.HasKey(e => e.JobSeekerId);

            builder.HasIndex(e => e.Cvid);

            builder.Property(e => e.JobSeekerId).ValueGeneratedNever();

            builder.Property(e => e.Associations).HasMaxLength(200);

            builder.Property(e => e.Cvid).HasColumnName("CVId");

            builder.Property(e => e.ExpirationPeriod).HasDefaultValueSql("((2555))");

            builder.Property(e => e.GooglePlus).HasMaxLength(200);

            builder.Property(e => e.Headline).HasMaxLength(200);

            builder.Property(e => e.HomePhone).HasMaxLength(200);

            builder.Property(e => e.IsPublic)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.KeySkillSet).HasMaxLength(200);

            builder.Property(e => e.LinkedIn).HasMaxLength(200);

            builder.Property(e => e.MobilePhone).HasMaxLength(200);

            builder.Property(e => e.ModifiedDt)
                .HasColumnName("ModifiedDT")
                .HasColumnType("datetime");

            builder.Property(e => e.PublicDt)
                .HasColumnName("PublicDT")
                .HasColumnType("datetime");

            builder.Property(e => e.SearchModifiedDt)
                .HasColumnName("SearchModifiedDT")
                .HasColumnType("datetime")
                .HasDefaultValue(DateTime.Now);

            builder.Property(e => e.Summary).HasMaxLength(200);

            builder.Property(e => e.Twitter).HasMaxLength(200);

            builder.Property(e => e.ParsedDt)
                .HasColumnName("ParsedDT")
                .HasColumnType("datetime");

            builder.HasOne(d => d.JobSeeker)
                .WithOne(p => p.JobSeekerProfile)
                .HasForeignKey<JobSeekerProfile>(d => d.JobSeekerId)
                .HasConstraintName("FK_JobSeekerProfile_JobSeeker");

            builder.Ignore(e => e.JobSeekerEducation);
            builder.Ignore(e => e.JobSeekerExperience);
        }
    }
}
