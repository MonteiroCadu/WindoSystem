using Microsoft.AspNetCore.Mvc;

namespace WindoWeb.Components
{
    public class AddLicencaComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
