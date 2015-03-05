namespace Model.Migrations
{
    using Model.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Model.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Model.Context";
        }

        protected override void Seed(Model.Context context)
        {
            context.Users.AddOrUpdate(new User
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

            context.Users.AddOrUpdate(new User
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

            context.Users.AddOrUpdate(new User
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

            context.Users.AddOrUpdate(new User
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

            context.Users.AddOrUpdate(new User
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

            context.Users.AddOrUpdate(new User
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

            context.SaveChanges();
        }
    }
}
