using AutoMapper;
using CommandMe.Data.Dtos;
using CommandMe.Data.Models;
using CommandMe.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommandMe.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandMeRepo _commandMeRepo;
        private readonly IMapper _mapper;

        public CommandsController(ICommandMeRepo commandMeRepo, IMapper mapper)
        {
            _commandMeRepo = commandMeRepo;
            _mapper = mapper;

        }


        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAppCommands()
        {
            //var commandItems = _mockCommanderRepo.GetAppCommands();

            var commandItems = _commandMeRepo.GetAppCommands();
            if (commandItems != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(commandItems));
            }
            return NotFound();
        }
        // the value of id will come from the request that we are going to send using for example the postman client
        // for this the concept of binding sources will be used which is to be found in the asp,net core documentation
        // with the name Model Binding
        [HttpGet("{id}")]
        public ActionResult<CommandReadDto> GetCommandById(int id) 
        {
            //var commandItem= _mockCommanderRepo.GetCommandById(id);

            var commandItem= _commandMeRepo.GetCommandById(id); 
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(commandItem));
            }
            return NotFound();
        }

    }
}
