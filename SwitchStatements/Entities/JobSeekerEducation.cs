using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchStatements.Entities
{
    public class JobSeekerEducation
    {
        public int Id { get; set; }
        public int JobSeekerId { get; set; }
        public string Institution { get; set; }
        public string Title { get; set; }
        public int? StartDate { get; set; }
        public int? EndDate { get; set; }
        public int? Qualification { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }


        public virtual JobSeeker JobSeeker { get; set; }
        public virtual JobSeekerProfile JobSeekerProfile { get; set; }


    }
}
