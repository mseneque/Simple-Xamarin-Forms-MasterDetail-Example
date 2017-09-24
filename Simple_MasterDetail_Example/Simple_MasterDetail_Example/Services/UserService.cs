using Simple_MasterDetail_Example.Models;
using System.Collections.Generic;
using System.Linq;

namespace Simple_MasterDetail_Example.Services
{
    class UserService
    {
        private List<User> _users = new List<User>
        {
            new User
            {
                Id = 1,
                Name = "Jenny Dalby",
                Description = "Hi, My name is Jenny Dalby"
            },
            new User
            {
                Id = 2,
                Name = "Jonv",
                Description = "Nothing will bring you peace, you must bring yourself to it."
            },
            new User
            {
                Id = 3,
                Name = "Rachel Martin",
                Description = "Have enough courage to trust love one more time and always one more time."
            },
            new User
            {
                Id = 4,
                Name = "Nivan Jay",
                Description = "You cannot start the next chapter of your life if you keep re-reading the last one."
            },
            new User
            {
                Id = 5,
                Name = "SanazZ",
                Description = "What worries you masters you."
            },
            new User
            {
                Id = 6,
                Name = "NextLab",
                Description = "You don't have to be great to start, but you have to start to be great."
            },
            new User
            {
                Id = 7,
                Name = "Alex B",
                Description = "It is more important to know where you are going than to get there quickly. Do not mistake activity for achievement."
            },
            new User
            {
                Id = 8,
                Name = "Tara Chang",
                Description = "Unless you try to do something beyond what you have already mastered you will never grow."
            },
            new User
            {
                Id = 9,
                Name = "Tom K",
                Description = "Ask what makes you come alive and go do it. Because what the world needs is people who have come alive"
            },
            new User
            {
                Id = 10,
                Name = "Matty S",
                Description = "While we are postponing, life speeds by."
            }
        };

        public User GetUser(int id)
        {
            return _users.FirstOrDefault(s => s.Id == id);
        }

    }
}
