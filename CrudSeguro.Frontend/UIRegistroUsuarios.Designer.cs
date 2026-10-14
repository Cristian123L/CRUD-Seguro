namespace Crud_Seguro
{
    partial class UIRegistroUsuarios
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NuevoUsuario = new System.Windows.Forms.Label();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrimerApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSegundoApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNSS = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRFC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbCiudad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSalario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbRol = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtClabe = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.IndianRed;
            this.guna2Panel1.Controls.Add(this.Title);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(267, 480);
            this.guna2Panel1.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Title.Location = new System.Drawing.Point(23, 250);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(199, 46);
            this.Title.TabIndex = 4;
            this.Title.Text = "CrudSeguro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Crud_Seguro.Properties.Resources.logoipsum_419;
            this.pictureBox1.Location = new System.Drawing.Point(49, 178);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // NuevoUsuario
            // 
            this.NuevoUsuario.AutoSize = true;
            this.NuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.NuevoUsuario.Location = new System.Drawing.Point(608, 7);
            this.NuevoUsuario.Name = "NuevoUsuario";
            this.NuevoUsuario.Size = new System.Drawing.Size(519, 48);
            this.NuevoUsuario.TabIndex = 1;
            this.NuevoUsuario.Text = "Registro de Nuevo Usuario";
            this.NuevoUsuario.Click += new System.EventHandler(this.NuevoUsuario_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderRadius = 10;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "Nombre";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Location = new System.Drawing.Point(289, 70);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(254, 48);
            this.txtNombre.TabIndex = 2;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BorderRadius = 10;
            this.txtPrimerApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrimerApellido.DefaultText = "Primer Apellido";
            this.txtPrimerApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrimerApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrimerApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrimerApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrimerApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrimerApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrimerApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrimerApellido.Location = new System.Drawing.Point(289, 126);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.PlaceholderText = "";
            this.txtPrimerApellido.SelectedText = "";
            this.txtPrimerApellido.Size = new System.Drawing.Size(254, 48);
            this.txtPrimerApellido.TabIndex = 3;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BorderRadius = 10;
            this.txtSegundoApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSegundoApellido.DefaultText = "Segundo Apellido";
            this.txtSegundoApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSegundoApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSegundoApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSegundoApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSegundoApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSegundoApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSegundoApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSegundoApellido.Location = new System.Drawing.Point(288, 182);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.PlaceholderText = "";
            this.txtSegundoApellido.SelectedText = "";
            this.txtSegundoApellido.Size = new System.Drawing.Size(254, 48);
            this.txtSegundoApellido.TabIndex = 4;
            this.txtSegundoApellido.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "Email";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(288, 238);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(254, 48);
            this.txtEmail.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderRadius = 10;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.DefaultText = "Teléfono";
            this.txtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.Location = new System.Drawing.Point(288, 350);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "Ej: 5512345678";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.Size = new System.Drawing.Size(254, 48);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged_1);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtNSS
            // 
            this.txtNSS.BorderRadius = 10;
            this.txtNSS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNSS.DefaultText = "Número de Seguridad Social";
            this.txtNSS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNSS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNSS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNSS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNSS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNSS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNSS.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNSS.Location = new System.Drawing.Point(971, 126);
            this.txtNSS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNSS.MaxLength = 11;
            this.txtNSS.Name = "txtNSS";
            this.txtNSS.PlaceholderText = "11 dígitos numéricos";
            this.txtNSS.SelectedText = "";
            this.txtNSS.Size = new System.Drawing.Size(254, 48);
            this.txtNSS.TabIndex = 10;
            this.txtNSS.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // txtRFC
            // 
            this.txtRFC.BorderRadius = 10;
            this.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRFC.DefaultText = "RFC";
            this.txtRFC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRFC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRFC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRFC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRFC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRFC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRFC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRFC.Location = new System.Drawing.Point(971, 70);
            this.txtRFC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRFC.MaxLength = 13;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.PlaceholderText = "";
            this.txtRFC.SelectedText = "";
            this.txtRFC.Size = new System.Drawing.Size(254, 48);
            this.txtRFC.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderRadius = 10;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.DefaultText = "Dirección";
            this.txtDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDireccion.Location = new System.Drawing.Point(640, 238);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.MaxLength = 250;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PlaceholderText = "Calle, Número exterior/interior, Colonia";
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.Size = new System.Drawing.Size(254, 48);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.BackColor = System.Drawing.Color.Transparent;
            this.cmbCiudad.BorderRadius = 10;
            this.cmbCiudad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCiudad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCiudad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCiudad.ItemHeight = 53;
            this.cmbCiudad.Items.AddRange(new object[] {
            "Ciudad",
            "Ciudad de México",
            "Monterrey",
            "Guadalajara"});
            this.cmbCiudad.Location = new System.Drawing.Point(640, 126);
            this.cmbCiudad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(255, 59);
            this.cmbCiudad.StartIndex = 0;
            this.cmbCiudad.TabIndex = 12;
            this.cmbCiudad.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BorderRadius = 25;
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(131)))), ((int)(((byte)(112)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(921, 294);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(371, 70);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Crear Cuenta";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "Estado";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(640, 182);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.MaxLength = 250;
            this.guna2TextBox1.Multiline = true;
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "Calle, Número exterior/interior, Colonia";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(254, 48);
            this.guna2TextBox1.TabIndex = 14;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged_2);
            // 
            // txtCP
            // 
            this.txtCP.BorderRadius = 10;
            this.txtCP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCP.DefaultText = "Código Postal";
            this.txtCP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCP.Location = new System.Drawing.Point(640, 294);
            this.txtCP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCP.MaxLength = 5;
            this.txtCP.Name = "txtCP";
            this.txtCP.PlaceholderText = "11 dígitos numéricos";
            this.txtCP.SelectedText = "";
            this.txtCP.Size = new System.Drawing.Size(254, 48);
            this.txtCP.TabIndex = 15;
            this.txtCP.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged_1);
            // 
            // txtSalario
            // 
            this.txtSalario.BorderRadius = 10;
            this.txtSalario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalario.DefaultText = "Salario";
            this.txtSalario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSalario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSalario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalario.Location = new System.Drawing.Point(640, 350);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalario.MaxLength = 5;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.PlaceholderText = "11 dígitos numéricos";
            this.txtSalario.SelectedText = "";
            this.txtSalario.Size = new System.Drawing.Size(254, 48);
            this.txtSalario.TabIndex = 17;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "Contraseña";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(289, 294);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.MaxLength = 5;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "11 dígitos numéricos";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(254, 48);
            this.txtPassword.TabIndex = 18;
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.Color.Transparent;
            this.cmbRol.BorderRadius = 10;
            this.cmbRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRol.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbRol.ItemHeight = 53;
            this.cmbRol.Items.AddRange(new object[] {
            "Rol",
            "Usuario",
            "Administrador"});
            this.cmbRol.Location = new System.Drawing.Point(640, 70);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(255, 59);
            this.cmbRol.StartIndex = 0;
            this.cmbRol.TabIndex = 19;
            // 
            // txtClabe
            // 
            this.txtClabe.BorderRadius = 10;
            this.txtClabe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClabe.DefaultText = "Clabe Interbancaria";
            this.txtClabe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClabe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClabe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClabe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClabe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClabe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClabe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClabe.Location = new System.Drawing.Point(971, 182);
            this.txtClabe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClabe.MaxLength = 11;
            this.txtClabe.Name = "txtClabe";
            this.txtClabe.PlaceholderText = "11 dígitos numéricos";
            this.txtClabe.SelectedText = "";
            this.txtClabe.Size = new System.Drawing.Size(254, 48);
            this.txtClabe.TabIndex = 20;
            // 
            // UIRegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 480);
            this.Controls.Add(this.txtClabe);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.txtNSS);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.NuevoUsuario);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UIRegistroUsuarios";
            this.Text = "UIRegistroUsuarios";
            this.Load += new System.EventHandler(this.UIRegistroUsuarios_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NuevoUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtPrimerApellido;
        private Guna.UI2.WinForms.Guna2TextBox txtSegundoApellido;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtNSS;
        private Guna.UI2.WinForms.Guna2TextBox txtRFC;
        private Guna.UI2.WinForms.Guna2TextBox txtDireccion;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCiudad;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtCP;
        private Guna.UI2.WinForms.Guna2TextBox txtSalario;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRol;
        private Guna.UI2.WinForms.Guna2TextBox txtClabe;
    }
}