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

    }
}