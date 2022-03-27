using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Windo.Application.Contratos;
using Windo.Application.Dtos;
namespace WindoWeb.Controllers
{
       
    public class ClienteController : Controller
    {
        private readonly IPessoaService pessoaService;

        public ClienteController(IPessoaService pessoaService)
        {
            this.pessoaService = pessoaService;
        }
        // GET: ClienteController

        [HttpGet]
        [Authorize(Roles = "Comercial")]       
        public async Task<ActionResult> List(string stringBuscaPessoa)
        {
            
            var cliente = stringBuscaPessoa == null
                            ? await this.pessoaService.GetAllAsync(100)
                            : await this.pessoaService.SearchByNomeOrEmailAsync(stringBuscaPessoa);

            this.SetViewData("Listagem", false);
            ViewData["stringBuscaPessoa"] = stringBuscaPessoa;

            return View(cliente.ToList());
        }
       
        [Authorize(Roles ="Comercial")]        
        public ActionResult Create()
        {
            this.SetViewData("Cadastro", false);

            return View("DetalhePessoa");
        }

        
        [HttpPost]
        [Authorize(Roles = "Comercial")]       
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
            var subtitulo = "";
            var edicao = false;

            if (pessoaSalva?.Id == 0)
                subtitulo = "Cadastro";
            else
            {
                subtitulo = "Edição";
                edicao = true;
            }

            this.SetViewData(subtitulo, edicao);

            return View("DetalhePessoa",pessoa);
        }

        [Authorize(Roles = "Comercial")]        
        public async Task<ActionResult> Edit(int id)
        {
            var pessoaSalva = await this.pessoaService.GetByIdAsync(id);
            ViewData["Id"] = pessoaSalva?.Id;

            this.SetViewData("Edição",true);            

            return View("DetalhePessoa", pessoaSalva);
        }

        [HttpPost]
        [Authorize(Roles = "Gerencia")]              
        public ActionResult Delete(int id)
        {
            return View();
        }
        

        private void SetViewData(string subTitulo,bool edicao)
        {
            ViewData["Titulo"]  = "Clientes";
            ViewData["SubTitulo"] = subTitulo;
            ViewData["Edicao"] = edicao;
            ViewData["AspController"] = "Cliente";
            ViewData["AspAction"] = "List";
            ViewData["FontIcon"] = "fa-users";
        }
    }
}
