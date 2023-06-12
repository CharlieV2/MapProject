using MapProject.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapProject.Pages
{
    public partial class AdminPage : UserControl
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MovieLocation location = new MovieLocation(txtTitle.Text,
                                                       txtYear.Text,
                                                       txtGenre.Text,
                                                       txtProducer.Text,
                                                       txtMovieDescription.Text,
                                                       txtLocationDescription.Text,
                                                       txtPhotos.Text,
                                                       double.Parse(txtLatitude.Text.Replace('.', ',')),
                                                       double.Parse(txtLongitude.Text.Replace('.', ',')));

            MovieLocationsList.Add(location);
            clearButton_Click(null, null);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is TextBoxBase textBox)
                {
                    textBox.Clear();
                }
            }
        }
    }
}
