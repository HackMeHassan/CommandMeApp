using CommandMe.Models;
using CommandMe.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommandMe.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _mockCommanderRepo;

        public CommandsController(ICommanderRepo mockCommanderRepo)
        {
            _mockCommanderRepo = mockCommanderRepo;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAppCommands()
        {
            //var commandItems = _mockCommanderRepo.GetAppCommands();

            var commandItems = _mockCommanderRepo.GetAppCommands();

            return Ok(commandItems);
        }
        // the value of id will come from the request that we are going to send using for example the postman client
        // for this the concept of binding sources will be used which is to be found in the asp,net core documentation
        // with the name Model Binding
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id) 
        {
            //var commandItem= _mockCommanderRepo.GetCommandById(id);

            var commandItem= _mockCommanderRepo.GetCommandById(id); 

            return Ok(commandItem); 
        
        }

    }
}
