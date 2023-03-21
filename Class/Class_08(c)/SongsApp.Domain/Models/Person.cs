using SongsApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsApp.Domain.Models
{
    public class Person
    {
        private int _id { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Songs> Songs { get; set; }//This is a list of Song objects, default value is null!!!

        public Person(int id, string firstName, string lastName, int age, Genre favoriteMusicType)
        {
            _id = new Random().Next(1,10000);
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoriteMusicType;

            Songs = new List<Songs>();//Empty list to protect ourselves.
        }
        public void GetFavSongs()
        {
            foreach(Songs song in Songs)
            {
                Console.WriteLine(song.Title);
            }
        }
    }
}
