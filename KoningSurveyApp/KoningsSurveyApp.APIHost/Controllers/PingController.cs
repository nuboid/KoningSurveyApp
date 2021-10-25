using KoningSurveyApp.Contracts;
using KoningSurveyApp.Contracts.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace KoningsSurveyApp.APIHost.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        [Route("Ping")]
        public async Task<string> GetPing()
        {
            return "pong";
        }
    }
}
