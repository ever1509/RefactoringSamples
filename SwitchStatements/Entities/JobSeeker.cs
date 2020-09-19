using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchStatements.Entities
{
    public class JobSeeker
    {
        public JobSeeker()
        {            
            JobSeekerEducation = new HashSet<JobSeekerEducation>();
            JobSeekerExperience = new HashSet<JobSeekerExperience>();            
        }

        public int Id { get; set; }
        public Guid Jsguid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public short EmailPreferences { get; set; }        
        public int? CzjobCategoryId { get; set; }
        public int UnSuccessfulLoginAttempts { get; set; }
        public DateTime? LastLoggedInDt { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime ModifiedDt { get; set; }
        public bool? ReceiveThirdPartyEmails { get; set; }
        public short CreationType { get; set; }
        public int RegistrationRemindersSent { get; set; }
        public bool? ReceiveServiceEmails { get; set; }
        public bool? ReceiveSystemEmails { get; set; }
        public DateTime? DeletedDt { get; set; }
        public bool SelligentOptout { get; set; }
        public int? SelligentId { get; set; }
        public DateTime? ThirdPartyEmailModifiedDt { get; set; }
        public DateTime? ServiceEmailUpdatedDt { get; set; }
        public bool ReceiveProductAndServiceEmails { get; set; }
        public DateTime? ProductAndServiceEmailUpdatedDt { get; set; }        
        public bool? NewsletterOptIn { get; set; }
        public DateTime? NewsletterOptInDateChange { get; set; }
        public bool? SiteEmails { get; set; }
        public DateTime? SiteEmailsDateChange { get; set; }
        public bool? ServiceEmails { get; set; }
        public DateTime? ServiceEmailsDateChange { get; set; }
        
        public virtual JobSeekerProfile JobSeekerProfile { get; set; }                
        
        public virtual ICollection<JobSeekerEducation> JobSeekerEducation { get; set; }

        public virtual ICollection<JobSeekerExperience> JobSeekerExperience { get; set; }
        
    }
}
