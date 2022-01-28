namespace FMSWindows.UserControls.Sales_Data
{
    partial class Uc_SalesData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_SalesData));
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.saleDataDgw = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.emptyPicture = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.totalSaleText = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.profitText = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataDgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(4, 4);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(108, 27);
            this.siticoneHtmlLabel1.TabIndex = 0;
            this.siticoneHtmlLabel1.Text = "Sales Data";
            // 
            // saleDataDgw
            // 
            this.saleDataDgw.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.saleDataDgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.saleDataDgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.saleDataDgw.BackgroundColor = System.Drawing.Color.White;
            this.saleDataDgw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saleDataDgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.saleDataDgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleDataDgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.saleDataDgw.ColumnHeadersHeight = 4;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.saleDataDgw.DefaultCellStyle = dataGridViewCellStyle11;
            this.saleDataDgw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saleDataDgw.EnableHeadersVisualStyles = false;
            this.saleDataDgw.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.saleDataDgw.Location = new System.Drawing.Point(0, 90);
            this.saleDataDgw.Name = "saleDataDgw";
            this.saleDataDgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleDataDgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.saleDataDgw.RowHeadersVisible = false;
            this.saleDataDgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.saleDataDgw.Size = new System.Drawing.Size(1050, 560);
            this.saleDataDgw.TabIndex = 1;
            this.saleDataDgw.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.saleDataDgw.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.saleDataDgw.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.saleDataDgw.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.saleDataDgw.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.saleDataDgw.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.saleDataDgw.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.saleDataDgw.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red;
            this.saleDataDgw.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.saleDataDgw.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.saleDataDgw.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.saleDataDgw.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.saleDataDgw.ThemeStyle.HeaderStyle.Height = 4;
            this.saleDataDgw.ThemeStyle.ReadOnly = false;
            this.saleDataDgw.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.saleDataDgw.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.saleDataDgw.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.saleDataDgw.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.saleDataDgw.ThemeStyle.RowsStyle.Height = 22;
            this.saleDataDgw.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.saleDataDgw.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // emptyPicture
            // 
            this.emptyPicture.Image = ((System.Drawing.Image)(resources.GetObject("emptyPicture.Image")));
            this.emptyPicture.ImageRotate = 0F;
            this.emptyPicture.Location = new System.Drawing.Point(295, 236);
            this.emptyPicture.Name = "emptyPicture";
            this.emptyPicture.ShadowDecoration.Parent = this.emptyPicture;
            this.emptyPicture.Size = new System.Drawing.Size(262, 256);
            this.emptyPicture.TabIndex = 2;
            this.emptyPicture.TabStop = false;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.Animated = true;
            this.siticoneButton1.BorderThickness = 1;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.White;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
            this.siticoneButton1.Image = ((System.Drawing.Image)(resources.GetObject("siticoneButton1.Image")));
            this.siticoneButton1.Location = new System.Drawing.Point(857, 35);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(39, 27);
            this.siticoneButton1.TabIndex = 3;
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.siticoneHtmlLabel2.IsSelectionEnabled = false;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(4, 54);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(81, 20);
            this.siticoneHtmlLabel2.TabIndex = 4;
            this.siticoneHtmlLabel2.Text = "Total Sales:";
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.siticoneHtmlLabel3.IsSelectionEnabled = false;
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(220, 54);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(42, 20);
            this.siticoneHtmlLabel3.TabIndex = 5;
            this.siticoneHtmlLabel3.Text = "Profit:";
            // 
            // totalSaleText
            // 
            this.totalSaleText.BackColor = System.Drawing.Color.Transparent;
            this.totalSaleText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalSaleText.IsSelectionEnabled = false;
            this.totalSaleText.Location = new System.Drawing.Point(85, 54);
            this.totalSaleText.Name = "totalSaleText";
            this.totalSaleText.Size = new System.Drawing.Size(11, 20);
            this.totalSaleText.TabIndex = 6;
            this.totalSaleText.Text = "1";
            this.totalSaleText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // profitText
            // 
            this.profitText.BackColor = System.Drawing.Color.Transparent;
            this.profitText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profitText.IsSelectionEnabled = false;
            this.profitText.Location = new System.Drawing.Point(265, 54);
            this.profitText.Name = "profitText";
            this.profitText.Size = new System.Drawing.Size(35, 20);
            this.profitText.TabIndex = 7;
            this.profitText.Text = "6500";
            this.profitText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Uc_SalesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.profitText);
            this.Controls.Add(this.totalSaleText);
            this.Controls.Add(this.siticoneHtmlLabel3);
            this.Controls.Add(this.siticoneHtmlLabel2);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.emptyPicture);
            this.Controls.Add(this.saleDataDgw);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Name = "Uc_SalesData";
            this.Size = new System.Drawing.Size(1050, 650);
            this.Load += new System.EventHandler(this.Uc_SalesData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleDataDgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView saleDataDgw;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox emptyPicture;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel totalSaleText;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel profitText;
    }
}
