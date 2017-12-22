using System;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        public byte NumberInStock { get; set; }

    }
}