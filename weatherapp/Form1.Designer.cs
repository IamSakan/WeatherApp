namespace weatherapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelMestoDisp = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelSunrise = new System.Windows.Forms.Label();
            this.labelSunset = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxWeather = new System.Windows.Forms.PictureBox();
            this.pictureBoxHumidity = new System.Windows.Forms.PictureBox();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.pictureBoxWind = new System.Windows.Forms.PictureBox();
            this.labelWind = new System.Windows.Forms.Label();
            this.comboBoxMesto = new System.Windows.Forms.ComboBox();
            this.buttonOblacila = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMoreInfo = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWind)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(787, 545);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(284, 87);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelMestoDisp
            // 
            this.labelMestoDisp.BackColor = System.Drawing.Color.Transparent;
            this.labelMestoDisp.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMestoDisp.ForeColor = System.Drawing.Color.White;
            this.labelMestoDisp.Location = new System.Drawing.Point(518, 168);
            this.labelMestoDisp.Name = "labelMestoDisp";
            this.labelMestoDisp.Size = new System.Drawing.Size(844, 96);
            this.labelMestoDisp.TabIndex = 2;
            this.labelMestoDisp.Text = "Ime mesta";
            this.labelMestoDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCondition
            // 
            this.labelCondition.BackColor = System.Drawing.Color.Transparent;
            this.labelCondition.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCondition.ForeColor = System.Drawing.Color.White;
            this.labelCondition.Location = new System.Drawing.Point(862, 350);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(141, 36);
            this.labelCondition.TabIndex = 4;
            this.labelCondition.Text = "Condition";
            this.labelCondition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDetails
            // 
            this.labelDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelDetails.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDetails.ForeColor = System.Drawing.Color.White;
            this.labelDetails.Location = new System.Drawing.Point(862, 396);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(141, 36);
            this.labelDetails.TabIndex = 5;
            this.labelDetails.Text = "Details";
            this.labelDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSunrise
            // 
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labelSunrise.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSunrise.ForeColor = System.Drawing.Color.White;
            this.labelSunrise.Location = new System.Drawing.Point(217, 42);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Size = new System.Drawing.Size(50, 25);
            this.labelSunrise.TabIndex = 8;
            this.labelSunrise.Text = "N/A";
            // 
            // labelSunset
            // 
            this.labelSunset.AutoSize = true;
            this.labelSunset.BackColor = System.Drawing.Color.Transparent;
            this.labelSunset.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSunset.ForeColor = System.Drawing.Color.White;
            this.labelSunset.Location = new System.Drawing.Point(217, 155);
            this.labelSunset.Name = "labelSunset";
            this.labelSunset.Size = new System.Drawing.Size(50, 25);
            this.labelSunset.TabIndex = 9;
            this.labelSunset.Text = "N/A";
            // 
            // labelTemp
            // 
            this.labelTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelTemp.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTemp.ForeColor = System.Drawing.Color.Transparent;
            this.labelTemp.Location = new System.Drawing.Point(862, 275);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(141, 55);
            this.labelTemp.TabIndex = 10;
            this.labelTemp.Text = "N/A";
            this.labelTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(137, 33);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(137, 143);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxWeather
            // 
            this.pictureBoxWeather.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWeather.Location = new System.Drawing.Point(837, 72);
            this.pictureBoxWeather.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxWeather.Name = "pictureBoxWeather";
            this.pictureBoxWeather.Size = new System.Drawing.Size(210, 94);
            this.pictureBoxWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWeather.TabIndex = 21;
            this.pictureBoxWeather.TabStop = false;
            // 
            // pictureBoxHumidity
            // 
            this.pictureBoxHumidity.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHumidity.Location = new System.Drawing.Point(406, 143);
            this.pictureBoxHumidity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxHumidity.Name = "pictureBoxHumidity";
            this.pictureBoxHumidity.Size = new System.Drawing.Size(63, 43);
            this.pictureBoxHumidity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHumidity.TabIndex = 22;
            this.pictureBoxHumidity.TabStop = false;
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.BackColor = System.Drawing.Color.Transparent;
            this.labelHumidity.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHumidity.ForeColor = System.Drawing.Color.White;
            this.labelHumidity.Location = new System.Drawing.Point(492, 155);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(50, 25);
            this.labelHumidity.TabIndex = 23;
            this.labelHumidity.Text = "N/A";
            // 
            // pictureBoxWind
            // 
            this.pictureBoxWind.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWind.Location = new System.Drawing.Point(406, 33);
            this.pictureBoxWind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxWind.Name = "pictureBoxWind";
            this.pictureBoxWind.Size = new System.Drawing.Size(63, 43);
            this.pictureBoxWind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWind.TabIndex = 24;
            this.pictureBoxWind.TabStop = false;
            // 
            // labelWind
            // 
            this.labelWind.AutoSize = true;
            this.labelWind.BackColor = System.Drawing.Color.Transparent;
            this.labelWind.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWind.ForeColor = System.Drawing.Color.White;
            this.labelWind.Location = new System.Drawing.Point(492, 42);
            this.labelWind.Name = "labelWind";
            this.labelWind.Size = new System.Drawing.Size(50, 25);
            this.labelWind.TabIndex = 25;
            this.labelWind.Text = "N/A";
            // 
            // comboBoxMesto
            // 
            this.comboBoxMesto.AllowDrop = true;
            this.comboBoxMesto.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMesto.FormattingEnabled = true;
            this.comboBoxMesto.Location = new System.Drawing.Point(518, 446);
            this.comboBoxMesto.Name = "comboBoxMesto";
            this.comboBoxMesto.Size = new System.Drawing.Size(844, 81);
            this.comboBoxMesto.TabIndex = 26;
            // 
            // buttonOblacila
            // 
            this.buttonOblacila.BackColor = System.Drawing.Color.Transparent;
            this.buttonOblacila.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOblacila.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOblacila.ForeColor = System.Drawing.Color.White;
            this.buttonOblacila.Location = new System.Drawing.Point(1134, 566);
            this.buttonOblacila.Name = "buttonOblacila";
            this.buttonOblacila.Size = new System.Drawing.Size(139, 51);
            this.buttonOblacila.TabIndex = 27;
            this.buttonOblacila.Text = "Clothes Recommendation";
            this.buttonOblacila.UseVisualStyleBackColor = false;
            this.buttonOblacila.Click += new System.EventHandler(this.buttonOblacila_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelWind);
            this.panel1.Controls.Add(this.pictureBoxWind);
            this.panel1.Controls.Add(this.labelHumidity);
            this.panel1.Controls.Add(this.pictureBoxHumidity);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labelSunset);
            this.panel1.Controls.Add(this.labelSunrise);
            this.panel1.Location = new System.Drawing.Point(589, 661);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 216);
            this.panel1.TabIndex = 28;
            // 
            // buttonMoreInfo
            // 
            this.buttonMoreInfo.BackColor = System.Drawing.Color.Transparent;
            this.buttonMoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoreInfo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMoreInfo.ForeColor = System.Drawing.Color.White;
            this.buttonMoreInfo.Location = new System.Drawing.Point(589, 566);
            this.buttonMoreInfo.Name = "buttonMoreInfo";
            this.buttonMoreInfo.Size = new System.Drawing.Size(139, 51);
            this.buttonMoreInfo.TabIndex = 29;
            this.buttonMoreInfo.Text = "More Info";
            this.buttonMoreInfo.UseVisualStyleBackColor = false;
            this.buttonMoreInfo.Click += new System.EventHandler(this.buttonMoreInfo_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonClose.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.ForeColor = System.Drawing.Color.Black;
            this.buttonClose.Location = new System.Drawing.Point(837, 904);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(166, 65);
            this.buttonClose.TabIndex = 30;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1818, 931);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonMoreInfo);
            this.Controls.Add(this.buttonOblacila);
            this.Controls.Add(this.comboBoxMesto);
            this.Controls.Add(this.pictureBoxWeather);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.labelMestoDisp);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather App ©";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWind)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonSearch;
        private Label labelMestoDisp;
        private Label labelCondition;
        private Label labelDetails;
        private Label labelSunrise;
        private Label labelSunset;
        private Label labelTemp;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBoxWeather;
        private PictureBox pictureBoxHumidity;
        private Label labelHumidity;
        private PictureBox pictureBoxWind;
        private Label labelWind;
        private ComboBox comboBoxMesto;
        private Button buttonOblacila;
        private Panel panel1;
        private Button buttonMoreInfo;
        private Button buttonClose;
    }
}