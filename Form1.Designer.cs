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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            logoutmaterialButton = new MaterialSkin.Controls.MaterialButton();
            Chartmenu_materialButton = new MaterialSkin.Controls.MaterialButton();
            username_materialTextBox = new MaterialSkin.Controls.MaterialTextBox();
            imageList1 = new ImageList(components);
            tabControl1 = new TabControl();
            TemperaturetabPage = new TabPage();
            TemperaturecartesianChart = new LiveCharts.WinForms.CartesianChart();
            humiditytabPage = new TabPage();
            humiditycartesianChart = new LiveCharts.WinForms.CartesianChart();
            InsolationtabPage = new TabPage();
            InsolationcartesianChart = new LiveCharts.WinForms.CartesianChart();
            materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            StopmaterialRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            tabControl1.SuspendLayout();
            TemperaturetabPage.SuspendLayout();
            humiditytabPage.SuspendLayout();
            InsolationtabPage.SuspendLayout();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(6, 88);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(72, 19);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "Username";
            // 
            // logoutmaterialButton
            // 
            logoutmaterialButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            logoutmaterialButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            logoutmaterialButton.Depth = 0;
            logoutmaterialButton.HighEmphasis = true;
            logoutmaterialButton.Icon = null;
            logoutmaterialButton.Location = new Point(132, 135);
            logoutmaterialButton.Margin = new Padding(4, 6, 4, 6);
            logoutmaterialButton.MouseState = MaterialSkin.MouseState.HOVER;
            logoutmaterialButton.Name = "logoutmaterialButton";
            logoutmaterialButton.NoAccentTextColor = Color.Empty;
            logoutmaterialButton.Size = new Size(78, 36);
            logoutmaterialButton.TabIndex = 6;
            logoutmaterialButton.Text = "Logout";
            logoutmaterialButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            logoutmaterialButton.UseAccentColor = false;
            logoutmaterialButton.UseVisualStyleBackColor = true;
            logoutmaterialButton.Click += logoutmaterialButton_Click;
            // 
            // Chartmenu_materialButton
            // 
            Chartmenu_materialButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Chartmenu_materialButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Chartmenu_materialButton.Depth = 0;
            Chartmenu_materialButton.HighEmphasis = true;
            Chartmenu_materialButton.Icon = null;
            Chartmenu_materialButton.Location = new Point(116, 183);
            Chartmenu_materialButton.Margin = new Padding(4, 6, 4, 6);
            Chartmenu_materialButton.MouseState = MaterialSkin.MouseState.HOVER;
            Chartmenu_materialButton.Name = "Chartmenu_materialButton";
            Chartmenu_materialButton.NoAccentTextColor = Color.Empty;
            Chartmenu_materialButton.Size = new Size(114, 36);
            Chartmenu_materialButton.TabIndex = 7;
            Chartmenu_materialButton.Text = "Chart menu";
            Chartmenu_materialButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Chartmenu_materialButton.UseAccentColor = false;
            Chartmenu_materialButton.UseVisualStyleBackColor = true;
            Chartmenu_materialButton.Click += Chartmenu_materialButton_Click;
            // 
            // username_materialTextBox
            // 
            username_materialTextBox.AnimateReadOnly = false;
            username_materialTextBox.BorderStyle = BorderStyle.None;
            username_materialTextBox.Depth = 0;
            username_materialTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            username_materialTextBox.LeadingIcon = null;
            username_materialTextBox.Location = new Point(84, 76);
            username_materialTextBox.MaxLength = 50;
            username_materialTextBox.MouseState = MaterialSkin.MouseState.OUT;
            username_materialTextBox.Multiline = false;
            username_materialTextBox.Name = "username_materialTextBox";
            username_materialTextBox.ReadOnly = true;
            username_materialTextBox.Size = new Size(191, 50);
            username_materialTextBox.TabIndex = 8;
            username_materialTextBox.Text = "";
            username_materialTextBox.TrailingIcon = null;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "humidity.png");
            imageList1.Images.SetKeyName(1, "Insolation.png");
            imageList1.Images.SetKeyName(2, "temp.png");
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TemperaturetabPage);
            tabControl1.Controls.Add(humiditytabPage);
            tabControl1.Controls.Add(InsolationtabPage);
            tabControl1.ImageList = imageList1;
            tabControl1.Location = new Point(923, 71);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(995, 439);
            tabControl1.TabIndex = 10;
            // 
            // TemperaturetabPage
            // 
            TemperaturetabPage.Controls.Add(TemperaturecartesianChart);
            TemperaturetabPage.ImageKey = "temp.png";
            TemperaturetabPage.Location = new Point(4, 39);
            TemperaturetabPage.Name = "TemperaturetabPage";
            TemperaturetabPage.Padding = new Padding(3);
            TemperaturetabPage.Size = new Size(987, 396);
            TemperaturetabPage.TabIndex = 0;
            TemperaturetabPage.Text = "Temperatur";
            TemperaturetabPage.UseVisualStyleBackColor = true;
            // 
            // TemperaturecartesianChart
            // 
            TemperaturecartesianChart.Location = new Point(6, 10);
            TemperaturecartesianChart.Name = "TemperaturecartesianChart";
            TemperaturecartesianChart.Size = new Size(975, 380);
            TemperaturecartesianChart.TabIndex = 0;
            TemperaturecartesianChart.Text = "cartesianChart1";
            // 
            // humiditytabPage
            // 
            humiditytabPage.Controls.Add(humiditycartesianChart);
            humiditytabPage.ImageKey = "humidity.png";
            humiditytabPage.Location = new Point(4, 39);
            humiditytabPage.Name = "humiditytabPage";
            humiditytabPage.Padding = new Padding(3);
            humiditytabPage.Size = new Size(987, 396);
            humiditytabPage.TabIndex = 1;
            humiditytabPage.Text = "Humidity";
            humiditytabPage.UseVisualStyleBackColor = true;
            // 
            // humiditycartesianChart
            // 
            humiditycartesianChart.Location = new Point(6, 7);
            humiditycartesianChart.Name = "humiditycartesianChart";
            humiditycartesianChart.Size = new Size(975, 383);
            humiditycartesianChart.TabIndex = 0;
            humiditycartesianChart.Text = "cartesianChart2";
            // 
            // InsolationtabPage
            // 
            InsolationtabPage.Controls.Add(InsolationcartesianChart);
            InsolationtabPage.ImageKey = "Insolation.png";
            InsolationtabPage.Location = new Point(4, 39);
            InsolationtabPage.Name = "InsolationtabPage";
            InsolationtabPage.Padding = new Padding(3);
            InsolationtabPage.Size = new Size(987, 396);
            InsolationtabPage.TabIndex = 2;
            InsolationtabPage.Text = "Insolation";
            InsolationtabPage.UseVisualStyleBackColor = true;
            // 
            // InsolationcartesianChart
            // 
            InsolationcartesianChart.Location = new Point(4, 2);
            InsolationcartesianChart.Name = "InsolationcartesianChart";
            InsolationcartesianChart.Size = new Size(977, 388);
            InsolationcartesianChart.TabIndex = 0;
            InsolationcartesianChart.Text = "cartesianChart3";
            // 
            // materialRadioButton1
            // 
            materialRadioButton1.AutoSize = true;
            materialRadioButton1.Depth = 0;
            materialRadioButton1.Location = new Point(782, 110);
            materialRadioButton1.Margin = new Padding(0);
            materialRadioButton1.MouseLocation = new Point(-1, -1);
            materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton1.Name = "materialRadioButton1";
            materialRadioButton1.Ripple = true;
            materialRadioButton1.Size = new Size(106, 37);
            materialRadioButton1.TabIndex = 11;
            materialRadioButton1.TabStop = true;
            materialRadioButton1.Text = "Check live";
            materialRadioButton1.UseVisualStyleBackColor = true;
            materialRadioButton1.CheckedChanged += materialRadioButton1_CheckedChanged;
            // 
            // StopmaterialRadioButton
            // 
            StopmaterialRadioButton.AutoSize = true;
            StopmaterialRadioButton.Depth = 0;
            StopmaterialRadioButton.Location = new Point(782, 147);
            StopmaterialRadioButton.Margin = new Padding(0);
            StopmaterialRadioButton.MouseLocation = new Point(-1, -1);
            StopmaterialRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            StopmaterialRadioButton.Name = "StopmaterialRadioButton";
            StopmaterialRadioButton.Ripple = true;
            StopmaterialRadioButton.Size = new Size(68, 37);
            StopmaterialRadioButton.TabIndex = 12;
            StopmaterialRadioButton.TabStop = true;
            StopmaterialRadioButton.Text = "Stop";
            StopmaterialRadioButton.UseVisualStyleBackColor = true;
            StopmaterialRadioButton.CheckedChanged += StopmaterialRadioButton_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(StopmaterialRadioButton);
            Controls.Add(materialRadioButton1);
            Controls.Add(tabControl1);
            Controls.Add(username_materialTextBox);
            Controls.Add(Chartmenu_materialButton);
            Controls.Add(logoutmaterialButton);
            Controls.Add(materialLabel1);
            Name = "Form1";
            Text = "Start";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            TemperaturetabPage.ResumeLayout(false);
            humiditytabPage.ResumeLayout(false);
            InsolationtabPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton logoutmaterialButton;
        private MaterialSkin.Controls.MaterialButton Chartmenu_materialButton;
        private MaterialSkin.Controls.MaterialTextBox username_materialTextBox;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage TemperaturetabPage;
        private TabPage humiditytabPage;
        private TabPage InsolationtabPage;
        private LiveCharts.WinForms.CartesianChart TemperaturecartesianChart;
        private LiveCharts.WinForms.CartesianChart humiditycartesianChart;
        private LiveCharts.WinForms.CartesianChart InsolationcartesianChart;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private ImageList imageList1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private MaterialSkin.Controls.MaterialRadioButton StopmaterialRadioButton;
    }
}
