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
        
        private readonly UnitOfWork _unitOfWork = new UnitOfWork();
        
        public ActionResult Index()
        {
            var homeViewModel = new HomeViewModel {Users = _unitOfWork.UserRepository.LastUsers()};
            return View(homeViewModel);
        }

    }
}