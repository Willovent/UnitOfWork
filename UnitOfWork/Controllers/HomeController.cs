using System;
using System.Web.Mvc;
using Model;
using Model.Entities;
using UnitOfWorkNamespace.Models;

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

        public ActionResult FillBase()
        {
            var rand = new Random();
            for (var i = 0; i < 10; i++)
            {
                var user = new User
                {
                    Age = rand.Next(5, 80),
                    Name = "Marcus",
                    FirstName = string.Format("Kevin {0}", i),
                };
                _unitOfWork.UserRepository.Add(user);
                for (var j = 0; j < rand.Next(1,5); j++)
                {
                    var dog = new Dog
                    {
                        Age = rand.Next(5, 15),
                        Name = string.Format("Filou {0}", j*i),
                        Owner = user
                    };
                    _unitOfWork.DogRepository.Add(dog);

                }
            }
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}