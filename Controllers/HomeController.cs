using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHome _home;

        public HomeController(IHome home)
        {
            _home = home;
        }

        [HttpGet("getstate")]
        public List<State> GetState()
        {
            List<State> lst = new List<State>();
            try
            {
                lst = _home.states();
            }
            catch(Exception ex)
            {
                lst = new List<State>();
            }
            return lst;
        }
    }
}
