using System;
using System.Web.Mvc;
using Model;
using Model.Entities;
using UnitOfWorkNamespace.Models;
using System.Collections.Generic;

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
            _unitOfWork.UserRepository.Truncate();

            _unitOfWork.UserRepository.Add(new User
            {
                Name = "Stark",
                FirstName = "Arya",
                Age = 13,
                Avatar = "http://ovent.net/UnitOfWOrkFiles/Arya/arya.jpg",
                Dogs = new List<Dog>
                {
                   new Dog{
                       Name = "Nymeria",
                       Age = 3,
                       Avatar = "http://ovent.net/UnitOfWOrkFiles/Arya/Nymeria.jpg",
                   }
                }
            });

            _unitOfWork.UserRepository.Add(new User
            {
                Name = "Stark",
                FirstName = "Bran",
                Age = 15,
                Avatar = "http://ovent.net/UnitOfWOrkFiles/Bran/bran.jpg",
                Dogs = new List<Dog>
                {
                   new Dog{
                       Name = "Summer",
                       Age = 3,
                       Avatar = "http://ovent.net/UnitOfWOrkFiles/Bran/Summer.jpg",
                   }
                }
            });

            _unitOfWork.UserRepository.Add(new User
            {
                Name = "Snow",
                FirstName = "Jon",
                Age = 20,
                Avatar = "http://ovent.net/UnitOfWOrkFiles/Jon/Jon.jpg",
                Dogs = new List<Dog>
                {
                   new Dog{
                       Name = "Ghost",
                       Age = 3,
                       Avatar = "http://ovent.net/UnitOfWOrkFiles/Jon/ghost.jpg",
                   }
                }
            });

            _unitOfWork.UserRepository.Add(new User
            {
                Name = "Stark",
                FirstName = "Robb",
                Age = 21,
                Avatar = "http://ovent.net/UnitOfWOrkFiles/Robb/robb.jpg",
                Dogs = new List<Dog>
                {
                   new Dog{
                       Name = "Grey Wind",
                       Age = 3,
                       Avatar = "http://ovent.net/UnitOfWOrkFiles/Robb/grey-wind.png",
                   }
                }
            });

            _unitOfWork.UserRepository.Add(new User
            {
                Name = "Stark",
                FirstName = "Sansa",
                Age = 16,
                Avatar = "http://ovent.net/UnitOfWOrkFiles/Sansa/sansa.jpg",
                Dogs = new List<Dog>
                {
                   new Dog{
                       Name = "Summer",
                       Age = 3,
                       Avatar = "http://ovent.net/UnitOfWOrkFiles/Sansa/lady.jpg",
                   }
                }
            });

            _unitOfWork.UserRepository.Add(new User
            {
                Name = "Hilton",
                FirstName = "Paris",
                Age = 34,
                Avatar = "http://ovent.net/UnitOfWOrkFiles/Paris%20Hilton/paris-hilton.jpg",
                Dogs = new List<Dog>
                {
                   new Dog{
                       Name = "Barak",
                       Age = 4,
                       Avatar = "http://ovent.net/UnitOfWOrkFiles/Paris%20Hilton/barak.jpg",
                   }, 
                   new Dog{
                       Name = "Fuzy",
                       Age = 5,
                       Avatar = "http://ovent.net/UnitOfWOrkFiles/Paris%20Hilton/fuzy.jpg",
                   }, 
                   new Dog{                      
                       Name = "Mussy",
                       Age = 7,
                       Avatar = "http://ovent.net/UnitOfWOrkFiles/Paris%20Hilton/mussy.jpg",
                   }, 
                   new Dog{
                       Name = "Puppy",
                       Age = 2,
                       Avatar = "http://ovent.net/UnitOfWOrkFiles/Paris%20Hilton/puppy.jpg",
                   }, 
                   new Dog{
                       Name = "Shy",
                       Age = 2,
                       Avatar = "http://ovent.net/UnitOfWOrkFiles/Paris%20Hilton/shy.jpg",
                   },
                }
            });
            
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}