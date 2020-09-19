using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchStatements.Entities
{
    public class JobSeekerExperience
    {       

        public int Id { get; set; }
        public int JobSeekerId { get; set; }
        public string Company { get; set; }
        public int? CompanyIndustryId { get; set; }
        public int? CompanyId { get; set; }
        public string Title { get; set; }
        public int? LocationId { get; set; }
        public string Experience { get; set; }
        public int StartDate { get; set; }
        public int? EndDate { get; set; }
        public DateTime? StrtDate { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string LocationName { get; set; }

        public int? JobCategoryId { get; set; }

        public virtual JobSeeker JobSeeker { get; set; }
        public virtual JobSeekerProfile JobSeekerProfile { get; set; }     

    }
}
