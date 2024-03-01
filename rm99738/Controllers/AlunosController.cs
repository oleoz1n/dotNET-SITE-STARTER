using Microsoft.AspNetCore.Mvc;
using rm99738.Models;

namespace rm99738.Controllers
{
    public class AlunosController : Controller
    {
        public IActionResult Index()
        {
            Aluno aluno = new Aluno("Leo","Leo@email.com");

            return View();
        }
    }
}
