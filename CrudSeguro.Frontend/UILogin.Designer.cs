namespace Crud_Seguro
{
    partial class UILogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Subtitle = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.FrmUser = new System.Windows.Forms.Label();
            this.FrmPassword = new System.Windows.Forms.Label();
            this.textUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.textPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnIngresar = new Guna.UI2.WinForms.Guna2Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblErrorUser = new System.Windows.Forms.Label();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.Subtitle);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 450);
            this.panel1.TabIndex = 0;
            // 
            // Subtitle
            // 
            this.Subtitle.AutoSize = true;
            this.Subtitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Subtitle.ForeColor = System.Drawing.Color.White;
            this.Subtitle.Location = new System.Drawing.Point(45, 259);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(369, 30);
            this.Subtitle.TabIndex = 2;
            this.Subtitle.Text = "Gestion De Datos Segura y Confiable";
            this.Subtitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Title.Location = new System.Drawing.Point(102, 205);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(235, 54);
            this.Title.TabIndex = 1;
            this.Title.Text = "CrudSeguro";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Crud_Seguro.Properties.Resources.logoipsum_419;
            this.pictureBox1.Location = new System.Drawing.Point(137, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Uighur", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(491, 37);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(163, 51);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Iniciar sesión";
            this.lblLogin.Click += new System.EventHandler(this.FrmLogin_Click);
            // 
            // FrmUser
            // 
            this.FrmUser.AutoSize = true;
            this.FrmUser.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.FrmUser.Location = new System.Drawing.Point(496, 103);
            this.FrmUser.Name = "FrmUser";
            this.FrmUser.Size = new System.Drawing.Size(73, 22);
            this.FrmUser.TabIndex = 4;
            this.FrmUser.Text = "Usuario";
            // 
            // FrmPassword
            // 
            this.FrmPassword.AutoSize = true;
            this.FrmPassword.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.FrmPassword.Location = new System.Drawing.Point(496, 215);
            this.FrmPassword.Name = "FrmPassword";
            this.FrmPassword.Size = new System.Drawing.Size(99, 22);
            this.FrmPassword.TabIndex = 5;
            this.FrmPassword.Text = "Contraseña";
            this.FrmPassword.Click += new System.EventHandler(this.FrmPassword_Click);
            // 
            // textUser
            // 
            this.textUser.BorderRadius = 10;
            this.textUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUser.DefaultText = "";
            this.textUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textUser.IconLeft = global::Crud_Seguro.Properties.Resources.person_24dp_D08370_FILL0_wght400_GRAD0_opsz24;
            this.textUser.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.textUser.IconLeftSize = new System.Drawing.Size(25, 25);
            this.textUser.Location = new System.Drawing.Point(499, 126);
            this.textUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textUser.Name = "textUser";
            this.textUser.PlaceholderText = "";
            this.textUser.SelectedText = "";
            this.textUser.Size = new System.Drawing.Size(254, 49);
            this.textUser.TabIndex = 0;
            this.textUser.TextChanged += new System.EventHandler(this.textUser_TextChanged);
            // 
            // textPassword
            // 
            this.textPassword.BorderRadius = 10;
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.DefaultText = "";
            this.textPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPassword.IconLeft = global::Crud_Seguro.Properties.Resources.password_29dp_D08370_FILL0_wght400_GRAD0_opsz24;
            this.textPassword.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.textPassword.IconRight = global::Crud_Seguro.Properties.Resources.visibility_off_29dp_D08370_FILL0_wght400_GRAD0_opsz24;
            this.textPassword.IconRightOffset = new System.Drawing.Point(5, 0);
            this.textPassword.Location = new System.Drawing.Point(500, 242);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.PlaceholderText = "";
            this.textPassword.SelectedText = "";
            this.textPassword.Size = new System.Drawing.Size(254, 49);
            this.textPassword.TabIndex = 1;
            this.textPassword.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BorderRadius = 25;
            this.btnIngresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIngresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIngresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(131)))), ((int)(((byte)(112)))));
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Uighur", 12F);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(522, 341);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(217, 45);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.lblError.Location = new System.Drawing.Point(495, 389);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(32, 15);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            this.lblError.Click += new System.EventHandler(this.lblError_Click);
            // 
            // lblErrorUser
            // 
            this.lblErrorUser.AutoSize = true;
            this.lblErrorUser.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.lblErrorUser.Location = new System.Drawing.Point(497, 180);
            this.lblErrorUser.Name = "lblErrorUser";
            this.lblErrorUser.Size = new System.Drawing.Size(32, 15);
            this.lblErrorUser.TabIndex = 11;
            this.lblErrorUser.Text = "Error";
            this.lblErrorUser.Visible = false;
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.lblErrorPassword.Location = new System.Drawing.Point(497, 296);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(32, 15);
            this.lblErrorPassword.TabIndex = 12;
            this.lblErrorPassword.Text = "Error";
            this.lblErrorPassword.Visible = false;
            this.lblErrorPassword.Click += new System.EventHandler(this.lblErrorPassword_Click);
            // 
            // UILogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErrorPassword);
            this.Controls.Add(this.lblErrorUser);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.FrmPassword);
            this.Controls.Add(this.FrmUser);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UILogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Subtitle;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label FrmUser;
        private System.Windows.Forms.Label FrmPassword;
        private Guna.UI2.WinForms.Guna2TextBox textPassword;
        private Guna.UI2.WinForms.Guna2TextBox textUser;
        private Guna.UI2.WinForms.Guna2Button btnIngresar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblErrorUser;
        private System.Windows.Forms.Label lblErrorPassword;
    }
}

