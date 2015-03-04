using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.Entities;

namespace UnitOfWorkNamespace.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
        }

        public List<User> Users { get; set; }
    }
}