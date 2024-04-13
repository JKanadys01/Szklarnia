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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            comboBoxParameters = new ComboBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            comboBoxTimeFrame = new ComboBox();
            buttonDraw = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(3, 3);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1909, 664);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
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
            // ChartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonDraw);
            Controls.Add(comboBoxTimeFrame);
            Controls.Add(chart1);
            Controls.Add(comboBoxParameters);
            Name = "ChartForm";
            Text = "ChartForm";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxParameters;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ComboBox comboBoxTimeFrame;
        private Button buttonDraw;
        private DateTimePicker dateTimePicker1;
    }
}