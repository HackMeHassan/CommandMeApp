using CommandMe.Data.EntityFrameworkCore;
using CommandMe.Data.Models;

namespace CommandMe.Data.Repositories
{
    public class CommandMeRepo : ICommandMeRepo
    {
        private readonly CommandMeContext _commandMeContext;
        public CommandMeRepo (CommandMeContext commandMeContext)
        {
            _commandMeContext= commandMeContext;
        }
        public IEnumerable<Command> GetAppCommands()
        {
            return _commandMeContext.Commands.ToList();    
        }
        public Command GetCommandById(int id)
        {
            return _commandMeContext.Commands.FirstOrDefault(p => p.Id == id);
        }
        public void CreateCommand(Command command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }
            _commandMeContext.Commands.Add(command);
        }
        public bool SaveChanges()
        {
            return (_commandMeContext.SaveChanges()>0);
        }
    }
}
