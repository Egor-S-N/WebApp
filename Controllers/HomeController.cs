using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace WebProject.Controllers
{
    [ApiExplorerSettings(IgnoreApi=true)]
    [Route("[controller]")]
    public class HomeController:Controller
    {

           public ViewResult Index()
            {
                return View("t.cshtml");
            }
    }
     
}