using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Yandex.Maps.StaticAPI;
using Yandex.Maps.StaticAPI.PL;
using Yandex.Maps.StaticAPI.PT;
using MapProject.Utilities;

namespace MapProject
{
    public partial class MapPage : Form
    {
        public MapPage()
        {
            InitializeComponent();
            InitializePages();
            LoadData();
        }

        private void LoadData()
        {
            GlobalVariables.MovieLocations = Storage.LoadLocations();
            search.Items.AddRange(GlobalVariables.MovieLocations.Select(locations => locations.Name).ToArray());
        }

        private void adminPanelButton_Click(object sender, EventArgs e)
        {
            adminPage.Visible = true;
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            search.Items.Clear();

            search.Items.AddRange(GlobalVariables.MovieLocations
                .Where(location => location.Name.IndexOf(search.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                .Select(location => location.Name)
                .ToArray());

            search.Select(search.Text.Length, 0);
            search.DroppedDown = true;
        }

        private void ShowInfo()
        {

        }

        private void search_SelectedIndexChanged(object sender, EventArgs e)
        {
            MovieLocation movieLocation = GlobalVariables.MovieLocations.FirstOrDefault(loc => loc.Name.ToLower() == search.Text.ToLower());

            if (movieLocation != null)
            {
                titleLabel.Text = movieLocation.Name;
                yearLabel.Text = movieLocation.Year.ToString();
                genreLabel.Text = movieLocation.Genre;
                producerLabel.Text = movieLocation.Producer;
                movieDescription.Text = movieLocation.MovieDescription;
                locationDescription.Text = movieLocation.LocationDescription;

                mapPicture.Load(GetMap(movieLocation.Latitude, movieLocation.Longitude));
            }
        }



        private string GetMap(double latitude, double longitude)
        {
            L l = new L(true, satellite, false, false);
            LL ll = new LL(latitude, longitude);

            Yandex.Maps.StaticAPI.Size size = new Yandex.Maps.StaticAPI.Size(405, 500);
            Lang lang = new Lang(Lang.Lang_reg.ru_RU);


            Pm2 pm1 = new Pm2(latitude, longitude, Pm2.Color.bl, Pm2.Size.m);

            List<MarkBase> listMark = new List<MarkBase>() { pm1 };
            Pt pt = new Pt(listMark);



            StaticAPI map1 = new StaticAPI(l, ll, zoom, size, lang, pt: pt);
            string urlMap1 = map1.GetPictureURL();

            return urlMap1;
        }


        bool satellite = false;
        int zoom = 7;

        private void satelliteSwitch_Click(object sender, EventArgs e)
        {
            if (satellite)
            {
                satellite = false;
                satelliteSwitch.Text = "Спутник: Выкл";
            }
            else
            {
                satellite = true;
                satelliteSwitch.Text = "Спутник: Вкл";
            }

            search_SelectedIndexChanged(null, null);
        }

        private void zoomSwitch_Click(object sender, EventArgs e)
        {
            switch (zoom)
            {
                case 5:
                    zoomSwitch.Text = "Zoom: 7";
                    zoom = 7;
                    break;
                case 7:
                    zoomSwitch.Text = "Zoom: 10";
                    zoom = 10;
                    break;
                case 10:
                    zoomSwitch.Text = "Zoom: 5";
                    zoom = 5;
                    break;
                default:
                    zoomSwitch.Text = "Zoom: 7";
                    zoom = 7;
                    break;

            }

            search_SelectedIndexChanged(null, null);
        }
    }
}
