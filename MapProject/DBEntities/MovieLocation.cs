using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapProject
{
    public class MovieLocation
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Producer { get; set; }
        public string MovieDescription { get; set; }
        public string LocationDescription { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        
        public MovieLocation(string name, int year, string genre, string producer, string movieDescription, string locationDescription, double latitude, double longitude)
        {
            Name = name;
            Year = year;
            Genre = genre;
            Producer = producer;
            MovieDescription = movieDescription;
            LocationDescription = locationDescription;
            Latitude = latitude;
            Longitude = longitude;           
        }

    }
}
