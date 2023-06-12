using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapProject.Properties;
using Newtonsoft.Json;

namespace MapProject.Utilities
{
    public static class Storage
    {
        private static string _saveDirectoryName = "MapProject";
        private static string _saveLocationsFileName = "Locations";
        private static string _saveExtension = ".txt";    

        public static void SaveLocations(List<MovieLocation> locations)
        {
            DirectoryCheck();

            string saveJson = JsonConvert.SerializeObject(locations, Formatting.Indented);            
            File.WriteAllText(GetSavePath(), saveJson);
        }

        public static List<MovieLocation> LoadLocations()
        {
            DirectoryCheck();

            if (File.Exists(GetSavePath()))
            {
                string loadJson = File.ReadAllText(GetSavePath());
                List<MovieLocation> locations = JsonConvert.DeserializeObject<List<MovieLocation>>(loadJson);

                return locations;
            }

            return new List<MovieLocation>();
        }

        private static string GetSavePath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                                ApplicationData),
                                _saveDirectoryName,
                                _saveLocationsFileName + _saveExtension);
        }

        private static void DirectoryCheck()
        {
            if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), _saveDirectoryName)))
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), _saveDirectoryName));
            }
        }
    }
}
