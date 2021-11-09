using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller // ao carregarmos no link chamamos este controlador
    {
        public IActionResult Index() //o método retorna a view com base no folder com nome Sellers e busca o Index.cshtml nesta pasta
        {
            return View();
        }
    }
}
