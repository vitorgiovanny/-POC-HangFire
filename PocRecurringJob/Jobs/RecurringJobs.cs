using Hangfire;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocRecurringJob.Jobs
{
    public class RecurringJobs
    {

        public RecurringJobs() { }

        public void ExecuteJob()
        {
            using (var server = new BackgroundJobServer())
            {
                RecurringJob.AddOrUpdate(() => Console.WriteLine("Tarefa Iniciado"), Cron.Minutely);

                Console.WriteLine("Tarefa recorrente agendada.");
                Console.ReadKey();
            }
        }
    }
}
