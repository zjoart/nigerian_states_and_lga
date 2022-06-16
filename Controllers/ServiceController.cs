using IctChain.Models.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nigeria_state_and_lga.Models;
using nigeria_state_and_lga.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nigeria_state_and_lga.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceController : Controller
    {
        private readonly INigeriaStateLga _service;

        public ServiceController(INigeriaStateLga service)
        {
            _service = service; 

        }

        [HttpGet("getstates")]
        public IActionResult GetStates()
        {
            var res = _service.GetStates();

            return Ok(new ApiResponse
            {
                Code= "00",
                Description = " Sucess",
                Data = res
            });
        }

        [HttpGet("getlgas")]
        public IActionResult GetLgas()
        {
            var res = _service.GetAllLga();
            return Ok(new ApiResponse
            {
                Code = "00",
                Description = " Sucess",
                Data = res
            });
        }
        [HttpGet("getlgafromstate")]
        public IActionResult GetLga(string state)
        {
            var res = _service.GetLgaByState(state);    
            if(res == null)
            {
                return BadRequest(new ApiResponse
                {
                    Code = "25",
                    Description = "Failure, Check input and try again",
                    Data = null
                });
            }
            return Ok(new ApiResponse
            {
                Code = "00",
                Description = " Sucess",
                Data = res
            });
        }
    }
}








//private static readonly string[] Summaries = new[]
//     {
//            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//        };