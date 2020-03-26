namespace Icarus
{
    partial class CustomMessabeBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessabeBox));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.messageBar = new System.Windows.Forms.Panel();
            this.messageTypeLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.messageTextLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.signUp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.messageBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(359, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // messageBar
            // 
            this.messageBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.messageBar.Controls.Add(this.messageTypeLbl);
            this.messageBar.Controls.Add(this.closeButton);
            this.messageBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.messageBar.Location = new System.Drawing.Point(0, 0);
            this.messageBar.Name = "messageBar";
            this.messageBar.Size = new System.Drawing.Size(387, 33);
            this.messageBar.TabIndex = 2;
            // 
            // messageTypeLbl
            // 
            this.messageTypeLbl.AutoSize = true;
            this.messageTypeLbl.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTypeLbl.ForeColor = System.Drawing.Color.White;
            this.messageTypeLbl.Location = new System.Drawing.Point(7, 7);
            this.messageTypeLbl.Name = "messageTypeLbl";
            this.messageTypeLbl.Size = new System.Drawing.Size(64, 19);
            this.messageTypeLbl.TabIndex = 3;
            this.messageTypeLbl.Text = "Message";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.messageTextLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 117);
            this.panel2.TabIndex = 3;
            // 
            // messageTextLbl
            // 
            this.messageTextLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTextLbl.Font = new System.Drawing.Font("Roboto Cn", 10.75F);
            this.messageTextLbl.Location = new System.Drawing.Point(0, 0);
            this.messageTextLbl.Margin = new System.Windows.Forms.Padding(10);
            this.messageTextLbl.Name = "messageTextLbl";
            this.messageTextLbl.Size = new System.Drawing.Size(387, 117);
            this.messageTextLbl.TabIndex = 0;
            this.messageTextLbl.Text = "Custom Message...... ";
            this.messageTextLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.signUp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 58);
            this.panel3.TabIndex = 4;
            // 
            // signUp
            // 
            this.signUp.ActiveBorderThickness = 1;
            this.signUp.ActiveCornerRadius = 20;
            this.signUp.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.signUp.ActiveForecolor = System.Drawing.Color.White;
            this.signUp.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.signUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.signUp.BackColor = System.Drawing.SystemColors.Control;
            this.signUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signUp.BackgroundImage")));
            this.signUp.ButtonText = "OK";
            this.signUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUp.Font = new System.Drawing.Font("Roboto Cn", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.ForeColor = System.Drawing.Color.SeaGreen;
            this.signUp.IdleBorderThickness = 1;
            this.signUp.IdleCornerRadius = 20;
            this.signUp.IdleFillColor = System.Drawing.Color.White;
            this.signUp.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.signUp.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.signUp.Location = new System.Drawing.Point(300, 4);
            this.signUp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(75, 49);
            this.signUp.TabIndex = 1;
            this.signUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.messageBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // CustomMessabeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 208);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.messageBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomMessabeBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessabeBox";
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.messageBar.ResumeLayout(false);
            this.messageBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel messageBar;
        private System.Windows.Forms.Label messageTypeLbl;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 signUp;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label messageTextLbl;
    }
}