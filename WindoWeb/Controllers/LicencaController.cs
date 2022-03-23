using Microsoft.AspNetCore.Mvc;
using Windo.Application.Contratos;

namespace WindoWeb.Controllers
{
    public class LicencaController : Controller
    {
        private readonly ILicencaService licencaService;

        public LicencaController(ILicencaService licencaService)
        {
            this.licencaService = licencaService;
        }

        public IActionResult Index()        
        {
            
            return View();
        }

        public string Licenca(string id, string broker)
        {
            return this.licencaService.getStringEncryptLicenca(id, broker);
        }
    }
}
