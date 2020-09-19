using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwitchStatements.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchStatements.Configurations.JobSeekerProfileProperties
{
    public abstract class JobSeekerProfilePropertiesBase
    {
        public abstract void GetConfigurationsProperties(EntityTypeBuilder<JobSeekerProfile> builder);
    }
}
