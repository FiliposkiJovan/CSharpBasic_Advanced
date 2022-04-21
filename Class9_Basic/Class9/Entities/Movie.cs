using Class9.Enums;
using Class9.Exeptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class9
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }

        public Movie(string title, Genre genre, int rating)
        {
            if(rating > 5 || rating < 1)
            {
                throw new InvalidRatingExeption($"The rating {rating} has to be between 1 and 5");
            }

            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = 5*rating;
        }
    }
}