using System.Web.Mvc;
using Model;
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

        [HttpPost]
        public ActionResult Index(HomeViewModel homeViewModel)
        {
            if (ModelState.IsValid)
            {
                homeViewModel.Name = "SUCCESS";
            }
            return View(homeViewModel);
        }
        #endregion

    }
}