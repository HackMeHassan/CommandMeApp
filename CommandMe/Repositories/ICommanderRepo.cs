using CommandMe.Models;

namespace CommandMe.Repositories
{
    public interface ICommanderRepo
    {
        //get all the command resources present kind of like getAll thing

        IEnumerable<Command> GetAppCommands();

        Command GetCommandById(int id);


    }
}
