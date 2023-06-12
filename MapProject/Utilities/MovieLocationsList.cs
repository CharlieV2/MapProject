using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapProject.Utilities
{
    public static class MovieLocationsList
    {
        private static List<MovieLocation> Locations = new List<MovieLocation>();

        public static void Add(MovieLocation location)
        {
            Locations.Add(location);
            Storage.SaveLocations(Locations);
        }

        public static List<MovieLocation> Get()
        {
            return Locations;
        }

        public static void Update()
        {
            Locations.Clear();
            Locations = Storage.LoadLocations();
        }
    }
}
