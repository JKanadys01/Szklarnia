namespace GreenHouse
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            login_button = new Button();
            login_textBox = new TextBox();
            password_textBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 25);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 89);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // login_button
            // 
            login_button.Location = new Point(306, 153);
            login_button.Name = "login_button";
            login_button.Size = new Size(100, 37);
            login_button.TabIndex = 2;
            login_button.Text = "Enter";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // login_textBox
            // 
            login_textBox.Location = new Point(306, 43);
            login_textBox.Name = "login_textBox";
            login_textBox.Size = new Size(100, 23);
            login_textBox.TabIndex = 3;
            // 
            // password_textBox
            // 
            password_textBox.Location = new Point(306, 107);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(100, 23);
            password_textBox.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(password_textBox);
            Controls.Add(login_textBox);
            Controls.Add(login_button);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button login_button;
        private TextBox login_textBox;
        private TextBox password_textBox;
    }
}