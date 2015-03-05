using Model.Utils;

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
                Name = "Hilton",
                FirstName = "Paris",
                Age = 34,
                Sex = Sex.Female,
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
            #region 101 dalmatiens

            var rand = new Random();

            var user = new User
            {
                Name = "D'enfer",
                FirstName = "Cruella",
                Age = 45,
                Sex = Sex.Female,
                Avatar = "http://ovent.net/UnitOfWOrkFiles/Cruella/cruella.jpg",
                Dogs = new List<Dog>(),
            };

            for (var i = 0; i < 101; i++)
            {
                var dog = new Dog
                {
                    Name = "Dalamatien " + i,
                    Age = rand.Next(1,5),
                    Avatar = string.Format("http://ovent.net/UnitOfWOrkFiles/Cruella/{0}.jpg",rand.Next(1,7)),
                };
                user.Dogs.Add(dog);
            }
            context.Users.AddOrUpdate(user);

            #endregion

            context.Users.AddOrUpdate(new User
            {
                Name = "Stark",
                FirstName = "Arya",
                Age = 13,
                Sex = Sex.Female,
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
                Name = "Rogers",
                FirstName = "Sammy",
                Age = 19,
                Sex = Sex.Male,
                Avatar = "http://ovent.net/UnitOfWOrkFiles/Sammy/sammy.jpg",
                Dogs = new List<Dog>
                {
                   new Dog{
                       Name = "Scooby Doo",
                       Age = 19,
                       Avatar = "http://ovent.net/UnitOfWOrkFiles/Sammy/scooby.jpg",
                   }
                }
            });

            context.Users.AddOrUpdate(new User
            {
                Name = "Garfield",
                FirstName = "",
                Age = 10,
                Sex = Sex.Male,
                Avatar = "http://ovent.net/UnitOfWOrkFiles/Garfield/garfield.jpg",
                Dogs = new List<Dog>
                {
                   new Dog{
                       Name = "Oddy",
                       Age = 3,
                       Avatar = "http://ovent.net/UnitOfWOrkFiles/Garfield/oddy.jpg",
                   }
                }
            });

            context.Users.AddOrUpdate(new User
            {
                Name = "Stark",
                FirstName = "Bran",
                Age = 15,
                Sex = Sex.Male,
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
                Sex = Sex.Male,
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
                Name = "Gargamel",
                FirstName = "",
                Age = 99,
                Sex = Sex.Male,
                Avatar = "http://ovent.net/UnitOfWOrkFiles/Gargamel/gargamel.jpg",
                Dogs = new List<Dog>
                {
                   new Dog{
                       Name = " Azrael",
                       Age = 27,
                       Avatar = "http://ovent.net/UnitOfWOrkFiles/Gargamel/azrael.jpg",
                   }
                }
            });

            context.Users.AddOrUpdate(new User
            {
                Name = "Stark",
                FirstName = "Robb",
                Sex = Sex.Male,
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
                Sex = Sex.Female,
                Avatar = "http://ovent.net/UnitOfWOrkFiles/Sansa/sansa.jpg",
                Dogs = new List<Dog>
                {
                   new Dog{
                       Name = "Lady",
                       Age = 3,
                       Avatar = "http://ovent.net/UnitOfWOrkFiles/Sansa/lady.jpg",
                   }
                }
            });
            
            context.SaveChanges();
        }
    }
}
