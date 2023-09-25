﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ApiAuth.Models;
using Microsoft.AspNetCore.Authorization;

namespace ApiAuth.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format($"Usuário autenticado! - {User.Identity.Name}");

        [HttpGet]
        [Route("employee")]
        [Authorize (Roles = "employee, Manager")]
        public string Employee() => "Funcionário";

        [HttpGet]
        [Route("Manager")]
        [Authorize (Roles="Manager")]
        public string Manager() => "Gerente";
    }
}
