using System;
using System.Web.Mvc;
using Model;
using Model.Entities;
using UnitOfWorkNamespace.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnitOfWorkNamespace.Controllers
{
    public class HomeController : Controller
    {
        //La classe à le même nom que le namespace de l'application
        private readonly UnitOfWork _unitOfWork = new UnitOfWork(new Context());


        public ActionResult Index()
        {
            var homeViewModel = new HomeViewModel {Users = _unitOfWork.UserRepository.LastUsers()};
            return View(homeViewModel);
        }

        public ActionResult Seed()
        {

            
            return RedirectToAction("Index");
        }
    }
}