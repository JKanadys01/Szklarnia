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
            StopmaterialRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
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
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
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
            tabPage2.Controls.Add(StopmaterialRadioButton);
            tabPage2.Controls.Add(materialRadioButton1);
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
            // StopmaterialRadioButton
            // 
            StopmaterialRadioButton.AutoSize = true;
            StopmaterialRadioButton.Depth = 0;
            StopmaterialRadioButton.Location = new Point(779, 77);
            StopmaterialRadioButton.Margin = new Padding(0);
            StopmaterialRadioButton.MouseLocation = new Point(-1, -1);
            StopmaterialRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            StopmaterialRadioButton.Name = "StopmaterialRadioButton";
            StopmaterialRadioButton.Ripple = true;
            StopmaterialRadioButton.Size = new Size(68, 37);
            StopmaterialRadioButton.TabIndex = 19;
            StopmaterialRadioButton.TabStop = true;
            StopmaterialRadioButton.Text = "Stop";
            StopmaterialRadioButton.UseVisualStyleBackColor = true;
            StopmaterialRadioButton.CheckedChanged += StopmaterialRadioButton_CheckedChanged_1;
            // 
            // materialRadioButton1
            // 
            materialRadioButton1.AutoSize = true;
            materialRadioButton1.Depth = 0;
            materialRadioButton1.Location = new Point(779, 40);
            materialRadioButton1.Margin = new Padding(0);
            materialRadioButton1.MouseLocation = new Point(-1, -1);
            materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton1.Name = "materialRadioButton1";
            materialRadioButton1.Ripple = true;
            materialRadioButton1.Size = new Size(106, 37);
            materialRadioButton1.TabIndex = 18;
            materialRadioButton1.TabStop = true;
            materialRadioButton1.Text = "Check live";
            materialRadioButton1.UseVisualStyleBackColor = true;
            materialRadioButton1.CheckedChanged += materialRadioButton1_CheckedChanged_1;
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
            TemperatureTabPage.Controls.Add(TemperaturecartesianChart);
            TemperatureTabPage.ImageKey = "temp.png";
            TemperatureTabPage.Location = new Point(4, 39);
            TemperatureTabPage.Name = "TemperatureTabPage";
            TemperatureTabPage.Padding = new Padding(3);
            TemperatureTabPage.Size = new Size(987, 396);
            TemperatureTabPage.TabIndex = 0;
            TemperatureTabPage.Text = "Temperatur";
            TemperatureTabPage.UseVisualStyleBackColor = true;
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
            HumidityTabPage.Controls.Add(humiditycartesianChart);
            HumidityTabPage.ImageKey = "humidity.png";
            HumidityTabPage.Location = new Point(4, 39);
            HumidityTabPage.Name = "HumidityTabPage";
            HumidityTabPage.Padding = new Padding(3);
            HumidityTabPage.Size = new Size(987, 396);
            HumidityTabPage.TabIndex = 1;
            HumidityTabPage.Text = "Humidity";
            HumidityTabPage.UseVisualStyleBackColor = true;
            // 
            // humiditycartesianChart
            // 
            humiditycartesianChart.Location = new Point(6, 7);
            humiditycartesianChart.Name = "humiditycartesianChart";
            humiditycartesianChart.Size = new Size(975, 383);
            humiditycartesianChart.TabIndex = 0;
            humiditycartesianChart.Text = "cartesianChart2";
            // 
            // InsolationTabPage
            // 
            InsolationTabPage.Controls.Add(InsolationcartesianChart);
            InsolationTabPage.ImageKey = "Insolation.png";
            InsolationTabPage.Location = new Point(4, 39);
            InsolationTabPage.Name = "InsolationTabPage";
            InsolationTabPage.Padding = new Padding(3);
            InsolationTabPage.Size = new Size(987, 396);
            InsolationTabPage.TabIndex = 2;
            InsolationTabPage.Text = "Insolation";
            InsolationTabPage.UseVisualStyleBackColor = true;
            // 
            // InsolationcartesianChart
            // 
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
        private MaterialSkin.Controls.MaterialRadioButton StopmaterialRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
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
    }
}
