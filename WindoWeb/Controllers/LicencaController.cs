﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Windo.Application.Contratos;
using Windo.Application.Dtos;

namespace WindoWeb.Controllers
{
    public class LicencaController : Controller
    {
        private readonly ILicencaService licencaService;

        public LicencaController(ILicencaService licencaService)
        {
            this.licencaService = licencaService;
        }

        [Authorize(Roles = "Comercial")]
        public IActionResult Index()        
        {
            
            return View();
        }

        [Authorize(Roles = "Comercial")]
        [HttpPost]
        public  IActionResult AddToCliente(AddLicencaDto addLicencaViewModel) 
        {
            if (addLicencaViewModel == null) return BadRequest("Erro ao inserir licença: dados vazio!");

            

            return Ok();
        }

        public string Licenca(string id, string broker)
        {
            return this.licencaService.getStringEncryptLicenca(id, broker);
        }
    }
}
