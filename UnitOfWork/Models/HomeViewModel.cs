using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Model.Entities;

namespace UnitOfWorkNamespace.Models
{
    public class HomeViewModel
    {

        public HomeViewModel()
        {
            Users = new List<User>();
        }

        public List<User> Users { get; set; }

        #region ViewModel
        
        [Required]
        [DisplayName("Nom")]
        [MinLength(10,ErrorMessage = "Le champ {0} doit faire au minimun {1} caractères")]
        public string Name { get; set; }


        public HomeViewModel(User user)
        {
            this.Name = user.Name;
        }

        public User GetModel(User user)
        {
            user.Name = this.Name;
            return user;
        }

        #endregion
    }
}