﻿using System.Collections.Generic;
using Model.Utils;

namespace Model.Entities
{
    public class User   
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Avatar { get; set; }

        public Sex Sex { get; set; }

        //virtual pour le lazyloading 
        public virtual List<Dog> Dogs { get; set; }
    }
}
