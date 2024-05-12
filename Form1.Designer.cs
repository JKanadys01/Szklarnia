namespace GreenHouse
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imageList1 = new ImageList(components);
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            InsMaxTextBox = new MaterialSkin.Controls.MaterialTextBox();
            InsMinTextBox = new MaterialSkin.Controls.MaterialTextBox();
            HumMaxTextBox = new MaterialSkin.Controls.MaterialTextBox();
            HumMinTextBox = new MaterialSkin.Controls.MaterialTextBox();
            TempMaxTextBox = new MaterialSkin.Controls.MaterialTextBox();
            TempMinTextBox = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            InsolationAlarmButton = new MaterialSkin.Controls.MaterialButton();
            HumidityAlarmButton = new MaterialSkin.Controls.MaterialButton();
            TemperatureAlarmButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            InsolationProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            HumidityProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            insolationmaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            humiditymaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            temperaturematerialLabel = new MaterialSkin.Controls.MaterialLabel();
            TemperatureProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            tabControl2 = new TabControl();
            TemperatureTabPage = new TabPage();
            TemperaturecartesianChart = new LiveCharts.WinForms.CartesianChart();
            HumidityTabPage = new TabPage();
            humiditycartesianChart = new LiveCharts.WinForms.CartesianChart();
            InsolationTabPage = new TabPage();
            InsolationcartesianChart = new LiveCharts.WinForms.CartesianChart();
            Username_materialTextBox = new MaterialSkin.Controls.MaterialTextBox();
            logoutmaterialButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            tabPage3 = new TabPage();
            TimeFramematerialComboBox = new MaterialSkin.Controls.MaterialComboBox();
            ParametermaterialComboBox = new MaterialSkin.Controls.MaterialComboBox();
            DrawchartmaterialButton = new MaterialSkin.Controls.MaterialButton();
            dateTimePicker = new DateTimePicker();
            cartesianChart = new LiveCharts.WinForms.CartesianChart();
            tabPage4 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl2.SuspendLayout();
            TemperatureTabPage.SuspendLayout();
            HumidityTabPage.SuspendLayout();
            InsolationTabPage.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "humidity.png");
            imageList1.Images.SetKeyName(1, "Insolation.png");
            imageList1.Images.SetKeyName(2, "temp.png");
            imageList1.Images.SetKeyName(3, "chart.png");
            imageList1.Images.SetKeyName(4, "home.png");
            imageList1.Images.SetKeyName(5, "admin.jpg");
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ImageList = imageList1;
            tabControl1.Location = new Point(3, 64);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1918, 994);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(64, 64, 64);
            tabPage2.Controls.Add(InsMaxTextBox);
            tabPage2.Controls.Add(InsMinTextBox);
            tabPage2.Controls.Add(HumMaxTextBox);
            tabPage2.Controls.Add(HumMinTextBox);
            tabPage2.Controls.Add(TempMaxTextBox);
            tabPage2.Controls.Add(TempMinTextBox);
            tabPage2.Controls.Add(materialLabel11);
            tabPage2.Controls.Add(materialLabel10);
            tabPage2.Controls.Add(materialLabel9);
            tabPage2.Controls.Add(materialLabel8);
            tabPage2.Controls.Add(materialLabel7);
            tabPage2.Controls.Add(materialLabel6);
            tabPage2.Controls.Add(InsolationAlarmButton);
            tabPage2.Controls.Add(HumidityAlarmButton);
            tabPage2.Controls.Add(TemperatureAlarmButton);
            tabPage2.Controls.Add(materialLabel5);
            tabPage2.Controls.Add(materialLabel4);
            tabPage2.Controls.Add(materialLabel3);
            tabPage2.Controls.Add(materialLabel2);
            tabPage2.Controls.Add(materialSwitch1);
            tabPage2.Controls.Add(InsolationProgressBar);
            tabPage2.Controls.Add(HumidityProgressBar);
            tabPage2.Controls.Add(insolationmaterialLabel);
            tabPage2.Controls.Add(humiditymaterialLabel);
            tabPage2.Controls.Add(temperaturematerialLabel);
            tabPage2.Controls.Add(TemperatureProgressBar);
            tabPage2.Controls.Add(tabControl2);
            tabPage2.Controls.Add(Username_materialTextBox);
            tabPage2.Controls.Add(logoutmaterialButton);
            tabPage2.Controls.Add(materialLabel1);
            tabPage2.ImageKey = "home.png";
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1910, 951);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Main";
            // 
            // InsMaxTextBox
            // 
            InsMaxTextBox.AnimateReadOnly = false;
            InsMaxTextBox.BorderStyle = BorderStyle.None;
            InsMaxTextBox.Depth = 0;
            InsMaxTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            InsMaxTextBox.LeadingIcon = null;
            InsMaxTextBox.Location = new Point(224, 349);
            InsMaxTextBox.MaxLength = 50;
            InsMaxTextBox.MouseState = MaterialSkin.MouseState.OUT;
            InsMaxTextBox.Multiline = false;
            InsMaxTextBox.Name = "InsMaxTextBox";
            InsMaxTextBox.Size = new Size(100, 50);
            InsMaxTextBox.TabIndex = 45;
            InsMaxTextBox.Text = "";
            InsMaxTextBox.TrailingIcon = null;
            // 
            // InsMinTextBox
            // 
            InsMinTextBox.AnimateReadOnly = false;
            InsMinTextBox.BorderStyle = BorderStyle.None;
            InsMinTextBox.Depth = 0;
            InsMinTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            InsMinTextBox.LeadingIcon = null;
            InsMinTextBox.Location = new Point(103, 349);
            InsMinTextBox.MaxLength = 50;
            InsMinTextBox.MouseState = MaterialSkin.MouseState.OUT;
            InsMinTextBox.Multiline = false;
            InsMinTextBox.Name = "InsMinTextBox";
            InsMinTextBox.Size = new Size(100, 50);
            InsMinTextBox.TabIndex = 44;
            InsMinTextBox.Text = "";
            InsMinTextBox.TrailingIcon = null;
            // 
            // HumMaxTextBox
            // 
            HumMaxTextBox.AnimateReadOnly = false;
            HumMaxTextBox.BorderStyle = BorderStyle.None;
            HumMaxTextBox.Depth = 0;
            HumMaxTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            HumMaxTextBox.LeadingIcon = null;
            HumMaxTextBox.Location = new Point(224, 277);
            HumMaxTextBox.MaxLength = 50;
            HumMaxTextBox.MouseState = MaterialSkin.MouseState.OUT;
            HumMaxTextBox.Multiline = false;
            HumMaxTextBox.Name = "HumMaxTextBox";
            HumMaxTextBox.Size = new Size(100, 50);
            HumMaxTextBox.TabIndex = 43;
            HumMaxTextBox.Text = "";
            HumMaxTextBox.TrailingIcon = null;
            // 
            // HumMinTextBox
            // 
            HumMinTextBox.AnimateReadOnly = false;
            HumMinTextBox.BorderStyle = BorderStyle.None;
            HumMinTextBox.Depth = 0;
            HumMinTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            HumMinTextBox.LeadingIcon = null;
            HumMinTextBox.Location = new Point(103, 277);
            HumMinTextBox.MaxLength = 50;
            HumMinTextBox.MouseState = MaterialSkin.MouseState.OUT;
            HumMinTextBox.Multiline = false;
            HumMinTextBox.Name = "HumMinTextBox";
            HumMinTextBox.Size = new Size(100, 50);
            HumMinTextBox.TabIndex = 42;
            HumMinTextBox.Text = "";
            HumMinTextBox.TrailingIcon = null;
            // 
            // TempMaxTextBox
            // 
            TempMaxTextBox.AnimateReadOnly = false;
            TempMaxTextBox.BorderStyle = BorderStyle.None;
            TempMaxTextBox.Depth = 0;
            TempMaxTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TempMaxTextBox.LeadingIcon = null;
            TempMaxTextBox.Location = new Point(224, 204);
            TempMaxTextBox.MaxLength = 50;
            TempMaxTextBox.MouseState = MaterialSkin.MouseState.OUT;
            TempMaxTextBox.Multiline = false;
            TempMaxTextBox.Name = "TempMaxTextBox";
            TempMaxTextBox.Size = new Size(100, 50);
            TempMaxTextBox.TabIndex = 41;
            TempMaxTextBox.Text = "";
            TempMaxTextBox.TrailingIcon = null;
            // 
            // TempMinTextBox
            // 
            TempMinTextBox.AnimateReadOnly = false;
            TempMinTextBox.BorderStyle = BorderStyle.None;
            TempMinTextBox.Depth = 0;
            TempMinTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TempMinTextBox.LeadingIcon = null;
            TempMinTextBox.Location = new Point(103, 204);
            TempMinTextBox.MaxLength = 50;
            TempMinTextBox.MouseState = MaterialSkin.MouseState.OUT;
            TempMinTextBox.Multiline = false;
            TempMinTextBox.Name = "TempMinTextBox";
            TempMinTextBox.Size = new Size(100, 50);
            TempMinTextBox.TabIndex = 40;
            TempMinTextBox.Text = "";
            TempMinTextBox.TrailingIcon = null;
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(6, 363);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(71, 19);
            materialLabel11.TabIndex = 39;
            materialLabel11.Text = "Insolation";
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(6, 292);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(65, 19);
            materialLabel10.TabIndex = 38;
            materialLabel10.Text = "Humidity";
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(260, 182);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(32, 19);
            materialLabel9.TabIndex = 37;
            materialLabel9.Text = "Max";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(138, 182);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(28, 19);
            materialLabel8.TabIndex = 36;
            materialLabel8.Text = "Min";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(6, 219);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(91, 19);
            materialLabel7.TabIndex = 35;
            materialLabel7.Text = "Temperature";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(162, 163);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(100, 19);
            materialLabel6.TabIndex = 34;
            materialLabel6.Text = "Alarm Setings";
            // 
            // InsolationAlarmButton
            // 
            InsolationAlarmButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            InsolationAlarmButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            InsolationAlarmButton.Depth = 0;
            InsolationAlarmButton.HighEmphasis = true;
            InsolationAlarmButton.Icon = null;
            InsolationAlarmButton.Location = new Point(604, 62);
            InsolationAlarmButton.Margin = new Padding(4, 6, 4, 6);
            InsolationAlarmButton.MouseState = MaterialSkin.MouseState.HOVER;
            InsolationAlarmButton.Name = "InsolationAlarmButton";
            InsolationAlarmButton.NoAccentTextColor = Color.Empty;
            InsolationAlarmButton.Size = new Size(69, 36);
            InsolationAlarmButton.TabIndex = 33;
            InsolationAlarmButton.Text = "Check";
            InsolationAlarmButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            InsolationAlarmButton.UseAccentColor = false;
            InsolationAlarmButton.UseVisualStyleBackColor = true;
            InsolationAlarmButton.Click += InsolationAlarmButton_Click;
            // 
            // HumidityAlarmButton
            // 
            HumidityAlarmButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            HumidityAlarmButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            HumidityAlarmButton.Depth = 0;
            HumidityAlarmButton.HighEmphasis = true;
            HumidityAlarmButton.Icon = null;
            HumidityAlarmButton.Location = new Point(468, 62);
            HumidityAlarmButton.Margin = new Padding(4, 6, 4, 6);
            HumidityAlarmButton.MouseState = MaterialSkin.MouseState.HOVER;
            HumidityAlarmButton.Name = "HumidityAlarmButton";
            HumidityAlarmButton.NoAccentTextColor = Color.Empty;
            HumidityAlarmButton.Size = new Size(69, 36);
            HumidityAlarmButton.TabIndex = 32;
            HumidityAlarmButton.Text = "Check";
            HumidityAlarmButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            HumidityAlarmButton.UseAccentColor = false;
            HumidityAlarmButton.UseVisualStyleBackColor = true;
            HumidityAlarmButton.Click += HumidityAlarmButton_Click;
            // 
            // TemperatureAlarmButton
            // 
            TemperatureAlarmButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TemperatureAlarmButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            TemperatureAlarmButton.Depth = 0;
            TemperatureAlarmButton.HighEmphasis = true;
            TemperatureAlarmButton.Icon = null;
            TemperatureAlarmButton.Location = new Point(327, 62);
            TemperatureAlarmButton.Margin = new Padding(4, 6, 4, 6);
            TemperatureAlarmButton.MouseState = MaterialSkin.MouseState.HOVER;
            TemperatureAlarmButton.Name = "TemperatureAlarmButton";
            TemperatureAlarmButton.NoAccentTextColor = Color.Empty;
            TemperatureAlarmButton.Size = new Size(69, 36);
            TemperatureAlarmButton.TabIndex = 31;
            TemperatureAlarmButton.Text = "Check";
            TemperatureAlarmButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            TemperatureAlarmButton.UseAccentColor = false;
            TemperatureAlarmButton.UseVisualStyleBackColor = true;
            TemperatureAlarmButton.Click += TemperatureAlarmButton_Click;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(602, 37);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(71, 19);
            materialLabel5.TabIndex = 30;
            materialLabel5.Text = "Insolation";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(472, 37);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(65, 19);
            materialLabel4.TabIndex = 29;
            materialLabel4.Text = "Humidity";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(318, 37);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(91, 19);
            materialLabel3.TabIndex = 28;
            materialLabel3.Text = "Temperature";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(454, 18);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(110, 19);
            materialLabel2.TabIndex = 27;
            materialLabel2.Text = "State of alarms";
            // 
            // materialSwitch1
            // 
            materialSwitch1.AutoSize = true;
            materialSwitch1.Depth = 0;
            materialSwitch1.Location = new Point(800, 9);
            materialSwitch1.Margin = new Padding(0);
            materialSwitch1.MouseLocation = new Point(-1, -1);
            materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            materialSwitch1.Name = "materialSwitch1";
            materialSwitch1.Ripple = true;
            materialSwitch1.Size = new Size(117, 37);
            materialSwitch1.TabIndex = 26;
            materialSwitch1.Text = "Go live\r\n";
            materialSwitch1.UseVisualStyleBackColor = true;
            materialSwitch1.CheckedChanged += materialSwitch1_CheckedChanged;
            // 
            // InsolationProgressBar
            // 
            InsolationProgressBar.Depth = 0;
            InsolationProgressBar.ForeColor = Color.Yellow;
            InsolationProgressBar.Location = new Point(920, 557);
            InsolationProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            InsolationProgressBar.Name = "InsolationProgressBar";
            InsolationProgressBar.Size = new Size(984, 5);
            InsolationProgressBar.TabIndex = 25;
            // 
            // HumidityProgressBar
            // 
            HumidityProgressBar.BackColor = Color.FromArgb(64, 64, 64);
            HumidityProgressBar.Depth = 0;
            HumidityProgressBar.ForeColor = Color.Blue;
            HumidityProgressBar.Location = new Point(920, 518);
            HumidityProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            HumidityProgressBar.Name = "HumidityProgressBar";
            HumidityProgressBar.Size = new Size(984, 5);
            HumidityProgressBar.TabIndex = 24;
            // 
            // insolationmaterialLabel
            // 
            insolationmaterialLabel.AutoSize = true;
            insolationmaterialLabel.Depth = 0;
            insolationmaterialLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            insolationmaterialLabel.Location = new Point(920, 535);
            insolationmaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            insolationmaterialLabel.Name = "insolationmaterialLabel";
            insolationmaterialLabel.Size = new Size(75, 19);
            insolationmaterialLabel.TabIndex = 23;
            insolationmaterialLabel.Text = "Insolation:";
            // 
            // humiditymaterialLabel
            // 
            humiditymaterialLabel.AutoSize = true;
            humiditymaterialLabel.Depth = 0;
            humiditymaterialLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            humiditymaterialLabel.Location = new Point(920, 496);
            humiditymaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            humiditymaterialLabel.Name = "humiditymaterialLabel";
            humiditymaterialLabel.Size = new Size(69, 19);
            humiditymaterialLabel.TabIndex = 22;
            humiditymaterialLabel.Text = "Humidity:";
            // 
            // temperaturematerialLabel
            // 
            temperaturematerialLabel.AutoSize = true;
            temperaturematerialLabel.Depth = 0;
            temperaturematerialLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            temperaturematerialLabel.Location = new Point(924, 457);
            temperaturematerialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            temperaturematerialLabel.Name = "temperaturematerialLabel";
            temperaturematerialLabel.Size = new Size(95, 19);
            temperaturematerialLabel.TabIndex = 21;
            temperaturematerialLabel.Text = "Temperature:";
            // 
            // TemperatureProgressBar
            // 
            TemperatureProgressBar.Depth = 0;
            TemperatureProgressBar.ForeColor = Color.FromArgb(128, 255, 128);
            TemperatureProgressBar.Location = new Point(920, 479);
            TemperatureProgressBar.Maximum = 50;
            TemperatureProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            TemperatureProgressBar.Name = "TemperatureProgressBar";
            TemperatureProgressBar.Size = new Size(984, 5);
            TemperatureProgressBar.TabIndex = 20;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(TemperatureTabPage);
            tabControl2.Controls.Add(HumidityTabPage);
            tabControl2.Controls.Add(InsolationTabPage);
            tabControl2.ImageList = imageList1;
            tabControl2.Location = new Point(920, 1);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(995, 439);
            tabControl2.TabIndex = 17;
            // 
            // TemperatureTabPage
            // 
            TemperatureTabPage.BackColor = Color.FromArgb(64, 64, 64);
            TemperatureTabPage.Controls.Add(TemperaturecartesianChart);
            TemperatureTabPage.ImageKey = "temp.png";
            TemperatureTabPage.Location = new Point(4, 39);
            TemperatureTabPage.Name = "TemperatureTabPage";
            TemperatureTabPage.Padding = new Padding(3);
            TemperatureTabPage.Size = new Size(987, 396);
            TemperatureTabPage.TabIndex = 0;
            TemperatureTabPage.Text = "Temperatur";
            // 
            // TemperaturecartesianChart
            // 
            TemperaturecartesianChart.Location = new Point(6, 10);
            TemperaturecartesianChart.Name = "TemperaturecartesianChart";
            TemperaturecartesianChart.Size = new Size(975, 380);
            TemperaturecartesianChart.TabIndex = 0;
            TemperaturecartesianChart.Text = "cartesianChart1";
            // 
            // HumidityTabPage
            // 
            HumidityTabPage.BackColor = Color.FromArgb(64, 64, 64);
            HumidityTabPage.Controls.Add(humiditycartesianChart);
            HumidityTabPage.ImageKey = "humidity.png";
            HumidityTabPage.Location = new Point(4, 39);
            HumidityTabPage.Name = "HumidityTabPage";
            HumidityTabPage.Padding = new Padding(3);
            HumidityTabPage.Size = new Size(987, 396);
            HumidityTabPage.TabIndex = 1;
            HumidityTabPage.Text = "Humidity";
            // 
            // humiditycartesianChart
            // 
            humiditycartesianChart.BackColor = Color.FromArgb(64, 64, 64);
            humiditycartesianChart.Location = new Point(6, 7);
            humiditycartesianChart.Name = "humiditycartesianChart";
            humiditycartesianChart.Size = new Size(975, 383);
            humiditycartesianChart.TabIndex = 0;
            humiditycartesianChart.Text = "cartesianChart2";
            // 
            // InsolationTabPage
            // 
            InsolationTabPage.BackColor = Color.FromArgb(64, 64, 64);
            InsolationTabPage.Controls.Add(InsolationcartesianChart);
            InsolationTabPage.ImageKey = "Insolation.png";
            InsolationTabPage.Location = new Point(4, 39);
            InsolationTabPage.Name = "InsolationTabPage";
            InsolationTabPage.Padding = new Padding(3);
            InsolationTabPage.Size = new Size(987, 396);
            InsolationTabPage.TabIndex = 2;
            InsolationTabPage.Text = "Insolation";
            // 
            // InsolationcartesianChart
            // 
            InsolationcartesianChart.BackColor = Color.FromArgb(64, 64, 64);
            InsolationcartesianChart.Location = new Point(4, 2);
            InsolationcartesianChart.Name = "InsolationcartesianChart";
            InsolationcartesianChart.Size = new Size(977, 388);
            InsolationcartesianChart.TabIndex = 0;
            InsolationcartesianChart.Text = "cartesianChart3";
            // 
            // Username_materialTextBox
            // 
            Username_materialTextBox.AnimateReadOnly = false;
            Username_materialTextBox.BorderStyle = BorderStyle.None;
            Username_materialTextBox.Depth = 0;
            Username_materialTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Username_materialTextBox.LeadingIcon = null;
            Username_materialTextBox.Location = new Point(81, 6);
            Username_materialTextBox.MaxLength = 50;
            Username_materialTextBox.MouseState = MaterialSkin.MouseState.OUT;
            Username_materialTextBox.Multiline = false;
            Username_materialTextBox.Name = "Username_materialTextBox";
            Username_materialTextBox.ReadOnly = true;
            Username_materialTextBox.Size = new Size(191, 50);
            Username_materialTextBox.TabIndex = 16;
            Username_materialTextBox.Text = "";
            Username_materialTextBox.TrailingIcon = null;
            // 
            // logoutmaterialButton
            // 
            logoutmaterialButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            logoutmaterialButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            logoutmaterialButton.Depth = 0;
            logoutmaterialButton.HighEmphasis = true;
            logoutmaterialButton.Icon = null;
            logoutmaterialButton.Location = new Point(129, 65);
            logoutmaterialButton.Margin = new Padding(4, 6, 4, 6);
            logoutmaterialButton.MouseState = MaterialSkin.MouseState.HOVER;
            logoutmaterialButton.Name = "logoutmaterialButton";
            logoutmaterialButton.NoAccentTextColor = Color.Empty;
            logoutmaterialButton.Size = new Size(78, 36);
            logoutmaterialButton.TabIndex = 14;
            logoutmaterialButton.Text = "Logout";
            logoutmaterialButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            logoutmaterialButton.UseAccentColor = false;
            logoutmaterialButton.UseVisualStyleBackColor = true;
            logoutmaterialButton.Click += logoutmaterialButton_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(3, 18);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(72, 19);
            materialLabel1.TabIndex = 13;
            materialLabel1.Text = "Username";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(64, 64, 64);
            tabPage3.Controls.Add(TimeFramematerialComboBox);
            tabPage3.Controls.Add(ParametermaterialComboBox);
            tabPage3.Controls.Add(DrawchartmaterialButton);
            tabPage3.Controls.Add(dateTimePicker);
            tabPage3.Controls.Add(cartesianChart);
            tabPage3.ImageKey = "chart.png";
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1910, 951);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "Charts";
            // 
            // TimeFramematerialComboBox
            // 
            TimeFramematerialComboBox.AutoResize = false;
            TimeFramematerialComboBox.BackColor = Color.FromArgb(255, 255, 255);
            TimeFramematerialComboBox.Depth = 0;
            TimeFramematerialComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            TimeFramematerialComboBox.DropDownHeight = 174;
            TimeFramematerialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TimeFramematerialComboBox.DropDownWidth = 121;
            TimeFramematerialComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            TimeFramematerialComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            TimeFramematerialComboBox.FormattingEnabled = true;
            TimeFramematerialComboBox.IntegralHeight = false;
            TimeFramematerialComboBox.ItemHeight = 43;
            TimeFramematerialComboBox.Location = new Point(701, 619);
            TimeFramematerialComboBox.MaxDropDownItems = 4;
            TimeFramematerialComboBox.MouseState = MaterialSkin.MouseState.OUT;
            TimeFramematerialComboBox.Name = "TimeFramematerialComboBox";
            TimeFramematerialComboBox.Size = new Size(182, 49);
            TimeFramematerialComboBox.StartIndex = 0;
            TimeFramematerialComboBox.TabIndex = 11;
            // 
            // ParametermaterialComboBox
            // 
            ParametermaterialComboBox.AutoResize = false;
            ParametermaterialComboBox.BackColor = Color.FromArgb(255, 255, 255);
            ParametermaterialComboBox.Depth = 0;
            ParametermaterialComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            ParametermaterialComboBox.DropDownHeight = 174;
            ParametermaterialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ParametermaterialComboBox.DropDownWidth = 121;
            ParametermaterialComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ParametermaterialComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ParametermaterialComboBox.FormattingEnabled = true;
            ParametermaterialComboBox.IntegralHeight = false;
            ParametermaterialComboBox.ItemHeight = 43;
            ParametermaterialComboBox.Location = new Point(513, 619);
            ParametermaterialComboBox.MaxDropDownItems = 4;
            ParametermaterialComboBox.MouseState = MaterialSkin.MouseState.OUT;
            ParametermaterialComboBox.Name = "ParametermaterialComboBox";
            ParametermaterialComboBox.Size = new Size(182, 49);
            ParametermaterialComboBox.StartIndex = 0;
            ParametermaterialComboBox.TabIndex = 10;
            // 
            // DrawchartmaterialButton
            // 
            DrawchartmaterialButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DrawchartmaterialButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            DrawchartmaterialButton.Depth = 0;
            DrawchartmaterialButton.HighEmphasis = true;
            DrawchartmaterialButton.Icon = null;
            DrawchartmaterialButton.Location = new Point(890, 628);
            DrawchartmaterialButton.Margin = new Padding(4, 6, 4, 6);
            DrawchartmaterialButton.MouseState = MaterialSkin.MouseState.HOVER;
            DrawchartmaterialButton.Name = "DrawchartmaterialButton";
            DrawchartmaterialButton.NoAccentTextColor = Color.Empty;
            DrawchartmaterialButton.Size = new Size(64, 36);
            DrawchartmaterialButton.TabIndex = 9;
            DrawchartmaterialButton.Text = "Draw";
            DrawchartmaterialButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            DrawchartmaterialButton.UseAccentColor = false;
            DrawchartmaterialButton.UseVisualStyleBackColor = true;
            DrawchartmaterialButton.Click += DrawchartmaterialButton_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(302, 633);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(205, 23);
            dateTimePicker.TabIndex = 8;
            // 
            // cartesianChart
            // 
            cartesianChart.Location = new Point(7, 6);
            cartesianChart.Name = "cartesianChart";
            cartesianChart.Size = new Size(1900, 598);
            cartesianChart.TabIndex = 7;
            cartesianChart.Text = "cartesianChart1";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(64, 64, 64);
            tabPage4.ImageKey = "admin.jpg";
            tabPage4.Location = new Point(4, 39);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1910, 951);
            tabPage4.TabIndex = 2;
            tabPage4.Text = "Admin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Start";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabControl2.ResumeLayout(false);
            TemperatureTabPage.ResumeLayout(false);
            HumidityTabPage.ResumeLayout(false);
            InsolationTabPage.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private ImageList imageList1;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabControl tabControl2;
        private TabPage TemperatureTabPage;
        private LiveCharts.WinForms.CartesianChart TemperaturecartesianChart;
        private TabPage HumidityTabPage;
        private LiveCharts.WinForms.CartesianChart humiditycartesianChart;
        private TabPage InsolationTabPage;
        private LiveCharts.WinForms.CartesianChart InsolationcartesianChart;
        private MaterialSkin.Controls.MaterialTextBox Username_materialTextBox;
        private MaterialSkin.Controls.MaterialButton logoutmaterialButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private TabPage tabPage3;
        private LiveCharts.WinForms.CartesianChart cartesianChart;
        private DateTimePicker dateTimePicker;
        private MaterialSkin.Controls.MaterialComboBox TimeFramematerialComboBox;
        private MaterialSkin.Controls.MaterialComboBox ParametermaterialComboBox;
        private MaterialSkin.Controls.MaterialButton DrawchartmaterialButton;
        private TabPage tabPage4;
        private MaterialSkin.Controls.MaterialProgressBar TemperatureProgressBar;
        private MaterialSkin.Controls.MaterialProgressBar InsolationProgressBar;
        private MaterialSkin.Controls.MaterialProgressBar HumidityProgressBar;
        private MaterialSkin.Controls.MaterialLabel insolationmaterialLabel;
        private MaterialSkin.Controls.MaterialLabel humiditymaterialLabel;
        private MaterialSkin.Controls.MaterialLabel temperaturematerialLabel;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton HumidityAlarmButton;
        private MaterialSkin.Controls.MaterialButton TemperatureAlarmButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton InsolationAlarmButton;
        private MaterialSkin.Controls.MaterialTextBox TempMaxTextBox;
        private MaterialSkin.Controls.MaterialTextBox TempMinTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox InsMaxTextBox;
        private MaterialSkin.Controls.MaterialTextBox InsMinTextBox;
        private MaterialSkin.Controls.MaterialTextBox HumMaxTextBox;
        private MaterialSkin.Controls.MaterialTextBox HumMinTextBox;
    }
}
