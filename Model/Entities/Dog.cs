using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Dog
    {
        public Dog()
        {
            
        }

        public int DogId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Avatar { get; set; }

        //virtual pour le lazyloading 
        public virtual User Owner { get; set; }
    }
}
