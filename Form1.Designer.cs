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
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            DeviceComboBox = new MaterialSkin.Controls.MaterialComboBox();
            AlarmComboBox = new MaterialSkin.Controls.MaterialComboBox();
            SetAlarmlButton = new MaterialSkin.Controls.MaterialButton();
            TempMaxTextBox = new MaterialSkin.Controls.MaterialTextBox();
            TempMinTextBox = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
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
            DeviceChartsPageComboBox = new MaterialSkin.Controls.MaterialComboBox();
            TimeFramematerialComboBox = new MaterialSkin.Controls.MaterialComboBox();
            ParametermaterialComboBox = new MaterialSkin.Controls.MaterialComboBox();
            DrawchartmaterialButton = new MaterialSkin.Controls.MaterialButton();
            dateTimePicker = new DateTimePicker();
            cartesianChart = new LiveCharts.WinForms.CartesianChart();
            tabPage4 = new TabPage();
            DeviceDescriptionTextBox = new MaterialSkin.Controls.MaterialTextBox();
            DeviceIdTextBox = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            DeviceListButton = new MaterialSkin.Controls.MaterialButton();
            EditDeviceButton = new MaterialSkin.Controls.MaterialButton();
            AddDeviceButton = new MaterialSkin.Controls.MaterialButton();
            EditUserButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            PullUserListButton = new MaterialSkin.Controls.MaterialButton();
            UserListTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            UserCreatelButton = new MaterialSkin.Controls.MaterialButton();
            UserDescriptionTextBox = new MaterialSkin.Controls.MaterialTextBox();
            UserPasswordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            UserLoginTextBox = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            AlarmTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl2.SuspendLayout();
            TemperatureTabPage.SuspendLayout();
            HumidityTabPage.SuspendLayout();
            InsolationTabPage.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
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
            tabPage2.Controls.Add(AlarmTextBox);
            tabPage2.Controls.Add(materialLabel2);
            tabPage2.Controls.Add(materialLabel12);
            tabPage2.Controls.Add(DeviceComboBox);
            tabPage2.Controls.Add(AlarmComboBox);
            tabPage2.Controls.Add(SetAlarmlButton);
            tabPage2.Controls.Add(TempMaxTextBox);
            tabPage2.Controls.Add(TempMinTextBox);
            tabPage2.Controls.Add(materialLabel9);
            tabPage2.Controls.Add(materialLabel8);
            tabPage2.Controls.Add(materialLabel6);
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
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(799, 46);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(115, 19);
            materialLabel12.TabIndex = 49;
            materialLabel12.Text = "Device selection";
            // 
            // DeviceComboBox
            // 
            DeviceComboBox.AutoResize = false;
            DeviceComboBox.BackColor = Color.FromArgb(255, 255, 255);
            DeviceComboBox.Depth = 0;
            DeviceComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            DeviceComboBox.DropDownHeight = 174;
            DeviceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeviceComboBox.DropDownWidth = 121;
            DeviceComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            DeviceComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            DeviceComboBox.FormattingEnabled = true;
            DeviceComboBox.IntegralHeight = false;
            DeviceComboBox.ItemHeight = 43;
            DeviceComboBox.Location = new Point(799, 69);
            DeviceComboBox.MaxDropDownItems = 4;
            DeviceComboBox.MouseState = MaterialSkin.MouseState.OUT;
            DeviceComboBox.Name = "DeviceComboBox";
            DeviceComboBox.Size = new Size(121, 49);
            DeviceComboBox.StartIndex = 0;
            DeviceComboBox.TabIndex = 48;
            // 
            // AlarmComboBox
            // 
            AlarmComboBox.AutoResize = false;
            AlarmComboBox.BackColor = Color.FromArgb(255, 255, 255);
            AlarmComboBox.Depth = 0;
            AlarmComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            AlarmComboBox.DropDownHeight = 174;
            AlarmComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AlarmComboBox.DropDownWidth = 121;
            AlarmComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            AlarmComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            AlarmComboBox.FormattingEnabled = true;
            AlarmComboBox.IntegralHeight = false;
            AlarmComboBox.ItemHeight = 43;
            AlarmComboBox.Location = new Point(112, 163);
            AlarmComboBox.MaxDropDownItems = 4;
            AlarmComboBox.MouseState = MaterialSkin.MouseState.OUT;
            AlarmComboBox.Name = "AlarmComboBox";
            AlarmComboBox.Size = new Size(142, 49);
            AlarmComboBox.StartIndex = 0;
            AlarmComboBox.TabIndex = 47;
            // 
            // SetAlarmlButton
            // 
            SetAlarmlButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SetAlarmlButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SetAlarmlButton.Depth = 0;
            SetAlarmlButton.HighEmphasis = true;
            SetAlarmlButton.Icon = null;
            SetAlarmlButton.Location = new Point(370, 163);
            SetAlarmlButton.Margin = new Padding(4, 6, 4, 6);
            SetAlarmlButton.MouseState = MaterialSkin.MouseState.HOVER;
            SetAlarmlButton.Name = "SetAlarmlButton";
            SetAlarmlButton.NoAccentTextColor = Color.Empty;
            SetAlarmlButton.Size = new Size(64, 36);
            SetAlarmlButton.TabIndex = 46;
            SetAlarmlButton.Text = "Set";
            SetAlarmlButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SetAlarmlButton.UseAccentColor = false;
            SetAlarmlButton.UseVisualStyleBackColor = true;
            SetAlarmlButton.Click += SetAlarmlButton_Click;
            // 
            // TempMaxTextBox
            // 
            TempMaxTextBox.AnimateReadOnly = false;
            TempMaxTextBox.BorderStyle = BorderStyle.None;
            TempMaxTextBox.Depth = 0;
            TempMaxTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TempMaxTextBox.LeadingIcon = null;
            TempMaxTextBox.Location = new Point(263, 162);
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
            TempMinTextBox.Location = new Point(6, 162);
            TempMinTextBox.MaxLength = 50;
            TempMinTextBox.MouseState = MaterialSkin.MouseState.OUT;
            TempMinTextBox.Multiline = false;
            TempMinTextBox.Name = "TempMinTextBox";
            TempMinTextBox.Size = new Size(100, 50);
            TempMinTextBox.TabIndex = 40;
            TempMinTextBox.Text = "";
            TempMinTextBox.TrailingIcon = null;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(299, 140);
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
            materialLabel8.Location = new Point(41, 140);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(28, 19);
            materialLabel8.TabIndex = 36;
            materialLabel8.Text = "Min";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(133, 122);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(100, 19);
            materialLabel6.TabIndex = 34;
            materialLabel6.Text = "Alarm Setings";
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
            Username_materialTextBox.Location = new Point(85, 9);
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
            logoutmaterialButton.Location = new Point(133, 68);
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
            materialLabel1.Location = new Point(7, 21);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(72, 19);
            materialLabel1.TabIndex = 13;
            materialLabel1.Text = "Username";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(64, 64, 64);
            tabPage3.Controls.Add(DeviceChartsPageComboBox);
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
            // DeviceChartsPageComboBox
            // 
            DeviceChartsPageComboBox.AutoResize = false;
            DeviceChartsPageComboBox.BackColor = Color.FromArgb(255, 255, 255);
            DeviceChartsPageComboBox.Depth = 0;
            DeviceChartsPageComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            DeviceChartsPageComboBox.DropDownHeight = 174;
            DeviceChartsPageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeviceChartsPageComboBox.DropDownWidth = 121;
            DeviceChartsPageComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            DeviceChartsPageComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            DeviceChartsPageComboBox.FormattingEnabled = true;
            DeviceChartsPageComboBox.IntegralHeight = false;
            DeviceChartsPageComboBox.ItemHeight = 43;
            DeviceChartsPageComboBox.Location = new Point(889, 620);
            DeviceChartsPageComboBox.MaxDropDownItems = 4;
            DeviceChartsPageComboBox.MouseState = MaterialSkin.MouseState.OUT;
            DeviceChartsPageComboBox.Name = "DeviceChartsPageComboBox";
            DeviceChartsPageComboBox.Size = new Size(121, 49);
            DeviceChartsPageComboBox.StartIndex = 0;
            DeviceChartsPageComboBox.TabIndex = 12;
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
            DrawchartmaterialButton.Location = new Point(1017, 628);
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
            tabPage4.Controls.Add(DeviceDescriptionTextBox);
            tabPage4.Controls.Add(DeviceIdTextBox);
            tabPage4.Controls.Add(materialLabel14);
            tabPage4.Controls.Add(materialLabel13);
            tabPage4.Controls.Add(materialMultiLineTextBox1);
            tabPage4.Controls.Add(DeviceListButton);
            tabPage4.Controls.Add(EditDeviceButton);
            tabPage4.Controls.Add(AddDeviceButton);
            tabPage4.Controls.Add(EditUserButton);
            tabPage4.Controls.Add(materialLabel11);
            tabPage4.Controls.Add(materialLabel10);
            tabPage4.Controls.Add(materialLabel7);
            tabPage4.Controls.Add(PullUserListButton);
            tabPage4.Controls.Add(UserListTextBox);
            tabPage4.Controls.Add(UserCreatelButton);
            tabPage4.Controls.Add(UserDescriptionTextBox);
            tabPage4.Controls.Add(UserPasswordTextBox);
            tabPage4.Controls.Add(UserLoginTextBox);
            tabPage4.ImageKey = "admin.jpg";
            tabPage4.Location = new Point(4, 39);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1910, 951);
            tabPage4.TabIndex = 2;
            tabPage4.Text = "Admin";
            // 
            // DeviceDescriptionTextBox
            // 
            DeviceDescriptionTextBox.AnimateReadOnly = false;
            DeviceDescriptionTextBox.BorderStyle = BorderStyle.None;
            DeviceDescriptionTextBox.Depth = 0;
            DeviceDescriptionTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            DeviceDescriptionTextBox.LeadingIcon = null;
            DeviceDescriptionTextBox.Location = new Point(1630, 30);
            DeviceDescriptionTextBox.MaxLength = 50;
            DeviceDescriptionTextBox.MouseState = MaterialSkin.MouseState.OUT;
            DeviceDescriptionTextBox.Multiline = false;
            DeviceDescriptionTextBox.Name = "DeviceDescriptionTextBox";
            DeviceDescriptionTextBox.Size = new Size(267, 50);
            DeviceDescriptionTextBox.TabIndex = 21;
            DeviceDescriptionTextBox.Text = "";
            DeviceDescriptionTextBox.TrailingIcon = null;
            // 
            // DeviceIdTextBox
            // 
            DeviceIdTextBox.AnimateReadOnly = false;
            DeviceIdTextBox.BorderStyle = BorderStyle.None;
            DeviceIdTextBox.Depth = 0;
            DeviceIdTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            DeviceIdTextBox.LeadingIcon = null;
            DeviceIdTextBox.Location = new Point(1524, 30);
            DeviceIdTextBox.MaxLength = 50;
            DeviceIdTextBox.MouseState = MaterialSkin.MouseState.OUT;
            DeviceIdTextBox.Multiline = false;
            DeviceIdTextBox.Name = "DeviceIdTextBox";
            DeviceIdTextBox.Size = new Size(100, 50);
            DeviceIdTextBox.TabIndex = 20;
            DeviceIdTextBox.Text = "";
            DeviceIdTextBox.TrailingIcon = null;
            // 
            // materialLabel14
            // 
            materialLabel14.AutoSize = true;
            materialLabel14.Depth = 0;
            materialLabel14.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel14.Location = new Point(1643, 9);
            materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel14.Name = "materialLabel14";
            materialLabel14.Size = new Size(81, 19);
            materialLabel14.TabIndex = 19;
            materialLabel14.Text = "Description";
            // 
            // materialLabel13
            // 
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel13.Location = new Point(1524, 10);
            materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(99, 19);
            materialLabel13.TabIndex = 18;
            materialLabel13.Text = "Serial number";
            // 
            // materialMultiLineTextBox1
            // 
            materialMultiLineTextBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox1.BorderStyle = BorderStyle.None;
            materialMultiLineTextBox1.Depth = 0;
            materialMultiLineTextBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox1.Location = new Point(1082, 9);
            materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            materialMultiLineTextBox1.ReadOnly = true;
            materialMultiLineTextBox1.Size = new Size(405, 339);
            materialMultiLineTextBox1.TabIndex = 17;
            materialMultiLineTextBox1.Text = "";
            // 
            // DeviceListButton
            // 
            DeviceListButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DeviceListButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            DeviceListButton.Depth = 0;
            DeviceListButton.HighEmphasis = true;
            DeviceListButton.Icon = null;
            DeviceListButton.Location = new Point(970, 8);
            DeviceListButton.Margin = new Padding(4, 6, 4, 6);
            DeviceListButton.MouseState = MaterialSkin.MouseState.HOVER;
            DeviceListButton.Name = "DeviceListButton";
            DeviceListButton.NoAccentTextColor = Color.Empty;
            DeviceListButton.Size = new Size(105, 36);
            DeviceListButton.TabIndex = 16;
            DeviceListButton.Text = "Device List";
            DeviceListButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            DeviceListButton.UseAccentColor = false;
            DeviceListButton.UseVisualStyleBackColor = true;
            DeviceListButton.Click += DeviceListButton_Click;
            // 
            // EditDeviceButton
            // 
            EditDeviceButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EditDeviceButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            EditDeviceButton.Depth = 0;
            EditDeviceButton.HighEmphasis = true;
            EditDeviceButton.Icon = null;
            EditDeviceButton.Location = new Point(1791, 140);
            EditDeviceButton.Margin = new Padding(4, 6, 4, 6);
            EditDeviceButton.MouseState = MaterialSkin.MouseState.HOVER;
            EditDeviceButton.Name = "EditDeviceButton";
            EditDeviceButton.NoAccentTextColor = Color.Empty;
            EditDeviceButton.Size = new Size(106, 36);
            EditDeviceButton.TabIndex = 13;
            EditDeviceButton.Text = "Edit Device";
            EditDeviceButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            EditDeviceButton.UseAccentColor = false;
            EditDeviceButton.UseVisualStyleBackColor = true;
            EditDeviceButton.Click += EditDeviceButton_Click;
            // 
            // AddDeviceButton
            // 
            AddDeviceButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddDeviceButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            AddDeviceButton.Depth = 0;
            AddDeviceButton.HighEmphasis = true;
            AddDeviceButton.Icon = null;
            AddDeviceButton.Location = new Point(1793, 92);
            AddDeviceButton.Margin = new Padding(4, 6, 4, 6);
            AddDeviceButton.MouseState = MaterialSkin.MouseState.HOVER;
            AddDeviceButton.Name = "AddDeviceButton";
            AddDeviceButton.NoAccentTextColor = Color.Empty;
            AddDeviceButton.Size = new Size(104, 36);
            AddDeviceButton.TabIndex = 12;
            AddDeviceButton.Text = "Add Device";
            AddDeviceButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            AddDeviceButton.UseAccentColor = false;
            AddDeviceButton.UseVisualStyleBackColor = true;
            AddDeviceButton.Click += AddDeviceButton_Click;
            // 
            // EditUserButton
            // 
            EditUserButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EditUserButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            EditUserButton.Depth = 0;
            EditUserButton.HighEmphasis = true;
            EditUserButton.Icon = null;
            EditUserButton.Location = new Point(6, 140);
            EditUserButton.Margin = new Padding(4, 6, 4, 6);
            EditUserButton.MouseState = MaterialSkin.MouseState.HOVER;
            EditUserButton.Name = "EditUserButton";
            EditUserButton.NoAccentTextColor = Color.Empty;
            EditUserButton.Size = new Size(92, 36);
            EditUserButton.TabIndex = 9;
            EditUserButton.Text = "Edit User";
            EditUserButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            EditUserButton.UseAccentColor = false;
            EditUserButton.UseVisualStyleBackColor = true;
            EditUserButton.Click += EditUserButton_Click;
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(251, 8);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(81, 19);
            materialLabel11.TabIndex = 8;
            materialLabel11.Text = "Description";
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(130, 8);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(71, 19);
            materialLabel10.TabIndex = 7;
            materialLabel10.Text = "Password";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(6, 8);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(78, 19);
            materialLabel7.TabIndex = 6;
            materialLabel7.Text = "User Name";
            // 
            // PullUserListButton
            // 
            PullUserListButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PullUserListButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            PullUserListButton.Depth = 0;
            PullUserListButton.HighEmphasis = true;
            PullUserListButton.Icon = null;
            PullUserListButton.Location = new Point(860, 8);
            PullUserListButton.Margin = new Padding(4, 6, 4, 6);
            PullUserListButton.MouseState = MaterialSkin.MouseState.HOVER;
            PullUserListButton.Name = "PullUserListButton";
            PullUserListButton.NoAccentTextColor = Color.Empty;
            PullUserListButton.Size = new Size(91, 36);
            PullUserListButton.TabIndex = 5;
            PullUserListButton.Text = "User List";
            PullUserListButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            PullUserListButton.UseAccentColor = false;
            PullUserListButton.UseVisualStyleBackColor = true;
            PullUserListButton.Click += PullUserListButton_Click;
            // 
            // UserListTextBox
            // 
            UserListTextBox.BackColor = Color.FromArgb(255, 255, 255);
            UserListTextBox.BorderStyle = BorderStyle.None;
            UserListTextBox.Depth = 0;
            UserListTextBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            UserListTextBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            UserListTextBox.Location = new Point(448, 8);
            UserListTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            UserListTextBox.Name = "UserListTextBox";
            UserListTextBox.ReadOnly = true;
            UserListTextBox.Size = new Size(405, 339);
            UserListTextBox.TabIndex = 4;
            UserListTextBox.Text = "";
            // 
            // UserCreatelButton
            // 
            UserCreatelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UserCreatelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            UserCreatelButton.Depth = 0;
            UserCreatelButton.HighEmphasis = true;
            UserCreatelButton.Icon = null;
            UserCreatelButton.Location = new Point(6, 92);
            UserCreatelButton.Margin = new Padding(4, 6, 4, 6);
            UserCreatelButton.MouseState = MaterialSkin.MouseState.HOVER;
            UserCreatelButton.Name = "UserCreatelButton";
            UserCreatelButton.NoAccentTextColor = Color.Empty;
            UserCreatelButton.Size = new Size(90, 36);
            UserCreatelButton.TabIndex = 3;
            UserCreatelButton.Text = "Add User";
            UserCreatelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            UserCreatelButton.UseAccentColor = false;
            UserCreatelButton.UseVisualStyleBackColor = true;
            UserCreatelButton.Click += UserCreatelButton_Click_1;
            // 
            // UserDescriptionTextBox
            // 
            UserDescriptionTextBox.AnimateReadOnly = false;
            UserDescriptionTextBox.BorderStyle = BorderStyle.None;
            UserDescriptionTextBox.Depth = 0;
            UserDescriptionTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            UserDescriptionTextBox.LeadingIcon = null;
            UserDescriptionTextBox.Location = new Point(251, 30);
            UserDescriptionTextBox.MaxLength = 50;
            UserDescriptionTextBox.MouseState = MaterialSkin.MouseState.OUT;
            UserDescriptionTextBox.Multiline = false;
            UserDescriptionTextBox.Name = "UserDescriptionTextBox";
            UserDescriptionTextBox.Size = new Size(174, 50);
            UserDescriptionTextBox.TabIndex = 2;
            UserDescriptionTextBox.Text = "";
            UserDescriptionTextBox.TrailingIcon = null;
            // 
            // UserPasswordTextBox
            // 
            UserPasswordTextBox.AnimateReadOnly = false;
            UserPasswordTextBox.BorderStyle = BorderStyle.None;
            UserPasswordTextBox.Depth = 0;
            UserPasswordTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            UserPasswordTextBox.LeadingIcon = null;
            UserPasswordTextBox.Location = new Point(130, 30);
            UserPasswordTextBox.MaxLength = 50;
            UserPasswordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            UserPasswordTextBox.Multiline = false;
            UserPasswordTextBox.Name = "UserPasswordTextBox";
            UserPasswordTextBox.Size = new Size(100, 50);
            UserPasswordTextBox.TabIndex = 1;
            UserPasswordTextBox.Text = "";
            UserPasswordTextBox.TrailingIcon = null;
            // 
            // UserLoginTextBox
            // 
            UserLoginTextBox.AnimateReadOnly = false;
            UserLoginTextBox.BorderStyle = BorderStyle.None;
            UserLoginTextBox.Depth = 0;
            UserLoginTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            UserLoginTextBox.LeadingIcon = null;
            UserLoginTextBox.Location = new Point(6, 30);
            UserLoginTextBox.MaxLength = 50;
            UserLoginTextBox.MouseState = MaterialSkin.MouseState.OUT;
            UserLoginTextBox.Multiline = false;
            UserLoginTextBox.Name = "UserLoginTextBox";
            UserLoginTextBox.Size = new Size(100, 50);
            UserLoginTextBox.TabIndex = 0;
            UserLoginTextBox.Text = "";
            UserLoginTextBox.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(577, 21);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(51, 19);
            materialLabel2.TabIndex = 50;
            materialLabel2.Text = "Alarms";
            // 
            // AlarmTextBox
            // 
            AlarmTextBox.BackColor = Color.FromArgb(255, 255, 255);
            AlarmTextBox.BorderStyle = BorderStyle.None;
            AlarmTextBox.Depth = 0;
            AlarmTextBox.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            AlarmTextBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            AlarmTextBox.Location = new Point(441, 46);
            AlarmTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            AlarmTextBox.Name = "AlarmTextBox";
            AlarmTextBox.ReadOnly = true;
            AlarmTextBox.Size = new Size(347, 302);
            AlarmTextBox.TabIndex = 51;
            AlarmTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Start";
            FormClosed += Form1_FormClosed;
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
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
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
        private MaterialSkin.Controls.MaterialTextBox TempMaxTextBox;
        private MaterialSkin.Controls.MaterialTextBox TempMinTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton SetAlarmlButton;
        private MaterialSkin.Controls.MaterialButton UserCreatelButton;
        private MaterialSkin.Controls.MaterialTextBox UserDescriptionTextBox;
        private MaterialSkin.Controls.MaterialTextBox UserPasswordTextBox;
        private MaterialSkin.Controls.MaterialTextBox UserLoginTextBox;
        private MaterialSkin.Controls.MaterialButton PullUserListButton;
        private MaterialSkin.Controls.MaterialMultiLineTextBox UserListTextBox;
        private MaterialSkin.Controls.MaterialComboBox AlarmComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialComboBox DeviceComboBox;
        private MaterialSkin.Controls.MaterialButton EditUserButton;
        private MaterialSkin.Controls.MaterialButton EditDeviceButton;
        private MaterialSkin.Controls.MaterialButton AddDeviceButton;
        private MaterialSkin.Controls.MaterialButton DeviceListButton;
        private MaterialSkin.Controls.MaterialTextBox DeviceDescriptionTextBox;
        private MaterialSkin.Controls.MaterialTextBox DeviceIdTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private MaterialSkin.Controls.MaterialComboBox DeviceChartsPageComboBox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox AlarmTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
