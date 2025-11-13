using Microsoft.AspNetCore.Mvc;

namespace InsurAI.NET.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutNavbarMenuComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
