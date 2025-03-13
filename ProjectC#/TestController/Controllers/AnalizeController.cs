using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using TestCore.Models;

namespace TestController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnalizeController : ControllerBase
    {

        // Метод принимает список пользователей и возвращает статистику
        [HttpPost("GetAnalize")]
        public async Task<IActionResult> GetAnalizeTest([FromBody] List<User> users)
        {
            if (users == null || !users.Any())
            {
                return BadRequest("No data provided");
            }
            var finalResult = Services.UserService.Analys(users);
            Debug.WriteLine(finalResult.ToString());
            Services.FileService.Export(finalResult);
            return Ok(finalResult);
        }
    }
}