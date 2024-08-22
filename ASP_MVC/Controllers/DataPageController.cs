using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Xml.Linq;

namespace ASP_MVC.Controllers
{
    public class DataPageController : Controller
    {
        // 
        // GET: /DataPage/
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /DataPage/Welcome/ 
        // add params and this can be taken in with url like
        // 
        // GET: localhost:port/DataPage/Welcome/ ?name=Rick&numtimes=4
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
        // localhost:port/DataPage/Bye/3?name=Rick
        public string Bye(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }


    }
}
