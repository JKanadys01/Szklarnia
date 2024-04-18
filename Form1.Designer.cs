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
            button1 = new Button();
            label1 = new Label();
            username_textBox = new TextBox();
            logout_button = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(328, 98);
            button1.Name = "button1";
            button1.Size = new Size(127, 58);
            button1.TabIndex = 0;
            button1.Text = "Chart menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 1;
            label1.Text = "User:";
            // 
            // username_textBox
            // 
            username_textBox.Location = new Point(51, 9);
            username_textBox.Name = "username_textBox";
            username_textBox.ReadOnly = true;
            username_textBox.Size = new Size(100, 23);
            username_textBox.TabIndex = 2;
            // 
            // logout_button
            // 
            logout_button.Location = new Point(12, 50);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(127, 58);
            logout_button.TabIndex = 3;
            logout_button.Text = "Logout";
            logout_button.UseVisualStyleBackColor = true;
            logout_button.Click += logout_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(logout_button);
            Controls.Add(username_textBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox username_textBox;
        private Button logout_button;
    }
}
