using Algorithms.Models;
using Microsoft.AspNetCore.Mvc;

namespace Algorithms.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index() 
    {
      return View();
    }
  }
}