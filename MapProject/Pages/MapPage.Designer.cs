using MapProject.Pages;
using System.Windows.Forms;

namespace MapProject
{
    partial class MapPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.locationDescription = new System.Windows.Forms.RichTextBox();
            this.movieDescription = new System.Windows.Forms.RichTextBox();
            this.producerLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.ComboBox();
            this.adminPanelButton = new System.Windows.Forms.Button();
            this.photosPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mapPicture = new System.Windows.Forms.PictureBox();
            this.satelliteSwitch = new MapProject.CustomControls.MyCycleSwitchButton();
            this.zoomSwitch = new MapProject.CustomControls.MyCycleSwitchButton();
            this.adminPage = new MapProject.Pages.AdminPage();
            this.authPage = new MapProject.Pages.AuthPage();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Искать";
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.locationDescription);
            this.infoPanel.Controls.Add(this.movieDescription);
            this.infoPanel.Controls.Add(this.producerLabel);
            this.infoPanel.Controls.Add(this.genreLabel);
            this.infoPanel.Controls.Add(this.yearLabel);
            this.infoPanel.Controls.Add(this.titleLabel);
            this.infoPanel.Location = new System.Drawing.Point(547, 12);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(351, 380);
            this.infoPanel.TabIndex = 6;
            // 
            // locationDescription
            // 
            this.locationDescription.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locationDescription.Location = new System.Drawing.Point(9, 244);
            this.locationDescription.Name = "locationDescription";
            this.locationDescription.ReadOnly = true;
            this.locationDescription.Size = new System.Drawing.Size(339, 129);
            this.locationDescription.TabIndex = 14;
            this.locationDescription.Text = "Описание места съёмок";
            // 
            // movieDescription
            // 
            this.movieDescription.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.movieDescription.Location = new System.Drawing.Point(9, 109);
            this.movieDescription.Name = "movieDescription";
            this.movieDescription.ReadOnly = true;
            this.movieDescription.Size = new System.Drawing.Size(339, 129);
            this.movieDescription.TabIndex = 13;
            this.movieDescription.Text = "Описание фильма";
            // 
            // producerLabel
            // 
            this.producerLabel.AutoSize = true;
            this.producerLabel.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.producerLabel.Location = new System.Drawing.Point(4, 81);
            this.producerLabel.Name = "producerLabel";
            this.producerLabel.Size = new System.Drawing.Size(88, 25);
            this.producerLabel.TabIndex = 10;
            this.producerLabel.Text = "Режиссёр";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.genreLabel.Location = new System.Drawing.Point(4, 56);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(56, 25);
            this.genreLabel.TabIndex = 9;
            this.genreLabel.Text = "Жанр";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.yearLabel.Location = new System.Drawing.Point(4, 31);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(39, 25);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.Text = "Год";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.titleLabel.Location = new System.Drawing.Point(4, 4);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(168, 28);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Название фильма";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.search.FormattingEnabled = true;
            this.search.Location = new System.Drawing.Point(84, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(457, 25);
            this.search.TabIndex = 7;
            this.search.SelectedIndexChanged += new System.EventHandler(this.search_SelectedIndexChanged);
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // adminPanelButton
            // 
            this.adminPanelButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminPanelButton.Location = new System.Drawing.Point(411, 357);
            this.adminPanelButton.Name = "adminPanelButton";
            this.adminPanelButton.Size = new System.Drawing.Size(130, 33);
            this.adminPanelButton.TabIndex = 0;
            this.adminPanelButton.TabStop = false;
            this.adminPanelButton.Text = "Админ-панель";
            this.adminPanelButton.UseVisualStyleBackColor = true;
            this.adminPanelButton.Click += new System.EventHandler(this.adminPanelButton_Click);
            // 
            // photosPanel
            // 
            this.photosPanel.AutoScroll = true;
            this.photosPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photosPanel.Location = new System.Drawing.Point(12, 398);
            this.photosPanel.Name = "photosPanel";
            this.photosPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.photosPanel.Size = new System.Drawing.Size(886, 145);
            this.photosPanel.TabIndex = 15;
            this.photosPanel.TabStop = true;
            this.photosPanel.WrapContents = false;
            // 
            // mapPicture
            // 
            this.mapPicture.Location = new System.Drawing.Point(12, 43);
            this.mapPicture.Name = "mapPicture";
            this.mapPicture.Size = new System.Drawing.Size(529, 308);
            this.mapPicture.TabIndex = 11;
            this.mapPicture.TabStop = false;
            // 
            // satelliteSwitch
            // 
            this.satelliteSwitch.BaseText = "Спутник:";
            this.satelliteSwitch.CurrentIndex = 0;
            this.satelliteSwitch.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.satelliteSwitch.Location = new System.Drawing.Point(12, 357);
            this.satelliteSwitch.Name = "satelliteSwitch";
            this.satelliteSwitch.Size = new System.Drawing.Size(130, 33);
            this.satelliteSwitch.TabIndex = 14;
            this.satelliteSwitch.Text = "Спутник: Выкл";
            this.satelliteSwitch.UseVisualStyleBackColor = true;
            this.satelliteSwitch.Values = "Выкл;Вкл";
            this.satelliteSwitch.Click += new System.EventHandler(this.satelliteSwitch_Click);
            // 
            // zoomSwitch
            // 
            this.zoomSwitch.BaseText = "Увеличение:";
            this.zoomSwitch.CurrentIndex = 1;
            this.zoomSwitch.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.zoomSwitch.Location = new System.Drawing.Point(148, 357);
            this.zoomSwitch.Name = "zoomSwitch";
            this.zoomSwitch.Size = new System.Drawing.Size(130, 33);
            this.zoomSwitch.TabIndex = 13;
            this.zoomSwitch.Text = "Увеличение: 5";
            this.zoomSwitch.UseVisualStyleBackColor = true;
            this.zoomSwitch.Values = "3;5;7;9;11;13;15";
            this.zoomSwitch.Click += new System.EventHandler(this.zoomSwitch_Click);
            // 
            // adminPage
            // 
            this.adminPage.Location = new System.Drawing.Point(0, 0);
            this.adminPage.Name = "adminPage";
            this.adminPage.Size = new System.Drawing.Size(910, 555);
            this.adminPage.TabIndex = 0;
            this.adminPage.Visible = false;
            // 
            // authPage
            // 
            this.authPage.Location = new System.Drawing.Point(0, 0);
            this.authPage.Name = "authPage";
            this.authPage.Size = new System.Drawing.Size(910, 555);
            this.authPage.TabIndex = 0;
            // 
            // MapPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 555);
            this.Controls.Add(this.photosPanel);
            this.Controls.Add(this.satelliteSwitch);
            this.Controls.Add(this.zoomSwitch);
            this.Controls.Add(this.mapPicture);
            this.Controls.Add(this.adminPanelButton);
            this.Controls.Add(this.search);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MapPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map Project";
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializePages()
        {
            this.Controls.Add(this.authPage);
            this.Controls.Add(this.adminPage);

            this.authPage.BringToFront();
            this.adminPage.BringToFront();
        }

        #endregion

        private AdminPage adminPage;
        private AuthPage authPage;
        private System.Windows.Forms.Label label1;
        private Panel infoPanel;
        private RichTextBox movieDescription;
        private Label producerLabel;
        private Label genreLabel;
        private Label yearLabel;
        private Label titleLabel;
        private ComboBox search;
        private Button adminPanelButton;
        private RichTextBox locationDescription;
        private PictureBox mapPicture;
        private CustomControls.MyCycleSwitchButton zoomSwitch;
        private CustomControls.MyCycleSwitchButton satelliteSwitch;
        private FlowLayoutPanel photosPanel;
    }
}

