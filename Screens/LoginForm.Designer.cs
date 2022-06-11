
namespace POS_App
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
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.IDTextbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.passwordTextbox = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.LimeGreen;
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton.Location = new System.Drawing.Point(341, 321);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(110, 53);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseCustomBackColor = true;
            this.LoginButton.UseCustomForeColor = true;
            this.LoginButton.UseSelectable = true;
            this.LoginButton.UseStyleColors = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // IDTextbox
            // 
            // 
            // 
            // 
            this.IDTextbox.CustomButton.Image = null;
            this.IDTextbox.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.IDTextbox.CustomButton.Name = "";
            this.IDTextbox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.IDTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.IDTextbox.CustomButton.TabIndex = 1;
            this.IDTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IDTextbox.CustomButton.UseSelectable = true;
            this.IDTextbox.CustomButton.Visible = false;
            this.IDTextbox.Lines = new string[0];
            this.IDTextbox.Location = new System.Drawing.Point(341, 194);
            this.IDTextbox.MaxLength = 32767;
            this.IDTextbox.Multiline = true;
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.PasswordChar = '\0';
            this.IDTextbox.PromptText = "ID";
            this.IDTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IDTextbox.SelectedText = "";
            this.IDTextbox.SelectionLength = 0;
            this.IDTextbox.SelectionStart = 0;
            this.IDTextbox.ShortcutsEnabled = true;
            this.IDTextbox.Size = new System.Drawing.Size(207, 35);
            this.IDTextbox.TabIndex = 1;
            this.IDTextbox.UseSelectable = true;
            this.IDTextbox.WaterMark = "ID";
            this.IDTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.IDTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(176, 194);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Your ID:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(176, 255);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Your Password:";
            // 
            // passwordTextbox
            // 
            // 
            // 
            // 
            this.passwordTextbox.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.CustomButton.Image = null;
            this.passwordTextbox.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.passwordTextbox.CustomButton.Name = "";
            this.passwordTextbox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.passwordTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextbox.CustomButton.TabIndex = 1;
            this.passwordTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextbox.CustomButton.UseSelectable = true;
            this.passwordTextbox.CustomButton.Visible = false;
            this.passwordTextbox.Lines = new string[0];
            this.passwordTextbox.Location = new System.Drawing.Point(341, 255);
            this.passwordTextbox.MaxLength = 32767;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '●';
            this.passwordTextbox.PromptText = "Password";
            this.passwordTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextbox.SelectedText = "";
            this.passwordTextbox.SelectionLength = 0;
            this.passwordTextbox.SelectionStart = 0;
            this.passwordTextbox.ShortcutsEnabled = true;
            this.passwordTextbox.Size = new System.Drawing.Size(207, 35);
            this.passwordTextbox.TabIndex = 3;
            this.passwordTextbox.UseSelectable = true;
            this.passwordTextbox.UseSystemPasswordChar = true;
            this.passwordTextbox.WaterMark = "Password";
            this.passwordTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(313, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.IDTextbox);
            this.Controls.Add(this.LoginButton);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "POS Login";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton LoginButton;
        private MetroFramework.Controls.MetroTextBox IDTextbox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox passwordTextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

