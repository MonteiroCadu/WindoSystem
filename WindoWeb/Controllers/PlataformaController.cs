using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Windo.Application.Contratos;
using Windo.Application.Dtos;

namespace WindoWeb.Controllers
{
    public class PlataformaController : Controller
    {
        private readonly IPlataformaService plataformaService;

        public PlataformaController(IPlataformaService plataformaService)
        {
            this.plataformaService = plataformaService;
        }

        [Authorize(Roles = "Comercial")]        
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var plataforma = await this.plataformaService.GetByIdAsync(id);   
                if(plataforma == null) return NotFound();

                return Json(plataforma);
            }
            catch (Exception e)
            {
                return BadRequest($"Erro não mapeado no sistema: {e.Message}");
            }
            
        }

        [Authorize(Roles = "Comercial")]        
        public async Task<IActionResult> GetPlanos(int id)
        {
            try
            {
                var plataforma = await this.plataformaService.GetByIdAsync(id);
                if (plataforma == null) return NotFound();

                return Json(plataforma.PlanoVenda.ToList<PlanoVendaDto>());
            }
            catch (Exception e)
            {
                return BadRequest($"Erro não mapeado no sistema: {e.Message}");
            }

        }

        [Authorize(Roles = "Comercial")]        
        public async Task<IActionResult> List()
        {
            try
            {
                var plataformas = await this.plataformaService.GetAllAtivoComPlanoAsync();
                if (plataformas == null) return NotFound();

                return Json(plataformas);
            }
            catch (Exception e)
            {
                return BadRequest($"Erro não mapeado no sistema: {e.Message}");
            }
        }
    }
}
