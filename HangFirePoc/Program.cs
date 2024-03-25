
// See https://aka.ms/new-console-template for more information
using Hangfire;
using PocRecurringJob.Jobs;

GlobalConfiguration.Configuration.UseSqlServerStorage(@"");

RecurringJobs jobs = new RecurringJobs();
jobs.ExecuteJob();