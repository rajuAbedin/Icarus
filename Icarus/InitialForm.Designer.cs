namespace Icarus
{
    partial class InitialForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.keyTxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.confPasswordTxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.usernametxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.surnameTxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.firstnameTxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.shopNametxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.signUp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.passwordTxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.contactNumberTxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.contactNumberTxt);
            this.panel1.Controls.Add(this.passwordTxt);
            this.panel1.Controls.Add(this.signUp);
            this.panel1.Controls.Add(this.keyTxt);
            this.panel1.Controls.Add(this.confPasswordTxt);
            this.panel1.Controls.Add(this.usernametxt);
            this.panel1.Controls.Add(this.surnameTxt);
            this.panel1.Controls.Add(this.firstnameTxt);
            this.panel1.Controls.Add(this.shopNametxt);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 487);
            this.panel1.TabIndex = 0;
            // 
            // keyTxt
            // 
            this.keyTxt.AcceptsReturn = false;
            this.keyTxt.AcceptsTab = false;
            this.keyTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.keyTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.keyTxt.BackColor = System.Drawing.Color.White;
            this.keyTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("keyTxt.BackgroundImage")));
            this.keyTxt.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.keyTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.keyTxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.keyTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.keyTxt.BorderRadius = 1;
            this.keyTxt.BorderThickness = 2;
            this.keyTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.keyTxt.DefaultFont = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyTxt.DefaultText = "";
            this.keyTxt.FillColor = System.Drawing.Color.White;
            this.keyTxt.HideSelection = true;
            this.keyTxt.IconLeft = null;
            this.keyTxt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.keyTxt.IconPadding = 10;
            this.keyTxt.IconRight = null;
            this.keyTxt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.keyTxt.Location = new System.Drawing.Point(21, 326);
            this.keyTxt.MaxLength = 32767;
            this.keyTxt.MinimumSize = new System.Drawing.Size(100, 35);
            this.keyTxt.Modified = false;
            this.keyTxt.Name = "keyTxt";
            this.keyTxt.PasswordChar = '\0';
            this.keyTxt.ReadOnly = false;
            this.keyTxt.SelectedText = "";
            this.keyTxt.SelectionLength = 0;
            this.keyTxt.SelectionStart = 0;
            this.keyTxt.ShortcutsEnabled = true;
            this.keyTxt.Size = new System.Drawing.Size(406, 35);
            this.keyTxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.keyTxt.TabIndex = 9;
            this.keyTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.keyTxt.TextMarginLeft = 5;
            this.keyTxt.TextPlaceholder = "License Key";
            this.keyTxt.UseSystemPasswordChar = false;
            // 
            // confPasswordTxt
            // 
            this.confPasswordTxt.AcceptsReturn = false;
            this.confPasswordTxt.AcceptsTab = false;
            this.confPasswordTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.confPasswordTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.confPasswordTxt.BackColor = System.Drawing.Color.White;
            this.confPasswordTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confPasswordTxt.BackgroundImage")));
            this.confPasswordTxt.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.confPasswordTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.confPasswordTxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.confPasswordTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.confPasswordTxt.BorderRadius = 1;
            this.confPasswordTxt.BorderThickness = 2;
            this.confPasswordTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.confPasswordTxt.DefaultFont = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confPasswordTxt.DefaultText = "";
            this.confPasswordTxt.FillColor = System.Drawing.Color.White;
            this.confPasswordTxt.HideSelection = true;
            this.confPasswordTxt.IconLeft = null;
            this.confPasswordTxt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.confPasswordTxt.IconPadding = 10;
            this.confPasswordTxt.IconRight = null;
            this.confPasswordTxt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.confPasswordTxt.Location = new System.Drawing.Point(227, 285);
            this.confPasswordTxt.MaxLength = 32767;
            this.confPasswordTxt.MinimumSize = new System.Drawing.Size(100, 35);
            this.confPasswordTxt.Modified = false;
            this.confPasswordTxt.Name = "confPasswordTxt";
            this.confPasswordTxt.PasswordChar = '\0';
            this.confPasswordTxt.ReadOnly = false;
            this.confPasswordTxt.SelectedText = "";
            this.confPasswordTxt.SelectionLength = 0;
            this.confPasswordTxt.SelectionStart = 0;
            this.confPasswordTxt.ShortcutsEnabled = true;
            this.confPasswordTxt.Size = new System.Drawing.Size(200, 35);
            this.confPasswordTxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.confPasswordTxt.TabIndex = 8;
            this.confPasswordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.confPasswordTxt.TextMarginLeft = 5;
            this.confPasswordTxt.TextPlaceholder = "Confirm Password";
            this.confPasswordTxt.UseSystemPasswordChar = false;
            // 
            // usernametxt
            // 
            this.usernametxt.AcceptsReturn = false;
            this.usernametxt.AcceptsTab = false;
            this.usernametxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.usernametxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.usernametxt.BackColor = System.Drawing.Color.White;
            this.usernametxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usernametxt.BackgroundImage")));
            this.usernametxt.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.usernametxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.usernametxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.usernametxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.usernametxt.BorderRadius = 1;
            this.usernametxt.BorderThickness = 2;
            this.usernametxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usernametxt.DefaultFont = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.DefaultText = "";
            this.usernametxt.FillColor = System.Drawing.Color.White;
            this.usernametxt.HideSelection = true;
            this.usernametxt.IconLeft = null;
            this.usernametxt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.usernametxt.IconPadding = 10;
            this.usernametxt.IconRight = null;
            this.usernametxt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.usernametxt.Location = new System.Drawing.Point(21, 244);
            this.usernametxt.MaxLength = 32767;
            this.usernametxt.MinimumSize = new System.Drawing.Size(100, 35);
            this.usernametxt.Modified = false;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.PasswordChar = '\0';
            this.usernametxt.ReadOnly = false;
            this.usernametxt.SelectedText = "";
            this.usernametxt.SelectionLength = 0;
            this.usernametxt.SelectionStart = 0;
            this.usernametxt.ShortcutsEnabled = true;
            this.usernametxt.Size = new System.Drawing.Size(200, 35);
            this.usernametxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.usernametxt.TabIndex = 5;
            this.usernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernametxt.TextMarginLeft = 5;
            this.usernametxt.TextPlaceholder = "Username";
            this.usernametxt.UseSystemPasswordChar = false;
            // 
            // surnameTxt
            // 
            this.surnameTxt.AcceptsReturn = false;
            this.surnameTxt.AcceptsTab = false;
            this.surnameTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.surnameTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.surnameTxt.BackColor = System.Drawing.Color.White;
            this.surnameTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("surnameTxt.BackgroundImage")));
            this.surnameTxt.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.surnameTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.surnameTxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.surnameTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.surnameTxt.BorderRadius = 1;
            this.surnameTxt.BorderThickness = 2;
            this.surnameTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.surnameTxt.DefaultFont = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTxt.DefaultText = "";
            this.surnameTxt.FillColor = System.Drawing.Color.White;
            this.surnameTxt.HideSelection = true;
            this.surnameTxt.IconLeft = null;
            this.surnameTxt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.surnameTxt.IconPadding = 10;
            this.surnameTxt.IconRight = null;
            this.surnameTxt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.surnameTxt.Location = new System.Drawing.Point(227, 203);
            this.surnameTxt.MaxLength = 32767;
            this.surnameTxt.MinimumSize = new System.Drawing.Size(100, 35);
            this.surnameTxt.Modified = false;
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.PasswordChar = '\0';
            this.surnameTxt.ReadOnly = false;
            this.surnameTxt.SelectedText = "";
            this.surnameTxt.SelectionLength = 0;
            this.surnameTxt.SelectionStart = 0;
            this.surnameTxt.ShortcutsEnabled = true;
            this.surnameTxt.Size = new System.Drawing.Size(200, 35);
            this.surnameTxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.surnameTxt.TabIndex = 4;
            this.surnameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.surnameTxt.TextMarginLeft = 5;
            this.surnameTxt.TextPlaceholder = "Surname";
            this.surnameTxt.UseSystemPasswordChar = false;
            // 
            // firstnameTxt
            // 
            this.firstnameTxt.AcceptsReturn = false;
            this.firstnameTxt.AcceptsTab = false;
            this.firstnameTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.firstnameTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.firstnameTxt.BackColor = System.Drawing.Color.White;
            this.firstnameTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstnameTxt.BackgroundImage")));
            this.firstnameTxt.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.firstnameTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.firstnameTxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.firstnameTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.firstnameTxt.BorderRadius = 1;
            this.firstnameTxt.BorderThickness = 2;
            this.firstnameTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.firstnameTxt.DefaultFont = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTxt.DefaultText = "";
            this.firstnameTxt.FillColor = System.Drawing.Color.White;
            this.firstnameTxt.HideSelection = true;
            this.firstnameTxt.IconLeft = null;
            this.firstnameTxt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.firstnameTxt.IconPadding = 10;
            this.firstnameTxt.IconRight = null;
            this.firstnameTxt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.firstnameTxt.Location = new System.Drawing.Point(21, 203);
            this.firstnameTxt.MaxLength = 32767;
            this.firstnameTxt.MinimumSize = new System.Drawing.Size(100, 35);
            this.firstnameTxt.Modified = false;
            this.firstnameTxt.Name = "firstnameTxt";
            this.firstnameTxt.PasswordChar = '\0';
            this.firstnameTxt.ReadOnly = false;
            this.firstnameTxt.SelectedText = "";
            this.firstnameTxt.SelectionLength = 0;
            this.firstnameTxt.SelectionStart = 0;
            this.firstnameTxt.ShortcutsEnabled = true;
            this.firstnameTxt.Size = new System.Drawing.Size(200, 35);
            this.firstnameTxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.firstnameTxt.TabIndex = 3;
            this.firstnameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.firstnameTxt.TextMarginLeft = 5;
            this.firstnameTxt.TextPlaceholder = "Firstname";
            this.firstnameTxt.UseSystemPasswordChar = false;
            // 
            // shopNametxt
            // 
            this.shopNametxt.AcceptsReturn = false;
            this.shopNametxt.AcceptsTab = false;
            this.shopNametxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.shopNametxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.shopNametxt.BackColor = System.Drawing.Color.White;
            this.shopNametxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shopNametxt.BackgroundImage")));
            this.shopNametxt.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.shopNametxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.shopNametxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.shopNametxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.shopNametxt.BorderRadius = 1;
            this.shopNametxt.BorderThickness = 2;
            this.shopNametxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.shopNametxt.DefaultFont = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopNametxt.DefaultText = "";
            this.shopNametxt.FillColor = System.Drawing.Color.White;
            this.shopNametxt.HideSelection = true;
            this.shopNametxt.IconLeft = null;
            this.shopNametxt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.shopNametxt.IconPadding = 10;
            this.shopNametxt.IconRight = null;
            this.shopNametxt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.shopNametxt.Location = new System.Drawing.Point(21, 162);
            this.shopNametxt.MaxLength = 32767;
            this.shopNametxt.MinimumSize = new System.Drawing.Size(100, 35);
            this.shopNametxt.Modified = false;
            this.shopNametxt.Name = "shopNametxt";
            this.shopNametxt.PasswordChar = '\0';
            this.shopNametxt.ReadOnly = false;
            this.shopNametxt.SelectedText = "";
            this.shopNametxt.SelectionLength = 0;
            this.shopNametxt.SelectionStart = 0;
            this.shopNametxt.ShortcutsEnabled = true;
            this.shopNametxt.Size = new System.Drawing.Size(406, 35);
            this.shopNametxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.shopNametxt.TabIndex = 2;
            this.shopNametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.shopNametxt.TextMarginLeft = 5;
            this.shopNametxt.TextPlaceholder = "Shop Name";
            this.shopNametxt.UseSystemPasswordChar = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(938, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 5;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // signUp
            // 
            this.signUp.ActiveBorderThickness = 1;
            this.signUp.ActiveCornerRadius = 20;
            this.signUp.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.signUp.ActiveForecolor = System.Drawing.Color.White;
            this.signUp.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.signUp.BackColor = System.Drawing.Color.Transparent;
            this.signUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signUp.BackgroundImage")));
            this.signUp.ButtonText = "Sign Up";
            this.signUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUp.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.ForeColor = System.Drawing.Color.SeaGreen;
            this.signUp.IdleBorderThickness = 1;
            this.signUp.IdleCornerRadius = 20;
            this.signUp.IdleFillColor = System.Drawing.Color.White;
            this.signUp.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.signUp.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.signUp.Location = new System.Drawing.Point(274, 360);
            this.signUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(153, 55);
            this.signUp.TabIndex = 0;
            this.signUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.AcceptsReturn = false;
            this.passwordTxt.AcceptsTab = false;
            this.passwordTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordTxt.BackColor = System.Drawing.Color.White;
            this.passwordTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordTxt.BackgroundImage")));
            this.passwordTxt.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.passwordTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.passwordTxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.passwordTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.passwordTxt.BorderRadius = 1;
            this.passwordTxt.BorderThickness = 2;
            this.passwordTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordTxt.DefaultFont = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.DefaultText = "";
            this.passwordTxt.FillColor = System.Drawing.Color.White;
            this.passwordTxt.HideSelection = true;
            this.passwordTxt.IconLeft = null;
            this.passwordTxt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.passwordTxt.IconPadding = 10;
            this.passwordTxt.IconRight = null;
            this.passwordTxt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.passwordTxt.Location = new System.Drawing.Point(21, 285);
            this.passwordTxt.MaxLength = 32767;
            this.passwordTxt.MinimumSize = new System.Drawing.Size(100, 35);
            this.passwordTxt.Modified = false;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '\0';
            this.passwordTxt.ReadOnly = false;
            this.passwordTxt.SelectedText = "";
            this.passwordTxt.SelectionLength = 0;
            this.passwordTxt.SelectionStart = 0;
            this.passwordTxt.ShortcutsEnabled = true;
            this.passwordTxt.Size = new System.Drawing.Size(200, 35);
            this.passwordTxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.passwordTxt.TabIndex = 7;
            this.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTxt.TextMarginLeft = 5;
            this.passwordTxt.TextPlaceholder = "Password";
            this.passwordTxt.UseSystemPasswordChar = false;
            // 
            // contactNumberTxt
            // 
            this.contactNumberTxt.AcceptsReturn = false;
            this.contactNumberTxt.AcceptsTab = false;
            this.contactNumberTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.contactNumberTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.contactNumberTxt.BackColor = System.Drawing.Color.White;
            this.contactNumberTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contactNumberTxt.BackgroundImage")));
            this.contactNumberTxt.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.contactNumberTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.contactNumberTxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.contactNumberTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.contactNumberTxt.BorderRadius = 1;
            this.contactNumberTxt.BorderThickness = 2;
            this.contactNumberTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.contactNumberTxt.DefaultFont = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumberTxt.DefaultText = "";
            this.contactNumberTxt.FillColor = System.Drawing.Color.White;
            this.contactNumberTxt.HideSelection = true;
            this.contactNumberTxt.IconLeft = null;
            this.contactNumberTxt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.contactNumberTxt.IconPadding = 10;
            this.contactNumberTxt.IconRight = null;
            this.contactNumberTxt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.contactNumberTxt.Location = new System.Drawing.Point(227, 244);
            this.contactNumberTxt.MaxLength = 32767;
            this.contactNumberTxt.MinimumSize = new System.Drawing.Size(100, 35);
            this.contactNumberTxt.Modified = false;
            this.contactNumberTxt.Name = "contactNumberTxt";
            this.contactNumberTxt.PasswordChar = '\0';
            this.contactNumberTxt.ReadOnly = false;
            this.contactNumberTxt.SelectedText = "";
            this.contactNumberTxt.SelectionLength = 0;
            this.contactNumberTxt.SelectionStart = 0;
            this.contactNumberTxt.ShortcutsEnabled = true;
            this.contactNumberTxt.Size = new System.Drawing.Size(200, 35);
            this.contactNumberTxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.contactNumberTxt.TabIndex = 6;
            this.contactNumberTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.contactNumberTxt.TextMarginLeft = 5;
            this.contactNumberTxt.TextPlaceholder = "Contact Number";
            this.contactNumberTxt.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(15, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "ADMIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Lt", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(109, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "SIGN UP";
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 487);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InitialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InitialForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox confPasswordTxt;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox usernametxt;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox surnameTxt;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox firstnameTxt;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox keyTxt;
        private Bunifu.Framework.UI.BunifuThinButton2 signUp;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox contactNumberTxt;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox passwordTxt;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox shopNametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}