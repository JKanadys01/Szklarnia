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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            loginmaterialTextBox = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            passwordmaterialTextBox = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(603, 339);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(67, 36);
            materialButton1.TabIndex = 5;
            materialButton1.Text = "Enter";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // loginmaterialTextBox
            // 
            loginmaterialTextBox.AnimateReadOnly = false;
            loginmaterialTextBox.BorderStyle = BorderStyle.None;
            loginmaterialTextBox.Depth = 0;
            loginmaterialTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            loginmaterialTextBox.LeadingIcon = null;
            loginmaterialTextBox.Location = new Point(590, 168);
            loginmaterialTextBox.MaxLength = 50;
            loginmaterialTextBox.MouseState = MaterialSkin.MouseState.OUT;
            loginmaterialTextBox.Multiline = false;
            loginmaterialTextBox.Name = "loginmaterialTextBox";
            loginmaterialTextBox.Size = new Size(100, 50);
            loginmaterialTextBox.TabIndex = 6;
            loginmaterialTextBox.Text = "";
            loginmaterialTextBox.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(614, 146);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(41, 19);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "Login";
            // 
            // passwordmaterialTextBox
            // 
            passwordmaterialTextBox.AnimateReadOnly = false;
            passwordmaterialTextBox.BorderStyle = BorderStyle.None;
            passwordmaterialTextBox.Depth = 0;
            passwordmaterialTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordmaterialTextBox.LeadingIcon = null;
            passwordmaterialTextBox.Location = new Point(590, 269);
            passwordmaterialTextBox.MaxLength = 50;
            passwordmaterialTextBox.MouseState = MaterialSkin.MouseState.OUT;
            passwordmaterialTextBox.Multiline = false;
            passwordmaterialTextBox.Name = "passwordmaterialTextBox";
            passwordmaterialTextBox.Size = new Size(100, 50);
            passwordmaterialTextBox.TabIndex = 8;
            passwordmaterialTextBox.Text = "";
            passwordmaterialTextBox.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(599, 245);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(71, 19);
            materialLabel2.TabIndex = 9;
            materialLabel2.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(433, 413);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 523);
            Controls.Add(pictureBox1);
            Controls.Add(materialLabel2);
            Controls.Add(passwordmaterialTextBox);
            Controls.Add(materialLabel1);
            Controls.Add(loginmaterialTextBox);
            Controls.Add(materialButton1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GreenHouse";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox loginmaterialTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox passwordmaterialTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private PictureBox pictureBox1;
    }
}