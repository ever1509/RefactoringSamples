using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwitchStatements.Entities;

namespace SwitchStatements.Configurations.JobSeekerProperties
{
    public class JobSeekerPropertyJobsie:JobSeekerPropertyBase
    {
        public override void GetConfigurationProperties(EntityTypeBuilder<JobSeeker> builder)
        {
            builder.ToTable("JobSeeker");

            builder.HasIndex(e => e.Email).IsUnique();

            builder.Ignore(e => e.Jsguid);

            builder.Ignore(e => e.SelligentId);

            builder.Ignore(e => e.SelligentOptout);

            builder.HasIndex(e => new { e.Email }).HasName("IX_JobSeeker_Email");

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.FirstName).HasMaxLength(200);

            builder.Property(e => e.LastName).HasMaxLength(200);

            builder.Property(e => e.NewsletterOptIn).IsRequired(false);

            builder.Property(e => e.SiteEmails).IsRequired(false);

            builder.Property(e => e.ServiceEmails).IsRequired(false);

            builder.Property(e => e.NewsletterOptInDateChange).HasColumnName("NewsletterOptInDateChange")
                .HasColumnType("datetime").IsRequired(false);

            builder.Property(e => e.SiteEmailsDateChange).HasColumnName("SiteEmailsDateChange")
                .HasColumnType("datetime").IsRequired(false);

            builder.Property(e => e.ServiceEmailsDateChange).HasColumnName("ServiceEmailsDateChange")
                .HasColumnType("datetime").IsRequired(false);


            builder.Ignore(e => e.CreatedDt);
            builder.Ignore(e => e.CreationType);
            builder.Ignore(e => e.CzjobCategoryId);
            builder.Ignore(e => e.DeletedDt);
            builder.Ignore(e => e.EmailPreferences);
            builder.Ignore(e => e.LastLoggedInDt);
            builder.Ignore(e => e.ModifiedDt);
            builder.Ignore(e => e.Password);
            builder.Ignore(e => e.ProductAndServiceEmailUpdatedDt);
            builder.Ignore(e => e.ReceiveProductAndServiceEmails);
            builder.Ignore(e => e.ReceiveServiceEmails);
            builder.Ignore(e => e.ReceiveSystemEmails);
            builder.Ignore(e => e.ReceiveThirdPartyEmails);
            builder.Ignore(e => e.RegistrationRemindersSent);
            builder.Ignore(e => e.ServiceEmailUpdatedDt);
            builder.Ignore(e => e.ThirdPartyEmailModifiedDt);
            builder.Ignore(e => e.UnSuccessfulLoginAttempts);

            builder.Ignore(e => e.JobSeekerEducation);
            builder.Ignore(e => e.JobSeekerExperience);
        }
    }
}
