namespace LoginBasesDeDatos
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pibIconoLogin = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picbCerrar = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibIconoLogin)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pibIconoLogin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 417);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pibIconoLogin
            // 
            this.pibIconoLogin.Image = ((System.Drawing.Image)(resources.GetObject("pibIconoLogin.Image")));
            this.pibIconoLogin.Location = new System.Drawing.Point(174, 91);
            this.pibIconoLogin.Name = "pibIconoLogin";
            this.pibIconoLogin.Size = new System.Drawing.Size(50, 56);
            this.pibIconoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibIconoLogin.TabIndex = 1;
            this.pibIconoLogin.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.panel2.Controls.Add(this.picbCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 31);
            this.panel2.TabIndex = 6;
            // 
            // picbCerrar
            // 
            this.picbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picbCerrar.Image")));
            this.picbCerrar.Location = new System.Drawing.Point(378, 1);
            this.picbCerrar.Name = "picbCerrar";
            this.picbCerrar.Size = new System.Drawing.Size(25, 30);
            this.picbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbCerrar.TabIndex = 5;
            this.picbCerrar.TabStop = false;
            this.picbCerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.AllowAnimations = true;
            this.btnIngresar.AllowMouseEffects = true;
            this.btnIngresar.AllowToggling = false;
            this.btnIngresar.AnimationSpeed = 200;
            this.btnIngresar.AutoGenerateColors = false;
            this.btnIngresar.AutoRoundBorders = false;
            this.btnIngresar.AutoSizeLeftIcon = true;
            this.btnIngresar.AutoSizeRightIcon = true;
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(101)))), ((int)(((byte)(187)))));
            this.btnIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngresar.BackgroundImage")));
            this.btnIngresar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIngresar.ButtonText = "Ingresar";
            this.btnIngresar.ButtonTextMarginLeft = 0;
            this.btnIngresar.ColorContrastOnClick = 45;
            this.btnIngresar.ColorContrastOnHover = 45;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnIngresar.CustomizableEdges = borderEdges1;
            this.btnIngresar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIngresar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnIngresar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnIngresar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnIngresar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnIngresar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnIngresar.IconMarginLeft = 11;
            this.btnIngresar.IconPadding = 10;
            this.btnIngresar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnIngresar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnIngresar.IconSize = 25;
            this.btnIngresar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(101)))), ((int)(((byte)(187)))));
            this.btnIngresar.IdleBorderRadius = 15;
            this.btnIngresar.IdleBorderThickness = 1;
            this.btnIngresar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(101)))), ((int)(((byte)(187)))));
            this.btnIngresar.IdleIconLeftImage = null;
            this.btnIngresar.IdleIconRightImage = null;
            this.btnIngresar.IndicateFocus = false;
            this.btnIngresar.Location = new System.Drawing.Point(127, 349);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnIngresar.OnDisabledState.BorderRadius = 15;
            this.btnIngresar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIngresar.OnDisabledState.BorderThickness = 1;
            this.btnIngresar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnIngresar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnIngresar.OnDisabledState.IconLeftImage = null;
            this.btnIngresar.OnDisabledState.IconRightImage = null;
            this.btnIngresar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(152)))));
            this.btnIngresar.onHoverState.BorderRadius = 15;
            this.btnIngresar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIngresar.onHoverState.BorderThickness = 1;
            this.btnIngresar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(152)))));
            this.btnIngresar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.onHoverState.IconLeftImage = null;
            this.btnIngresar.onHoverState.IconRightImage = null;
            this.btnIngresar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(101)))), ((int)(((byte)(187)))));
            this.btnIngresar.OnIdleState.BorderRadius = 15;
            this.btnIngresar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIngresar.OnIdleState.BorderThickness = 1;
            this.btnIngresar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(101)))), ((int)(((byte)(187)))));
            this.btnIngresar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.OnIdleState.IconLeftImage = null;
            this.btnIngresar.OnIdleState.IconRightImage = null;
            this.btnIngresar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(214)))));
            this.btnIngresar.OnPressedState.BorderRadius = 15;
            this.btnIngresar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIngresar.OnPressedState.BorderThickness = 1;
            this.btnIngresar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(214)))));
            this.btnIngresar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.OnPressedState.IconLeftImage = null;
            this.btnIngresar.OnPressedState.IconRightImage = null;
            this.btnIngresar.Size = new System.Drawing.Size(150, 39);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIngresar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIngresar.TextMarginLeft = 0;
            this.btnIngresar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnIngresar.UseDefaultRadiusAndThickness = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(41, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(41, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.AcceptsReturn = false;
            this.txtContraseña.AcceptsTab = false;
            this.txtContraseña.AnimationSpeed = 200;
            this.txtContraseña.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtContraseña.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtContraseña.BackColor = System.Drawing.Color.White;
            this.txtContraseña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtContraseña.BackgroundImage")));
            this.txtContraseña.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(152)))));
            this.txtContraseña.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtContraseña.BorderColorHover = System.Drawing.Color.Silver;
            this.txtContraseña.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtContraseña.BorderRadius = 20;
            this.txtContraseña.BorderThickness = 1;
            this.txtContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.DefaultFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.DefaultText = "";
            this.txtContraseña.FillColor = System.Drawing.Color.White;
            this.txtContraseña.HideSelection = true;
            this.txtContraseña.IconLeft = null;
            this.txtContraseña.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.IconPadding = 10;
            this.txtContraseña.IconRight = null;
            this.txtContraseña.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.Lines = new string[0];
            this.txtContraseña.Location = new System.Drawing.Point(46, 273);
            this.txtContraseña.MaxLength = 32767;
            this.txtContraseña.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtContraseña.Modified = false;
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(152)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtContraseña.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtContraseña.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Silver;
            stateProperties3.FillColor = System.Drawing.Color.White;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtContraseña.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtContraseña.OnIdleState = stateProperties4;
            this.txtContraseña.Padding = new System.Windows.Forms.Padding(3);
            this.txtContraseña.PasswordChar = '●';
            this.txtContraseña.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtContraseña.PlaceholderText = "";
            this.txtContraseña.ReadOnly = false;
            this.txtContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.SelectionLength = 0;
            this.txtContraseña.SelectionStart = 0;
            this.txtContraseña.ShortcutsEnabled = true;
            this.txtContraseña.Size = new System.Drawing.Size(331, 44);
            this.txtContraseña.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContraseña.TextMarginBottom = 0;
            this.txtContraseña.TextMarginLeft = 3;
            this.txtContraseña.TextMarginTop = 0;
            this.txtContraseña.TextPlaceholder = "";
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.WordWrap = true;
            this.txtContraseña.TextChanged += new System.EventHandler(this.bunifuTextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AcceptsReturn = false;
            this.txtUsuario.AcceptsTab = false;
            this.txtUsuario.AnimationSpeed = 200;
            this.txtUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUsuario.BackgroundImage")));
            this.txtUsuario.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(152)))));
            this.txtUsuario.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUsuario.BorderColorHover = System.Drawing.Color.Silver;
            this.txtUsuario.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtUsuario.BorderRadius = 20;
            this.txtUsuario.BorderThickness = 1;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.FillColor = System.Drawing.Color.White;
            this.txtUsuario.HideSelection = true;
            this.txtUsuario.IconLeft = null;
            this.txtUsuario.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.IconPadding = 10;
            this.txtUsuario.IconRight = null;
            this.txtUsuario.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(46, 182);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUsuario.Modified = false;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(152)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.Silver;
            stateProperties7.FillColor = System.Drawing.Color.White;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.OnIdleState = stateProperties8;
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.PlaceholderText = "";
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(331, 44);
            this.txtUsuario.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.TextMarginBottom = 0;
            this.txtUsuario.TextMarginLeft = 3;
            this.txtUsuario.TextMarginTop = 0;
            this.txtUsuario.TextPlaceholder = "";
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.WordWrap = true;
            this.txtUsuario.TextChanged += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(415, 417);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibIconoLogin)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextBox txtUsuario;
        private Bunifu.UI.WinForms.BunifuTextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnIngresar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pibIconoLogin;
        private System.Windows.Forms.PictureBox picbCerrar;
    }
}

