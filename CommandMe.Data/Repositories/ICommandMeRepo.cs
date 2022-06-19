using CommandMe.Data.Models;

namespace CommandMe.Data.Repositories
{
    public interface ICommandMeRepo
    {
        //get all the command resources present kind of like getAll thing
        bool SaveChanges();
        IEnumerable<Command> GetAppCommands();

        Command GetCommandById(int id);
        void CreateCommand(Command command);


    }
}
