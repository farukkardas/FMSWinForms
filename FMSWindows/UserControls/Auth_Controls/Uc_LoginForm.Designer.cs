namespace FMSWindows.UserControls
{
    partial class Uc_LoginForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordEmptyLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.emailEmptyLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneTextBox2 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.rememberMeChck = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.SuspendLayout();
            // 
            // passwordEmptyLabel
            // 
            this.passwordEmptyLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordEmptyLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordEmptyLabel.Location = new System.Drawing.Point(148, 208);
            this.passwordEmptyLabel.Name = "passwordEmptyLabel";
            this.passwordEmptyLabel.Size = new System.Drawing.Size(137, 15);
            this.passwordEmptyLabel.TabIndex = 13;
            this.passwordEmptyLabel.Text = "Password can not be empty!";
            // 
            // emailEmptyLabel
            // 
            this.emailEmptyLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailEmptyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailEmptyLabel.ForeColor = System.Drawing.Color.Red;
            this.emailEmptyLabel.Location = new System.Drawing.Point(160, 139);
            this.emailEmptyLabel.Name = "emailEmptyLabel";
            this.emailEmptyLabel.Size = new System.Drawing.Size(116, 15);
            this.emailEmptyLabel.TabIndex = 12;
            this.emailEmptyLabel.Text = "Email can not be empty!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(111, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(111, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email";
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.Red;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(123, 266);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(180, 36);
            this.siticoneButton1.TabIndex = 9;
            this.siticoneButton1.Text = "Login";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.Animated = true;
            this.siticoneTextBox1.AutoRoundedCorners = true;
            this.siticoneTextBox1.BorderRadius = 13;
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.FocusedState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.HoverState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Location = new System.Drawing.Point(114, 104);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderText = "";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.ShadowDecoration.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Size = new System.Drawing.Size(200, 29);
            this.siticoneTextBox1.TabIndex = 7;
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(191, 42);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(50, 27);
            this.siticoneHtmlLabel1.TabIndex = 14;
            this.siticoneHtmlLabel1.Text = "Login";
            // 
            // siticoneTextBox2
            // 
            this.siticoneTextBox2.Animated = true;
            this.siticoneTextBox2.AutoRoundedCorners = true;
            this.siticoneTextBox2.BorderRadius = 13;
            this.siticoneTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox2.DefaultText = "";
            this.siticoneTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox2.DisabledState.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.FocusedState.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.HoverState.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.Location = new System.Drawing.Point(114, 173);
            this.siticoneTextBox2.Name = "siticoneTextBox2";
            this.siticoneTextBox2.PasswordChar = '\0';
            this.siticoneTextBox2.PlaceholderText = "";
            this.siticoneTextBox2.SelectedText = "";
            this.siticoneTextBox2.ShadowDecoration.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.Size = new System.Drawing.Size(200, 29);
            this.siticoneTextBox2.TabIndex = 15;
            // 
            // rememberMeChck
            // 
            this.rememberMeChck.AutoSize = true;
            this.rememberMeChck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rememberMeChck.CheckedState.BorderRadius = 0;
            this.rememberMeChck.CheckedState.BorderThickness = 0;
            this.rememberMeChck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rememberMeChck.Location = new System.Drawing.Point(123, 229);
            this.rememberMeChck.Name = "rememberMeChck";
            this.rememberMeChck.Size = new System.Drawing.Size(95, 17);
            this.rememberMeChck.TabIndex = 16;
            this.rememberMeChck.Text = "Remember Me";
            this.rememberMeChck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rememberMeChck.UncheckedState.BorderRadius = 0;
            this.rememberMeChck.UncheckedState.BorderThickness = 0;
            this.rememberMeChck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // Uc_LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rememberMeChck);
            this.Controls.Add(this.siticoneTextBox2);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.passwordEmptyLabel);
            this.Controls.Add(this.emailEmptyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.siticoneTextBox1);
            this.Name = "Uc_LoginForm";
            this.Size = new System.Drawing.Size(450, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel passwordEmptyLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel emailEmptyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox rememberMeChck;
    }
}
