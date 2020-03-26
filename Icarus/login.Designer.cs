namespace Icarus
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.signUp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.usernametxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.messageBar = new System.Windows.Forms.Panel();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.messageTypeLbl = new System.Windows.Forms.Label();
            this.messageBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Lt", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(84, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "IN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "LOG";
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
            this.passwordTxt.Location = new System.Drawing.Point(30, 128);
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
            this.passwordTxt.Size = new System.Drawing.Size(236, 35);
            this.passwordTxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.passwordTxt.TabIndex = 16;
            this.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTxt.TextMarginLeft = 5;
            this.passwordTxt.TextPlaceholder = "Password";
            this.passwordTxt.UseSystemPasswordChar = false;
            // 
            // signUp
            // 
            this.signUp.ActiveBorderThickness = 1;
            this.signUp.ActiveCornerRadius = 20;
            this.signUp.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.signUp.ActiveForecolor = System.Drawing.Color.White;
            this.signUp.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.signUp.BackColor = System.Drawing.SystemColors.Control;
            this.signUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signUp.BackgroundImage")));
            this.signUp.ButtonText = "Log in";
            this.signUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUp.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.ForeColor = System.Drawing.Color.SeaGreen;
            this.signUp.IdleBorderThickness = 1;
            this.signUp.IdleCornerRadius = 20;
            this.signUp.IdleFillColor = System.Drawing.Color.White;
            this.signUp.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.signUp.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.signUp.Location = new System.Drawing.Point(144, 171);
            this.signUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(122, 48);
            this.signUp.TabIndex = 14;
            this.signUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
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
            this.usernametxt.Location = new System.Drawing.Point(30, 87);
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
            this.usernametxt.Size = new System.Drawing.Size(236, 35);
            this.usernametxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.usernametxt.TabIndex = 15;
            this.usernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernametxt.TextMarginLeft = 5;
            this.usernametxt.TextPlaceholder = "Username";
            this.usernametxt.UseSystemPasswordChar = false;
            // 
            // messageBar
            // 
            this.messageBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.messageBar.Controls.Add(this.messageTypeLbl);
            this.messageBar.Controls.Add(this.closeButton);
            this.messageBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.messageBar.Location = new System.Drawing.Point(0, 0);
            this.messageBar.Name = "messageBar";
            this.messageBar.Size = new System.Drawing.Size(294, 33);
            this.messageBar.TabIndex = 19;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(264, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // messageTypeLbl
            // 
            this.messageTypeLbl.AutoSize = true;
            this.messageTypeLbl.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTypeLbl.ForeColor = System.Drawing.Color.White;
            this.messageTypeLbl.Location = new System.Drawing.Point(5, 7);
            this.messageTypeLbl.Name = "messageTypeLbl";
            this.messageTypeLbl.Size = new System.Drawing.Size(51, 19);
            this.messageTypeLbl.TabIndex = 4;
            this.messageTypeLbl.Text = "Icarus ";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 264);
            this.Controls.Add(this.messageBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.usernametxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.messageBar.ResumeLayout(false);
            this.messageBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox passwordTxt;
        private Bunifu.Framework.UI.BunifuThinButton2 signUp;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox usernametxt;
        private System.Windows.Forms.Panel messageBar;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private System.Windows.Forms.Label messageTypeLbl;
    }
}