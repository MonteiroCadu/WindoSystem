using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Windo.Application.Contratos;

namespace WindoWeb.Controllers
{
    public class CorretoraController : Controller
    {
        private readonly ICorretoraService corretoraService;

        public CorretoraController(ICorretoraService corretoraService)
        {
            this.corretoraService = corretoraService;
        }

        [Authorize(Roles = "Comercial")]
        public async Task<IActionResult> List()
        {

            try
            {
                var corretoras = await this.corretoraService.GetAllAsync();
                if (corretoras == null) return NotFound();

                return Json(corretoras);
            }
            catch (Exception e)
            {
                return BadRequest($"Erro não mapeado no sistema: {e.Message}");
            }
        }
    }
}
