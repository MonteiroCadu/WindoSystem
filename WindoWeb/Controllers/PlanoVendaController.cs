using Microsoft.AspNetCore.Mvc;
using Windo.Application.Contratos;

namespace WindoWeb.Controllers
{
    public class PlanoVendaController : Controller
    {
        private readonly IPlanoVendaService planoVendaService;

        public PlanoVendaController(IPlanoVendaService planoVendaService)
        {
            this.planoVendaService = planoVendaService;
        }

        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var planoVenda = await this.planoVendaService.GetByIdAsync(id);
                if (planoVenda == null) return NotFound();

                return Json(planoVenda);
            }
            catch (Exception e)
            {
                return BadRequest($"Erro não mapeado no sistema: {e.Message}");
            }
        }
    }
}
