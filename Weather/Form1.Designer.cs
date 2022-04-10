namespace Weather
{
    partial class Form
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MinimizeButoon = new System.Windows.Forms.Button();
            this.MaximizeButton = new System.Windows.Forms.Button();
            this.CloseApplicationButton = new System.Windows.Forms.Button();
            this.IconApplication = new System.Windows.Forms.PictureBox();
            this.LeftCenterPanel = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.TownAndCountry = new System.Windows.Forms.Label();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new Weather.GradientPanel();
            this.HourlyWeatherChartPanel = new System.Windows.Forms.Panel();
            this.TheDayAfterTomorrowButton = new System.Windows.Forms.Button();
            this.TomorrowWeatherButton = new System.Windows.Forms.Button();
            this.TodayWeatherButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.HumidityInPercent = new System.Windows.Forms.Label();
            this.HumidityStatus = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.VisibilityInKilometers = new System.Windows.Forms.Label();
            this.VisibilityStatus = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.WindKilometrsPerHour = new System.Windows.Forms.Label();
            this.WindStatus = new System.Windows.Forms.Label();
            this.MaxTemperature = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Sunset = new System.Windows.Forms.Label();
            this.MinTemperature = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.Sunrise = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextAboutDay = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconApplication)).BeginInit();
            this.LeftCenterPanel.SuspendLayout();
            this.HourlyWeatherChartPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.TopPanel.Controls.Add(this.MinimizeButoon);
            this.TopPanel.Controls.Add(this.MaximizeButton);
            this.TopPanel.Controls.Add(this.CloseApplicationButton);
            this.TopPanel.Controls.Add(this.IconApplication);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(960, 25);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // MinimizeButoon
            // 
            this.MinimizeButoon.BackgroundImage = global::Weather.Properties.Resources.MinimizeButton;
            this.MinimizeButoon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButoon.FlatAppearance.BorderSize = 0;
            this.MinimizeButoon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.MinimizeButoon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.MinimizeButoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButoon.Location = new System.Drawing.Point(855, 0);
            this.MinimizeButoon.Name = "MinimizeButoon";
            this.MinimizeButoon.Size = new System.Drawing.Size(35, 25);
            this.MinimizeButoon.TabIndex = 3;
            this.MinimizeButoon.UseVisualStyleBackColor = true;
            this.MinimizeButoon.Click += new System.EventHandler(this.MinimizeApplication_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.BackgroundImage = global::Weather.Properties.Resources.MaximizeButton;
            this.MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.MaximizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.Location = new System.Drawing.Point(890, 0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(35, 25);
            this.MaximizeButton.TabIndex = 2;
            this.MaximizeButton.UseVisualStyleBackColor = true;
            // 
            // CloseApplicationButton
            // 
            this.CloseApplicationButton.BackgroundImage = global::Weather.Properties.Resources.CloseButton1;
            this.CloseApplicationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseApplicationButton.FlatAppearance.BorderSize = 0;
            this.CloseApplicationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(39)))), ((int)(((byte)(28)))));
            this.CloseApplicationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.CloseApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseApplicationButton.Location = new System.Drawing.Point(925, 0);
            this.CloseApplicationButton.Name = "CloseApplicationButton";
            this.CloseApplicationButton.Size = new System.Drawing.Size(35, 25);
            this.CloseApplicationButton.TabIndex = 1;
            this.CloseApplicationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CloseApplicationButton.UseVisualStyleBackColor = true;
            this.CloseApplicationButton.Click += new System.EventHandler(this.CloseApplication_Click);
            // 
            // IconApplication
            // 
            this.IconApplication.BackColor = System.Drawing.Color.Transparent;
            this.IconApplication.BackgroundImage = global::Weather.Properties.Resources.free_icon_weather_831319;
            this.IconApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconApplication.Location = new System.Drawing.Point(1, 1);
            this.IconApplication.Name = "IconApplication";
            this.IconApplication.Size = new System.Drawing.Size(23, 23);
            this.IconApplication.TabIndex = 0;
            this.IconApplication.TabStop = false;
            this.IconApplication.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IconApplication_MouseDown);
            this.IconApplication.MouseMove += new System.Windows.Forms.MouseEventHandler(this.IconApplication_MouseMove);
            this.IconApplication.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IconApplication_MouseUp);
            // 
            // LeftCenterPanel
            // 
            this.LeftCenterPanel.BackColor = System.Drawing.Color.White;
            this.LeftCenterPanel.Controls.Add(this.label19);
            this.LeftCenterPanel.Controls.Add(this.TownAndCountry);
            this.LeftCenterPanel.Controls.Add(this.DateTimeLabel);
            this.LeftCenterPanel.Controls.Add(this.panel2);
            this.LeftCenterPanel.Controls.Add(this.gradientPanel1);
            this.LeftCenterPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftCenterPanel.Location = new System.Drawing.Point(0, 25);
            this.LeftCenterPanel.Name = "LeftCenterPanel";
            this.LeftCenterPanel.Size = new System.Drawing.Size(275, 515);
            this.LeftCenterPanel.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(13, 271);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(149, 69);
            this.label19.TabIndex = 4;
            this.label19.Text = "9°C";
            // 
            // TownAndCountry
            // 
            this.TownAndCountry.BackColor = System.Drawing.Color.Transparent;
            this.TownAndCountry.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TownAndCountry.Location = new System.Drawing.Point(22, 350);
            this.TownAndCountry.Name = "TownAndCountry";
            this.TownAndCountry.Size = new System.Drawing.Size(114, 23);
            this.TownAndCountry.TabIndex = 3;
            this.TownAndCountry.Text = "Kyiv, UA";
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateTimeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTimeLabel.Location = new System.Drawing.Point(25, 375);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(114, 23);
            this.DateTimeLabel.TabIndex = 2;
            this.DateTimeLabel.Text = "Monday, 13:55";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(20, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 1;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.Gainsboro;
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gradientPanel1.Location = new System.Drawing.Point(240, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(35, 515);
            this.gradientPanel1.TabIndex = 0;
            // 
            // HourlyWeatherChartPanel
            // 
            this.HourlyWeatherChartPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.HourlyWeatherChartPanel.Controls.Add(this.TheDayAfterTomorrowButton);
            this.HourlyWeatherChartPanel.Controls.Add(this.TomorrowWeatherButton);
            this.HourlyWeatherChartPanel.Controls.Add(this.TodayWeatherButton);
            this.HourlyWeatherChartPanel.Controls.Add(this.panel3);
            this.HourlyWeatherChartPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HourlyWeatherChartPanel.Location = new System.Drawing.Point(275, 25);
            this.HourlyWeatherChartPanel.Name = "HourlyWeatherChartPanel";
            this.HourlyWeatherChartPanel.Size = new System.Drawing.Size(685, 240);
            this.HourlyWeatherChartPanel.TabIndex = 2;
            // 
            // TheDayAfterTomorrowButton
            // 
            this.TheDayAfterTomorrowButton.FlatAppearance.BorderSize = 0;
            this.TheDayAfterTomorrowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.TheDayAfterTomorrowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.TheDayAfterTomorrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TheDayAfterTomorrowButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TheDayAfterTomorrowButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.TheDayAfterTomorrowButton.Location = new System.Drawing.Point(245, 3);
            this.TheDayAfterTomorrowButton.Name = "TheDayAfterTomorrowButton";
            this.TheDayAfterTomorrowButton.Size = new System.Drawing.Size(220, 37);
            this.TheDayAfterTomorrowButton.TabIndex = 7;
            this.TheDayAfterTomorrowButton.Text = "Day After Tomorrow";
            this.TheDayAfterTomorrowButton.UseVisualStyleBackColor = true;
            this.TheDayAfterTomorrowButton.Click += new System.EventHandler(this.TheDayAfterTomorrowButton_Click);
            // 
            // TomorrowWeatherButton
            // 
            this.TomorrowWeatherButton.FlatAppearance.BorderSize = 0;
            this.TomorrowWeatherButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.TomorrowWeatherButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.TomorrowWeatherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TomorrowWeatherButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TomorrowWeatherButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.TomorrowWeatherButton.Location = new System.Drawing.Point(116, 3);
            this.TomorrowWeatherButton.Name = "TomorrowWeatherButton";
            this.TomorrowWeatherButton.Size = new System.Drawing.Size(119, 37);
            this.TomorrowWeatherButton.TabIndex = 6;
            this.TomorrowWeatherButton.Text = "Tomorrow";
            this.TomorrowWeatherButton.UseVisualStyleBackColor = true;
            this.TomorrowWeatherButton.Click += new System.EventHandler(this.TomorrowWeatherButton_Click);
            // 
            // TodayWeatherButton
            // 
            this.TodayWeatherButton.FlatAppearance.BorderSize = 0;
            this.TodayWeatherButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.TodayWeatherButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.TodayWeatherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodayWeatherButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TodayWeatherButton.Location = new System.Drawing.Point(20, 3);
            this.TodayWeatherButton.Name = "TodayWeatherButton";
            this.TodayWeatherButton.Size = new System.Drawing.Size(86, 37);
            this.TodayWeatherButton.TabIndex = 5;
            this.TodayWeatherButton.Text = "Today";
            this.TodayWeatherButton.UseVisualStyleBackColor = true;
            this.TodayWeatherButton.Click += new System.EventHandler(this.TodayWeatherButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(20, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 1);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.HumidityInPercent);
            this.panel1.Controls.Add(this.HumidityStatus);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.VisibilityInKilometers);
            this.panel1.Controls.Add(this.VisibilityStatus);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.WindKilometrsPerHour);
            this.panel1.Controls.Add(this.WindStatus);
            this.panel1.Controls.Add(this.MaxTemperature);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Sunset);
            this.panel1.Controls.Add(this.MinTemperature);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.Sunrise);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TextAboutDay);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(275, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 275);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(34, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "UV Index";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HumidityInPercent
            // 
            this.HumidityInPercent.BackColor = System.Drawing.Color.White;
            this.HumidityInPercent.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HumidityInPercent.Location = new System.Drawing.Point(31, 188);
            this.HumidityInPercent.Name = "HumidityInPercent";
            this.HumidityInPercent.Size = new System.Drawing.Size(163, 45);
            this.HumidityInPercent.TabIndex = 28;
            this.HumidityInPercent.Text = "10%";
            this.HumidityInPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HumidityStatus
            // 
            this.HumidityStatus.BackColor = System.Drawing.Color.White;
            this.HumidityStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HumidityStatus.ForeColor = System.Drawing.Color.Black;
            this.HumidityStatus.Location = new System.Drawing.Point(34, 235);
            this.HumidityStatus.Name = "HumidityStatus";
            this.HumidityStatus.Size = new System.Drawing.Size(141, 23);
            this.HumidityStatus.TabIndex = 27;
            this.HumidityStatus.Text = "Miserable";
            this.HumidityStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label17.Location = new System.Drawing.Point(34, 162);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 23);
            this.label17.TabIndex = 26;
            this.label17.Text = "Humidity";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VisibilityInKilometers
            // 
            this.VisibilityInKilometers.BackColor = System.Drawing.Color.White;
            this.VisibilityInKilometers.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisibilityInKilometers.Location = new System.Drawing.Point(246, 188);
            this.VisibilityInKilometers.Name = "VisibilityInKilometers";
            this.VisibilityInKilometers.Size = new System.Drawing.Size(163, 45);
            this.VisibilityInKilometers.TabIndex = 25;
            this.VisibilityInKilometers.Text = "10 km";
            this.VisibilityInKilometers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VisibilityStatus
            // 
            this.VisibilityStatus.BackColor = System.Drawing.Color.White;
            this.VisibilityStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisibilityStatus.ForeColor = System.Drawing.Color.Black;
            this.VisibilityStatus.Location = new System.Drawing.Point(249, 235);
            this.VisibilityStatus.Name = "VisibilityStatus";
            this.VisibilityStatus.Size = new System.Drawing.Size(141, 23);
            this.VisibilityStatus.TabIndex = 24;
            this.VisibilityStatus.Text = "Good visibility";
            this.VisibilityStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label14.Location = new System.Drawing.Point(249, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 23);
            this.label14.TabIndex = 23;
            this.label14.Text = "Visibility";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WindKilometrsPerHour
            // 
            this.WindKilometrsPerHour.BackColor = System.Drawing.Color.White;
            this.WindKilometrsPerHour.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindKilometrsPerHour.Location = new System.Drawing.Point(246, 67);
            this.WindKilometrsPerHour.Name = "WindKilometrsPerHour";
            this.WindKilometrsPerHour.Size = new System.Drawing.Size(163, 45);
            this.WindKilometrsPerHour.TabIndex = 22;
            this.WindKilometrsPerHour.Text = "9 km/h";
            this.WindKilometrsPerHour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WindStatus
            // 
            this.WindStatus.BackColor = System.Drawing.Color.White;
            this.WindStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindStatus.ForeColor = System.Drawing.Color.Black;
            this.WindStatus.Location = new System.Drawing.Point(249, 114);
            this.WindStatus.Name = "WindStatus";
            this.WindStatus.Size = new System.Drawing.Size(141, 23);
            this.WindStatus.TabIndex = 21;
            this.WindStatus.Text = "Light breeze";
            this.WindStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaxTemperature
            // 
            this.MaxTemperature.BackColor = System.Drawing.Color.White;
            this.MaxTemperature.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxTemperature.Location = new System.Drawing.Point(494, 219);
            this.MaxTemperature.Name = "MaxTemperature";
            this.MaxTemperature.Size = new System.Drawing.Size(85, 29);
            this.MaxTemperature.TabIndex = 16;
            this.MaxTemperature.Text = "11°";
            this.MaxTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(249, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Wind Status";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sunset
            // 
            this.Sunset.BackColor = System.Drawing.Color.White;
            this.Sunset.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sunset.Location = new System.Drawing.Point(496, 105);
            this.Sunset.Name = "Sunset";
            this.Sunset.Size = new System.Drawing.Size(136, 29);
            this.Sunset.TabIndex = 21;
            this.Sunset.Text = "16:20";
            this.Sunset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MinTemperature
            // 
            this.MinTemperature.BackColor = System.Drawing.Color.White;
            this.MinTemperature.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinTemperature.Location = new System.Drawing.Point(494, 183);
            this.MinTemperature.Name = "MinTemperature";
            this.MinTemperature.Size = new System.Drawing.Size(85, 29);
            this.MinTemperature.TabIndex = 15;
            this.MinTemperature.Text = "9°";
            this.MinTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.BackgroundImage = global::Weather.Properties.Resources.premium_icon_high_temperature_1585441;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(464, 224);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 30);
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // Sunrise
            // 
            this.Sunrise.BackColor = System.Drawing.Color.White;
            this.Sunrise.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sunrise.Location = new System.Drawing.Point(496, 69);
            this.Sunrise.Name = "Sunrise";
            this.Sunrise.Size = new System.Drawing.Size(136, 29);
            this.Sunrise.TabIndex = 20;
            this.Sunrise.Text = "07:02";
            this.Sunrise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.BackgroundImage = global::Weather.Properties.Resources.premium_icon_low_temperature_1585443;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(464, 188);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.White;
            this.pictureBox10.BackgroundImage = global::Weather.Properties.Resources.sunset;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(464, 103);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(30, 30);
            this.pictureBox10.TabIndex = 19;
            this.pictureBox10.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(464, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Min / Max temperature  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.BackgroundImage = global::Weather.Properties.Resources.sunrise;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(464, 67);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 30);
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(464, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sunrise / Sunset";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextAboutDay
            // 
            this.TextAboutDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TextAboutDay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextAboutDay.Location = new System.Drawing.Point(27, 9);
            this.TextAboutDay.Name = "TextAboutDay";
            this.TextAboutDay.Size = new System.Drawing.Size(198, 19);
            this.TextAboutDay.TabIndex = 6;
            this.TextAboutDay.Text = "Today\'s Higtlights";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(451, 152);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(200, 115);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(451, 31);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(200, 115);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(236, 152);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 115);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(236, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 115);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(21, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 115);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(21, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DateTimeTimer
            // 
            this.DateTimeTimer.Tick += new System.EventHandler(this.DateTimeTimer_Tick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HourlyWeatherChartPanel);
            this.Controls.Add(this.LeftCenterPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconApplication)).EndInit();
            this.LeftCenterPanel.ResumeLayout(false);
            this.HourlyWeatherChartPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox IconApplication;
        private System.Windows.Forms.Button CloseApplicationButton;
        private System.Windows.Forms.Button MaximizeButton;
        private System.Windows.Forms.Button MinimizeButoon;
        private System.Windows.Forms.Panel LeftCenterPanel;
        private System.Windows.Forms.Panel HourlyWeatherChartPanel;
        private System.Windows.Forms.Panel panel1;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button TheDayAfterTomorrowButton;
        private System.Windows.Forms.Button TomorrowWeatherButton;
        private System.Windows.Forms.Button TodayWeatherButton;
        private System.Windows.Forms.Label TextAboutDay;
        private System.Windows.Forms.Label Sunset;
        private System.Windows.Forms.Label Sunrise;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MaxTemperature;
        private System.Windows.Forms.Label MinTemperature;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HumidityInPercent;
        private System.Windows.Forms.Label HumidityStatus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label VisibilityInKilometers;
        private System.Windows.Forms.Label VisibilityStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label WindKilometrsPerHour;
        private System.Windows.Forms.Label WindStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label TownAndCountry;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.Timer DateTimeTimer;
    }
}

