
using SongsApp.Domain.Enums;

namespace SongsApp.Domain.Models
{
    public class Songs
    {
        public string Title { get; set; }
        public double Length { get; set; }
        public Genre Genre { get; set; }

        public Songs(string title, double length, Genre genre)
        {
            //TODO Validation
            Title = title;
            Length = length;
            Genre = genre;
        }
    }
}
