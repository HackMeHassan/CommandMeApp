using CommandMe.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandMe.Data.EntityFrameworkCore
{
    public class CommandMeContext : DbContext
    {
        public CommandMeContext(DbContextOptions<CommandMeContext> options) : base(options)
        {

        }

        public DbSet<Command> Commands { get; set; }
    }
}
