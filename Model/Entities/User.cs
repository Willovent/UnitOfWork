using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class User   
    {
        public User()
        {
            
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //virtual pour le lazyloading 
        public virtual List<Dog> Dogs { get; set; }
    }
}
