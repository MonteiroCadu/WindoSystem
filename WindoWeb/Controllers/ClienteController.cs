using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Windo.Application.Contratos;
using Windo.Application.Dtos;
namespace WindoWeb.Controllers
{
    [Authorize]
    public class ClienteController : Controller
    {
        private readonly IPessoaService pessoaService;

        public ClienteController(IPessoaService pessoaService)
        {
            this.pessoaService = pessoaService;
        }
        // GET: ClienteController

        [HttpGet]
        public async Task<ActionResult> List(string stringBuscaPessoa)
        {
            
            var cliente = stringBuscaPessoa == null
                            ? await this.pessoaService.GetAllAsync(100)
                            : await this.pessoaService.SearchByNomeOrEmailAsync(stringBuscaPessoa);
            
            ViewData["Titulo"] = "Clientes";
            ViewData["SubTitulo"] = "Listagem";
            //ViewBag.Edicao = false;
            ViewData["AspController"] = "Cliente";
            ViewData["AspAction"] = "List";
            ViewData["FontIcon"] = "fa-users";
            ViewData["stringBuscaPessoa"] = stringBuscaPessoa;
            return View(cliente.ToList());
        }
        
        public ActionResult Create()
        {
            ViewData["Titulo"] = "Cliente";
            ViewData["SubTitulo"] = "Cadastro";
            //ViewBag.Edicao = false;
            ViewData["AspController"] = "Cliente";
            ViewData["AspAction"] = "List";
            ViewData["FontIcon"] = "fa-users";
            return View("DetalhePessoa");
        }

        
        [HttpPost]       
        public async Task<ActionResult> Save(PessoaDto pessoa)
        {
            PessoaDto? pessoaSalva = pessoa;
            

            if(ModelState.IsValid)
            {
                try
                {
                    pessoaSalva = await this.pessoaService.save(pessoa);
                    return RedirectToAction("Edit", new { id = pessoaSalva?.Id });                    
                }
                catch (Exception e )
                {
                    ViewData["Error"] = e.Message;
                }
                
            }
            

            ViewData["Id"] = pessoaSalva?.Id;
            if (pessoaSalva?.Id == 0)
                ViewData["SubTitulo"] = "Cadastro";
            else
            {
                ViewData["SubTitulo"] = "Edição";
                ViewData["Edicao"] = true;
            }


            ViewData["Titulo"] = "Cliente";
            ViewData["AspController"] = "Cliente";
            ViewData["AspAction"] = "List";
            ViewData["FontIcon"] = "fa-users";


            return View("DetalhePessoa",pessoa);
        }

        // GET: ClienteController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var pessoaSalva = await this.pessoaService.GetByIdAsync(id);
            ViewData["Id"] = pessoaSalva?.Id;

            ViewData["SubTitulo"] = "Edição";
            ViewData["Edicao"] = true;
            ViewData["Titulo"] = "Cliente";
            ViewData["AspController"] = "Cliente";
            ViewData["AspAction"] = "List";
            ViewData["FontIcon"] = "fa-users";

            return View("DetalhePessoa", pessoaSalva);
        }        


        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
