using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBase.Infrastructure.Service;
using MyBase.Infrastructure.Data.Model;
using MyBase.Infrastructure.Core.ServiceInterface;
using MyBase.Infrastructure.DependencyResolution;
using MyBase.Domain.Core.Entities;
using MyBase.Domain.Core;



using MyBase.Infrastructure.Data;


namespace MyBase.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserMetaService _UserMetaService;

        public HomeController(IUserMetaService _userMetaService)
        {
            _UserMetaService = _userMetaService;
        }

        public ActionResult Index()
        {

            List<UserProfile> up =  _UserMetaService.GetAllUsers();
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
    }
}
