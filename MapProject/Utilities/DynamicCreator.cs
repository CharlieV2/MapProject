using MapProject.CustomControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapProject.Utilities
{
    public static class DynamicCreator
    {
        public static MyClickablePictureBox CreateClickablePictureBox(Image image, Size size)
        {
            MyClickablePictureBox pictureBox = new MyClickablePictureBox();
            pictureBox.Image = image;
            pictureBox.Size = size;
            pictureBox.BackColor = SystemColors.ActiveCaption;
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            return pictureBox;
        }
    }
}
