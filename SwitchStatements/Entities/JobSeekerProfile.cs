using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchStatements.Entities
{
    public class JobSeekerProfile
    {
        public JobSeekerProfile()
        {
            JobSeekerExperience = new HashSet<JobSeekerExperience>();
            JobSeekerEducation = new HashSet<JobSeekerEducation>();            
        }
        public int JobSeekerId { get; set; }
        public string Headline { get; set; }
        public string Summary { get; set; }
        public string KeySkillSet { get; set; }
        public int InterestedIn { get; set; }
        public bool? WorkPermit { get; set; }
        public int? LocationId { get; set; }
        public int? ProfessionId { get; set; }
        public DateTime ModifiedDt { get; set; }
        public bool? IsPublic { get; set; }

        public int? Cvid { get; set; }
        public string Associations { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public DateTime SearchModifiedDt { get; set; }
        public short CreationSource { get; set; }
        public short ModificationSource { get; set; }
        public DateTime? PublicDt { get; set; }
        public int? SalaryRangeId { get; set; }
        public int ExpirationPeriod { get; set; }
        public string LinkedIn { get; set; }
        public string Twitter { get; set; }
        public string GooglePlus { get; set; }
        public string Address { get; set; }
        public bool? OwnTransport { get; set; }
        public string WebSite { get; set; }
        public DateTime? ParsedDt { get; set; }       
        public virtual JobSeeker JobSeeker { get; set; }       
        public virtual ICollection<JobSeekerEducation> JobSeekerEducation { get; set; }        
        public virtual ICollection<JobSeekerExperience> JobSeekerExperience { get; set; }       

    }
}
