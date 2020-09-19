using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwitchStatements.Configurations.JobSeekerProperties;
using SwitchStatements.Entities;
using SwitchStatements.Enums;

namespace SwitchStatements.Configurations
{
    public class JobSeekerConfiguration:IEntityTypeConfiguration<JobSeeker>
    {
        private static readonly Dictionary<Site,JobSeekerPropertyBase> JobSeekerProperties =
            new Dictionary<Site, JobSeekerPropertyBase>
            {
                {Site.IrishJobs, new JobSeekerPropertyIrishJobs()},
                {Site.NiJobs, new JobSeekerPropertyNiJobs()},
                {Site.Jobsie, new JobSeekerPropertyJobsie()}
            };
        public JobSeekerConfiguration(Site site)
        {
            _site = site;
        }
        public Site _site { get; set; }
        public void Configure(EntityTypeBuilder<JobSeeker> builder)
        {
            JobSeekerProperties[_site].GetConfigurationProperties(builder);
        }
    }
}
