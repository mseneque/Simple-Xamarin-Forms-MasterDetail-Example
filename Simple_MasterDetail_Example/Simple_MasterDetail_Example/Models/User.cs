namespace Simple_MasterDetail_Example.Models
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl => $"http://lorempixel.com/100/100/people/{Id}";
    }
}
