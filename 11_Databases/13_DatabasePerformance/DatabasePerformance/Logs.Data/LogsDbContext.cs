namespace Logs.Data
{
    using System.Data.Entity;

    using Logs.Models;

    public class LogsDbContext : DbContext
    {
        public LogsDbContext()
            : base("LogsDb")
        {
        }

        public IDbSet<Log> Logs { get; set; }
    }
}
