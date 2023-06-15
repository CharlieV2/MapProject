using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapProject.CustomControls
{
    public class MyCycleSwitchButton : Button
    {
        #region СВОЙСТВА ЗАЦИКЛЕННОГО ПЕРЕКЛЮЧАТЕЛЯ

        [Category("Настройка")]
        [Description("Переключаемые значения через точку с запятой")]
        public string Values { get; set; } = "0;1;2";

        private List<string> ValuesList { get; set; } = new List<string>() { "0", "1", "2" };


        [Category("Настройка")]
        [Description("Текущий индекс значения")]
        public int CurrentIndex { get; set; } = 0;

        [Category("Настройка")]
        [Description("Базовый текст (Необязательно). Текст кнопки = Базовый текст + пробел + текущее значение")]
        public string BaseText { get; set; }

        #endregion

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (!string.IsNullOrEmpty(Values))
            {
                ValuesList = Values.Split(';').ToList();
            }

            TextUpdate();
        }

        protected override void OnClick(EventArgs e)
        {
            CurrentIndex = (CurrentIndex + 1) % ValuesList.Count;

            TextUpdate();

            base.OnClick(e);
        }

        protected void TextUpdate()
        {
            if (string.IsNullOrEmpty(BaseText))
            {
                Text = ValuesList[CurrentIndex];
            }
            else
            {
                Text = BaseText + " " + ValuesList[CurrentIndex];
            }
        }

        public string GetCurrentValue()
        {
            return ValuesList[CurrentIndex];
        }

        public string GetValueAt(int index)
        {
            try
            {
                return ValuesList[index];
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

    }
}
