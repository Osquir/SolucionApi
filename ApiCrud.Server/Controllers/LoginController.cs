﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//Referencias
using ApiCrud.Server.Models.Custom;
using ApiCrud.Server.Services;

namespace ApiCrud.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAutorizationService _autorizationService;

        public LoginController(IAutorizationService autorizationService)
        {
            _autorizationService = autorizationService;
        }
        [HttpPost]
        [Route("Auth")]
        public async Task<IActionResult> Auth([FromBody] AutorizationRequest autorization)
        {
            var resultado_autorizacion = await _autorizationService.DevolverToken(autorization);

            if (resultado_autorizacion == null)
            {
                return Unauthorized();
            }

            return Ok(resultado_autorizacion);
        }
    }
}
