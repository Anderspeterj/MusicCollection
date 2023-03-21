using Microsoft.AspNetCore.Mvc;
using MusicCollection.Controller;
using MusicCollection.Models;
using MusicCollection.Repositories;
using Microsoft.AspNetCore.Cors;

namespace MusicCollection.Controller 
{

    [Route("api/controller")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        private RecordRespository _repository;


        public RecordController(RecordRespository repository)
        {
            _repository = repository;
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        [EnableCors("AllowAll")]
        [HttpGet]

        public ActionResult<IEnumerable<Record>> GetAll()
        {
            List<Record> result = _repository.GetAll();
            if(result.Count < 1)
            {
               return NoContent();
            }

            return Ok(result);
        }


    }
}
