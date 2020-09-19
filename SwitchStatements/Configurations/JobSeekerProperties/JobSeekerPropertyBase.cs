using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwitchStatements.Entities;

namespace SwitchStatements.Configurations.JobSeekerProperties
{
    public abstract class JobSeekerPropertyBase
    {
        public abstract void GetConfigurationProperties(EntityTypeBuilder<JobSeeker> builder);
    }
}
