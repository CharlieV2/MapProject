using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapProject.CustomControls
{
    public class MyClickablePictureBox : PictureBox
    {
        public MyClickablePictureBox()
        {
            this.Click += ClickablePictureBox_Click;
        }

        private void ClickablePictureBox_Click(object sender, EventArgs e)
        {
            if (this.Image != null)
            {
                Form imageForm = new Form();
                imageForm.Text = "Просмотр изображения";
                imageForm.ClientSize = new Size(this.Image.Width, this.Image.Height);
                imageForm.StartPosition = FormStartPosition.CenterParent;
                imageForm.MaximizeBox = false;
                imageForm.ShowIcon = false;
                imageForm.FormBorderStyle = FormBorderStyle.FixedSingle;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Image = this.Image;

                imageForm.Controls.Add(pictureBox);

                imageForm.ShowDialog();
            }
        }
    }
}