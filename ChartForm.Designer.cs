namespace GreenHouse
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxParameters = new ComboBox();
            comboBoxTimeFrame = new ComboBox();
            buttonDraw = new Button();
            dateTimePicker1 = new DateTimePicker();
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            live_button = new Button();
            SuspendLayout();
            // 
            // comboBoxParameters
            // 
            comboBoxParameters.FormattingEnabled = true;
            comboBoxParameters.Location = new Point(12, 694);
            comboBoxParameters.Name = "comboBoxParameters";
            comboBoxParameters.Size = new Size(121, 23);
            comboBoxParameters.TabIndex = 0;
            // 
            // comboBoxTimeFrame
            // 
            comboBoxTimeFrame.FormattingEnabled = true;
            comboBoxTimeFrame.Location = new Point(139, 694);
            comboBoxTimeFrame.Name = "comboBoxTimeFrame";
            comboBoxTimeFrame.Size = new Size(121, 23);
            comboBoxTimeFrame.TabIndex = 3;
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(73, 723);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(121, 60);
            buttonDraw.TabIndex = 4;
            buttonDraw.Text = "Draw";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(33, 789);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(205, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(12, 1);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(1900, 598);
            cartesianChart1.TabIndex = 6;
            cartesianChart1.Text = "cartesianChart1";
            // 
            // live_button
            // 
            live_button.Location = new Point(468, 723);
            live_button.Name = "live_button";
            live_button.Size = new Size(125, 60);
            live_button.TabIndex = 7;
            live_button.Text = "Go live";
            live_button.UseVisualStyleBackColor = true;
            live_button.Click += live_button_Click;
            // 
            // ChartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(live_button);
            Controls.Add(cartesianChart1);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonDraw);
            Controls.Add(comboBoxTimeFrame);
            Controls.Add(comboBoxParameters);
            Name = "ChartForm";
            Text = "ChartForm";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxParameters;
        private ComboBox comboBoxTimeFrame;
        private Button buttonDraw;
        private DateTimePicker dateTimePicker1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private Button live_button;
    }
}