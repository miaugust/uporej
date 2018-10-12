using System;
using System.Threading.Tasks;
using Rejupo.Models;

namespace Rejupo.Data
{
    public static class LogWriter
    {
        public static async Task WritetoDbAsync(AppDbContext db, string username, string description)
        {
            Log log = new Log
            {
                UserName = username,
                Description = description,
                Date = DateTime.Now
            };
            await db.Logs.AddAsync(log);
            await db.SaveChangesAsync();
        }
    }
}