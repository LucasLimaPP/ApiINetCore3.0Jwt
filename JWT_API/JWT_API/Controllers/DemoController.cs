using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_API.Controllers
{
    public class DemoController: Controller
    {
        [HttpGet("api/demo")]
        public IActionResult Get()
        {
            return Ok(new { mensagem = "Olá, esta é uma demonstração de Get!" });
        }
    }
}
