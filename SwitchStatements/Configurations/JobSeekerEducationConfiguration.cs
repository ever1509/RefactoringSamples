using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwitchStatements.Entities;
using SwitchStatements.Enums;

namespace SwitchStatements.Configurations
{
    public class JobSeekerEducationConfiguration:IEntityTypeConfiguration<JobSeekerEducation>
    {
        public JobSeekerEducationConfiguration(Site site)
        {
            _site = site;
        }

        public Site _site { get; set; }
        public void Configure(EntityTypeBuilder<JobSeekerEducation> builder)
        {
            switch (_site)
            {
                case Site.Jobsie:
                    builder.ToTable("JobSeeker_Education");
                    builder.HasKey(e => e.Id);
                    builder.Property(e => e.Institution).HasColumnName("SchoolName");
                    builder.Property(e => e.Institution)
                        .HasMaxLength(200);
                    builder.Property(e => e.Title).HasColumnName("CourseTitle");
                    builder.Property(e => e.Title).HasMaxLength(200);

                    builder.Property(e => e.FromDate).HasColumnName("FromDate")
                        .HasColumnType("datetime").IsRequired(false);

                    builder.Property(e => e.ToDate).HasColumnName("ToDate")
                        .HasColumnType("datetime").IsRequired(false);

                    builder.Property(e => e.Qualification).HasColumnName("LevelId");

                    builder.Property(e => e.Qualification).IsRequired(false);

                    builder.HasOne(d => d.JobSeekerProfile)
                        .WithMany(p => p.JobSeekerEducation)
                        .HasForeignKey(d => d.JobSeekerId)
                        .HasConstraintName("FK_JobSeeker_Education_JobSeekerProfile");


                    builder.Ignore(e => e.StartDate);
                    builder.Ignore(e => e.EndDate);
                    builder.Ignore(e => e.JobSeeker);


                    builder.Ignore(e => e.CompletionDate);

                    break;

                case Site.JobsLu:
                    break;

                case Site.NiJobs:
                case Site.IrishJobs:
                    builder.ToTable("JobSeekerEducation");
                    builder.Property(e => e.Institution)
                        .HasMaxLength(200);

                    builder.Property(e => e.Title).HasMaxLength(200);

                    builder.HasOne(d => d.JobSeeker)
                        .WithMany(p => p.JobSeekerEducation)
                        .HasForeignKey(d => d.JobSeekerId)
                        .HasConstraintName("FK_JobSeekerEducation_JobSeeker");

                    builder.Property(e => e.CompletionDate)
                        .HasColumnName("CompletionDate")
                        .HasColumnType("date");

                    builder.Ignore(e => e.JobSeekerProfile);
                    builder.Ignore(e => e.FromDate);
                    builder.Ignore(e => e.ToDate);

                    break;
            }
        }
    }
}
