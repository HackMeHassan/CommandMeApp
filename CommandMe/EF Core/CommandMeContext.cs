using CommandMe.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandMe.EF_Core
{
    public class CommandMeContext : DbContext
    {
        public CommandMeContext(DbContextOptions<CommandMeContext> options) : base(options) 
        {
            
        }

        public DbSet<Command> Commands { get; set; }
    }
}
