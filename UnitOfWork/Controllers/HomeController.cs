using System.Web.Mvc;
using Model;
using Model.Entities;
using UnitOfWorkNamespace.Models;

namespace UnitOfWorkNamespace.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly UnitOfWork _unitOfWork = new UnitOfWork();
        
        [HttpGet]
        public ActionResult Index()
        {
            var homeViewModel = new HomeViewModel {Users = _unitOfWork.UserRepository.LastUsers()};
            return View(homeViewModel);
        }

        #region ViewModel

        [HttpGet]
        public ActionResult SignUp()
        {
            return View(new SignUpViewModel());
        }

        [HttpPost]
        public ActionResult SignUp(SignUpViewModel signUpViewModel)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.UserRepository.Add(signUpViewModel.getUserModel(new User()));
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View();
        }


        #endregion

    }
}