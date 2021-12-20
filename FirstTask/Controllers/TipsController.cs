using FirstTask.IRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstTask.Controllers
{
    public class TipsController : Controller
    {
        private readonly ITipsRepo _repo;

        public TipsController(ITipsRepo repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            var tips = _repo.GetAllTips();
            return View(tips);
        }
    }
}
