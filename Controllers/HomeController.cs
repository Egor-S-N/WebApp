using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
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