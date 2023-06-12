using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MapProject
{
    public class MySwitchButton : PictureBox
    {
        #region СВОЙСТВА ПЕРЕКЛЮЧАТЕЛЯ

        [Category("Изображение")]
        [Description("Состояние переключателя")]
        public bool Switch { get; set; }


        [Category("Изображение")]
        [Description("Определяет изображение, отображаемое при выключенном переключателе.")]
        public Image SwitchOffImage_Default { get; set; }

        [Category("Изображение")]
        [Description("Определяет изображение, отображаемое при выключенном переключателе при наведении на него мышью.")]
        public Image SwitchOffImage_Active { get; set; }


        [Category("Изображение")]
        [Description("Определяет изображение, отображаемое при включённом переключателе.")]
        public Image SwitchOnImage_Default { get; set; }

        [Category("Изображение")]
        [Description("Определяет изображение, отображаемое при включённом переключателе при наведении на него мышью.")]
        public Image SwitchOnImage_Active { get; set; }

        #endregion


        public MySwitchButton()
        {
            SizeMode = PictureBoxSizeMode.Zoom;
        }


        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            if (Switch)
                Image = SwitchOnImage_Active;
            else
                Image = SwitchOffImage_Active;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            if (Switch)
                Image = SwitchOnImage_Default;
            else
                Image = SwitchOffImage_Default;
        }

        protected override void OnClick(EventArgs e)
        {
            Switch = !Switch;

            if (Switch)
                Image = SwitchOnImage_Active;
            else
                Image = SwitchOffImage_Active;

            base.OnClick(e);
        }
    }
}
