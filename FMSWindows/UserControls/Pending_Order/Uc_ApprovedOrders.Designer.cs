namespace FMSWindows.UserControls.Pending_Order
{
    partial class Uc_ApprovedOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.approvedOrderDgw = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.approvedOrderDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Novel Sans Pro Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(3, 3);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(167, 27);
            this.siticoneHtmlLabel1.TabIndex = 1;
            this.siticoneHtmlLabel1.Text = "Approved Orders";
            // 
            // approvedOrderDgw
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.approvedOrderDgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.approvedOrderDgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.approvedOrderDgw.BackgroundColor = System.Drawing.Color.White;
            this.approvedOrderDgw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.approvedOrderDgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.approvedOrderDgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.approvedOrderDgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.approvedOrderDgw.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.approvedOrderDgw.DefaultCellStyle = dataGridViewCellStyle6;
            this.approvedOrderDgw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.approvedOrderDgw.EnableHeadersVisualStyles = false;
            this.approvedOrderDgw.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.approvedOrderDgw.Location = new System.Drawing.Point(0, 95);
            this.approvedOrderDgw.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.approvedOrderDgw.Name = "approvedOrderDgw";
            this.approvedOrderDgw.RowHeadersVisible = false;
            this.approvedOrderDgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.approvedOrderDgw.Size = new System.Drawing.Size(1050, 555);
            this.approvedOrderDgw.TabIndex = 3;
            this.approvedOrderDgw.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.approvedOrderDgw.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.approvedOrderDgw.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.approvedOrderDgw.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.approvedOrderDgw.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.approvedOrderDgw.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.approvedOrderDgw.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.approvedOrderDgw.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red;
            this.approvedOrderDgw.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.approvedOrderDgw.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.approvedOrderDgw.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.approvedOrderDgw.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.approvedOrderDgw.ThemeStyle.HeaderStyle.Height = 4;
            this.approvedOrderDgw.ThemeStyle.ReadOnly = false;
            this.approvedOrderDgw.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.approvedOrderDgw.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.approvedOrderDgw.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.approvedOrderDgw.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.approvedOrderDgw.ThemeStyle.RowsStyle.Height = 22;
            this.approvedOrderDgw.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.approvedOrderDgw.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneButton2.BorderRadius = 5;
            this.siticoneButton2.BorderThickness = 1;
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.DisabledState.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.LimeGreen;
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoverState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(742, 36);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(147, 34);
            this.siticoneButton2.TabIndex = 6;
            this.siticoneButton2.Text = "Add Delivery NO";
            // 
            // Uc_ApprovedOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.approvedOrderDgw);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Name = "Uc_ApprovedOrders";
            this.Size = new System.Drawing.Size(1050, 650);
            this.Load += new System.EventHandler(this.Uc_ApprovedOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.approvedOrderDgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView approvedOrderDgw;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
    }
}
