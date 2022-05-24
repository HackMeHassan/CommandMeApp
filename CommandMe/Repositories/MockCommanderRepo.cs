using CommandMe.Models;

namespace CommandMe.Repositories
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>()
            {
                new Command{ Id=0, HowTo="Boil an egg", Line="Boil water" , Platform="Kettle & Pan"},
                new Command{ Id=0, HowTo="Cut bread", Line="get a knife" , Platform="Knife and choping board"},
                new Command{ Id=0, HowTo="Make cup of tea", Line="Place teabag in cup" , Platform="Kettle & cup"}

            };
            return commands;    
        }
        public Command GetCommandById(int id)
        {
            return new Command { Id = 0 , HowTo="Boil an egg", Line="Boil water", Platform=" Kettle & Pan"}; 
        }
    }
}
