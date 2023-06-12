using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapProject.Properties;
using Newtonsoft.Json;

namespace MapProject.Utilities
{
    public static class Storage
    {
        private static string _saveDirectoryName = "MapProject";
        private static string _saveFileName = "Locations";
        private static string _saveExtension = ".txt";

        public static void SaveLocations(List<MovieLocation> locations)
        {
            string saveJson = JsonConvert.SerializeObject(locations, Formatting.Indented);

            File.WriteAllText(GetSavePath(), saveJson);
        }

        public static List<MovieLocation> LoadLocations()
        {
            if (File.Exists(GetSavePath()))
            {
                string loadJson = File.ReadAllText(GetSavePath());
                List<MovieLocation> locations = JsonConvert.DeserializeObject<List<MovieLocation>>(loadJson);

                return locations;
            }
            else
            {
                return new List<MovieLocation>();
            }
        }

        private static string GetSavePath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                                ApplicationData),
                                _saveDirectoryName,
                                _saveFileName,
                                _saveExtension);
        }

    }
}
