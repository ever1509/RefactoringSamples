using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwitchStatements.Entities;
using SwitchStatements.Enums;

namespace SwitchStatements.Configurations.JobSeekerProperties
{
    public class JobSeekerPropertyIrishJobs: JobSeekerPropertyBase
    {
        public override void GetConfigurationProperties(EntityTypeBuilder<JobSeeker> builder)
        {
            builder.ToTable("JobSeeker");

            builder.HasIndex(e => e.Email).IsUnique();

            builder.HasIndex(e => e.Jsguid).IsUnique();
            builder.HasIndex(e => new { e.Id, e.SelligentOptout }).HasName("IX_Jobseeker_SelligentOptout");
            builder.HasIndex(e => new { e.Id, e.SelligentId }).HasName("IX_Jobseeker_SelligentId");            

            builder.Property(e => e.CreatedDt)
                .HasColumnName("CreatedDT")
                .HasColumnType("datetime");

            builder.Property(e => e.CreationType).HasDefaultValueSql("((1))");

            builder.Property(e => e.CzjobCategoryId).HasColumnName("CZJobCategoryId");

            builder.Property(e => e.DeletedDt)
                .HasColumnName("DeletedDT")
                .HasColumnType("datetime");

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.FirstName).HasMaxLength(200);

            builder.Property(e => e.Jsguid).HasColumnName("JSGuid");

            builder.Property(e => e.LastLoggedInDt)
                .HasColumnName("LastLoggedInDT")
                .HasColumnType("datetime");

            builder.Property(e => e.LastName).HasMaxLength(200);

            builder.Property(e => e.ModifiedDt)
                .HasColumnName("ModifiedDT")
                .HasColumnType("datetime");

            builder.Property(e => e.Password).HasMaxLength(200);

            builder.Property(e => e.ProductAndServiceEmailUpdatedDt)
                .HasColumnName("ProductAndServiceEmailUpdatedDT")
                .HasColumnType("datetime");

            builder.Property(e => e.ReceiveServiceEmails)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.ReceiveSystemEmails)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.ReceiveThirdPartyEmails)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.ServiceEmailUpdatedDt)
                .HasColumnName("ServiceEmailUpdatedDT")
                .HasColumnType("datetime");

            builder.Property(e => e.ThirdPartyEmailModifiedDt)
                .HasColumnName("ThirdPartyEmailModifiedDT")
                .HasColumnType("datetime");

            builder.Ignore(e => e.SiteEmails);
            builder.Ignore(e => e.SiteEmailsDateChange);
            builder.Ignore(e => e.ServiceEmails);
            builder.Ignore(e => e.ServiceEmailsDateChange);
            builder.Ignore(e => e.NewsletterOptIn);
            builder.Ignore(e => e.NewsletterOptInDateChange);
        }
    }
}
