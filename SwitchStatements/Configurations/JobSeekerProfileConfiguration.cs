using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwitchStatements.Configurations.JobSeekerProfileProperties;
using SwitchStatements.Entities;
using SwitchStatements.Enums;

namespace SwitchStatements.Configurations
{
    public class JobSeekerProfileConfiguration:IEntityTypeConfiguration<JobSeekerProfile>
    {
        public Site _site { get; set; }
        private static readonly Dictionary<Site, JobSeekerProfilePropertiesBase> JobSeekerProfileProperties =
           new Dictionary<Site, JobSeekerProfilePropertiesBase>
           {
                {Site.IrishJobs, new JobSeekerProfilePropertiesIrishJobs()},
                {Site.NiJobs, new JobSeekerProfilePropertiesNiJobs()},
                {Site.Jobsie, new JobSeekerProfilePropertiesJobsie()}
           };
        public JobSeekerProfileConfiguration(Site site)
        {
            _site = site;
        }
        public void Configure(EntityTypeBuilder<JobSeekerProfile> builder)
        {
            JobSeekerProfileProperties[_site].GetConfigurationsProperties(builder);          
        }

    }
}
