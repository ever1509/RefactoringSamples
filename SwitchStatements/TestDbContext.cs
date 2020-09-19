using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SwitchStatements.Configurations;
using SwitchStatements.Entities;
using SwitchStatements.Enums;

namespace SwitchStatements
{
    public class TestDbContext :DbContext
    {

        public TestDbContext(DbContextOptions<TestDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<JobSeeker> JobSeeker { get; set; }
        public DbSet<JobSeekerProfile> JobSeekerProfile { get; set; }
        public DbSet<JobSeekerEducation> JobSeekerEducation { get; set; }
        public DbSet<JobSeekerExperience> JobSeekerExperience { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new JobSeekerConfiguration(Site.IrishJobs));
            modelBuilder.ApplyConfiguration(new JobSeekerProfileConfiguration(Site.IrishJobs));
            modelBuilder.ApplyConfiguration(new JobSeekerEducationConfiguration(Site.IrishJobs));
            modelBuilder.ApplyConfiguration(new JobSeekerExperienceConfiguration(Site.IrishJobs));
        }
    }
}
