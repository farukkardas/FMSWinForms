﻿namespace FMSWindows
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loginPanelButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.registerPanelButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticoneAnimateWindow1 = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.siticoneAnimateWindow2 = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.siticoneContextMenuStrip1 = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.uc_LoginForm1 = new FMSWindows.UserControls.Uc_LoginForm();
            this.uc_RegisterForm1 = new FMSWindows.Uc_RegisterForm();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanelButton
            // 
            this.loginPanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loginPanelButton.Animated = true;
            this.loginPanelButton.AutoRoundedCorners = true;
            this.loginPanelButton.BackColor = System.Drawing.Color.Transparent;
            this.loginPanelButton.BorderRadius = 20;
            this.loginPanelButton.CheckedState.Parent = this.loginPanelButton;
            this.loginPanelButton.CustomImages.Parent = this.loginPanelButton;
            this.loginPanelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginPanelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginPanelButton.DisabledState.FillColor = System.Drawing.Color.Cornsilk;
            this.loginPanelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginPanelButton.DisabledState.Parent = this.loginPanelButton;
            this.loginPanelButton.FillColor = System.Drawing.Color.Red;
            this.loginPanelButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginPanelButton.ForeColor = System.Drawing.Color.White;
            this.loginPanelButton.HoverState.Parent = this.loginPanelButton;
            this.loginPanelButton.Location = new System.Drawing.Point(53, 260);
            this.loginPanelButton.Name = "loginPanelButton";
            this.loginPanelButton.ShadowDecoration.Parent = this.loginPanelButton;
            this.loginPanelButton.Size = new System.Drawing.Size(180, 43);
            this.loginPanelButton.TabIndex = 0;
            this.loginPanelButton.Text = "Login";
            this.loginPanelButton.Click += new System.EventHandler(this.loginPanelButton_Click);
            // 
            // registerPanelButton
            // 
            this.registerPanelButton.CheckedState.Parent = this.registerPanelButton;
            this.registerPanelButton.CustomImages.Parent = this.registerPanelButton;
            this.registerPanelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerPanelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerPanelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerPanelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerPanelButton.DisabledState.Parent = this.registerPanelButton;
            this.registerPanelButton.FillColor = System.Drawing.Color.Red;
            this.registerPanelButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registerPanelButton.ForeColor = System.Drawing.Color.White;
            this.registerPanelButton.HoverState.Parent = this.registerPanelButton;
            this.registerPanelButton.Location = new System.Drawing.Point(53, 332);
            this.registerPanelButton.Name = "registerPanelButton";
            this.registerPanelButton.ShadowDecoration.Parent = this.registerPanelButton;
            this.registerPanelButton.Size = new System.Drawing.Size(180, 43);
            this.registerPanelButton.TabIndex = 1;
            this.registerPanelButton.Text = "Register";
            this.registerPanelButton.Click += new System.EventHandler(this.registerPanelButton_Click);
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            // 
            // siticoneContextMenuStrip1
            // 
            this.siticoneContextMenuStrip1.Name = "siticoneContextMenuStrip1";
            this.siticoneContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.siticoneContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.siticoneContextMenuStrip1.RenderStyle.ColorTable = null;
            this.siticoneContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.siticoneContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.siticoneContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.siticoneContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.siticoneContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.siticoneContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.siticoneContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("PROXON", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(310, 12);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(44, 20);
            this.siticoneHtmlLabel1.TabIndex = 7;
            this.siticoneHtmlLabel1.Text = "FMS";
            // 
            // uc_LoginForm1
            // 
            this.uc_LoginForm1.Location = new System.Drawing.Point(276, 36);
            this.uc_LoginForm1.Name = "uc_LoginForm1";
            this.uc_LoginForm1.Size = new System.Drawing.Size(400, 352);
            this.uc_LoginForm1.TabIndex = 5;
            // 
            // uc_RegisterForm1
            // 
            this.uc_RegisterForm1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_RegisterForm1.Location = new System.Drawing.Point(276, 36);
            this.uc_RegisterForm1.Name = "uc_RegisterForm1";
            this.uc_RegisterForm1.Size = new System.Drawing.Size(400, 354);
            this.uc_RegisterForm1.TabIndex = 0;
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.Animated = true;
            this.siticoneButton2.AutoRoundedCorners = true;
            this.siticoneButton2.BorderRadius = 20;
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.DisabledState.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.Red;
            this.siticoneButton2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoverState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(53, 332);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(180, 43);
            this.siticoneButton2.TabIndex = 1;
            this.siticoneButton2.Text = "Register";
            this.siticoneButton2.Click += new System.EventHandler(this.registerPanelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 400);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uc_LoginForm1);
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.registerPanelButton);
            this.Controls.Add(this.loginPanelButton);
            this.Controls.Add(this.uc_RegisterForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton loginPanelButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton registerPanelButton;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow2;
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip siticoneContextMenuStrip1;
        private UserControls.Uc_LoginForm uc_LoginForm1;
        private Uc_RegisterForm uc_RegisterForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
    }
}

