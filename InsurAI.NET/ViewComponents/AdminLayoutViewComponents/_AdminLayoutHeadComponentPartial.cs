using Microsoft.AspNetCore.Mvc;

namespace InsurAI.NET.ViewComponents.AdminLayoutViewComponents
{ 
    // ViewComponent'ler, ASP.NET Core'da bir sayfanın belirli kısmını (örneğin header, footer, sidebar gibi)
    // dinamik olarak render etmeye yarayan küçük, yeniden kullanılabilir bileşenlerdir.
    public class _AdminLayoutHeadComponentPartial : ViewComponent
    {
        // Bu metot çalıştığında, ilgili ViewComponent'in çıktısını üretir.
        // Örneğin bu "head" kısmı, layout’un <head> bölümüne CSS/JS, meta tag gibi içerikler ekleyebilir.
        public IViewComponentResult Invoke()
        {
            // View() metodu, bu ViewComponent'e ait Razor View dosyasını render eder.
            // Yani /Views/Shared/Components/_AdminLayoutHeadComponentPartial/Default.cshtml dosyasını çağırır.
            return View();
        }
    }
}
