namespace Model.Entities
{
    public class Dog
    {
        public int DogId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Avatar { get; set; }
        
        //virtual pour le lazyloading 
        public virtual User Owner { get; set; }
    }
}
