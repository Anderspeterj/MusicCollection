using Microsoft.AspNetCore.Mvc;
using MusicCollection.Controller;
using MusicCollection.Models;



namespace MusicCollection.Controller 
{

    [Route("api/controller")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }   
    }
}
