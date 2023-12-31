﻿using System;
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
using System.Resources;
using MapProject.CustomControls;
using Size = System.Drawing.Size;

namespace MapProject
{
    public partial class MapPage : Form
    {
        public MapPage()
        {
            InitializeComponent();
            InitializePages();
            MovieLocationsList.Update();
            LoadData();
        }

        private void LoadData()
        {
            search.Items.AddRange(MovieLocationsList.Get().Select(locations => locations.Name).ToArray());
        }

        private void adminPanelButton_Click(object sender, EventArgs e)
        {
            adminPage.Visible = true;
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            search.Items.Clear();

            search.Items.AddRange(MovieLocationsList.Get()
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
            MovieLocation movieLocation = MovieLocationsList.Get().FirstOrDefault(loc => loc.Name.ToLower() == search.Text.ToLower());

            if (movieLocation != null)
            {
                titleLabel.Text = movieLocation.Name;
                yearLabel.Text = movieLocation.Year.ToString();
                genreLabel.Text = movieLocation.Genre;
                producerLabel.Text = movieLocation.Producer;
                movieDescription.Text = movieLocation.MovieDescription;
                locationDescription.Text = movieLocation.LocationDescription;

                mapPicture.Load(GetMap(movieLocation.Latitude, movieLocation.Longitude));
                GetPhotos(movieLocation.Photos);
            }
        }


        private void GetPhotos(string photos)
        {
            photosPanel.Controls.Clear();

            // Получаем текущую сборку
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            // Создаем ResourceManager для текущей сборки
            var resourceManager = new ResourceManager(assembly.GetName().Name + ".Properties.Resources", assembly);

            string[] photosArray = photos.Split(';');
            Size size = new Size(136, 136);

            if (photosArray.Length > 6)
            {
                size = new Size(136, 120);
            }

            foreach (string item in photosArray)
            {
                MyClickablePictureBox pictureBox = DynamicCreator.CreateClickablePictureBox((Image)resourceManager.GetObject(item), size);
                photosPanel.Controls.Add(pictureBox);
            }
        }

        private string GetMap(double latitude, double longitude)
        {
            L l = new L(true, satellite, false, false);
            LL ll = new LL(latitude, longitude);

            Yandex.Maps.StaticAPI.Size size = new Yandex.Maps.StaticAPI.Size(mapPicture.Height, mapPicture.Width);
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
            zoom = int.Parse(zoomSwitch.GetCurrentValue());
    
            search_SelectedIndexChanged(null, null);
        }
    }
}
