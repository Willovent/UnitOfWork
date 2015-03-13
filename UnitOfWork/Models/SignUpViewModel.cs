using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Model.Entities;

namespace UnitOfWorkNamespace.Models
{
    public class SignUpViewModel
    {
        public SignUpViewModel()
        {
        }

        public SignUpViewModel(User user)
        {
            this.FirstName = user.FirstName;
            this.Name = user.Name;
        }
        
        [Required]
        [DisplayName("Nom")]
        [MinLength(10, ErrorMessage = "Le champ {0} doit faire au minimun {1} caractères")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Prénom")]
        [MinLength(10,ErrorMessage = "Le champ {0} doit faire au minimun {1} caractères")]
        public string FirstName { get; set; }
        
        public User getUserModel(User user)
        {
            user.Name = Name;
            user.FirstName = FirstName;
            return user;
        }

    }
}