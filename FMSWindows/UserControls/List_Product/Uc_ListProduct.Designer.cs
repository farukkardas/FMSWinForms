namespace FMSWindows.UserControls.List_Product
{
    partial class Uc_ListProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.listProductDgw = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.uc_AddListProduct1 = new FMSWindows.UserControls.List_Product.Uc_AddListProduct();
            ((System.ComponentModel.ISupportInitialize)(this.listProductDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Novel Sans Pro Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(4, 4);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(117, 27);
            this.siticoneHtmlLabel1.TabIndex = 0;
            this.siticoneHtmlLabel1.Text = "List Product";
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.BorderColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.BorderRadius = 5;
            this.siticoneButton2.BorderThickness = 1;
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.DisabledState.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.Red;
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoverState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(140, 0);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(147, 34);
            this.siticoneButton2.TabIndex = 7;
            this.siticoneButton2.Text = "Add Product";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // listProductDgw
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.listProductDgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.listProductDgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listProductDgw.BackgroundColor = System.Drawing.Color.White;
            this.listProductDgw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listProductDgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listProductDgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listProductDgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.listProductDgw.ColumnHeadersHeight = 4;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listProductDgw.DefaultCellStyle = dataGridViewCellStyle15;
            this.listProductDgw.EnableHeadersVisualStyles = false;
            this.listProductDgw.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listProductDgw.Location = new System.Drawing.Point(-3, 61);
            this.listProductDgw.Name = "listProductDgw";
            this.listProductDgw.RowHeadersVisible = false;
            this.listProductDgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listProductDgw.Size = new System.Drawing.Size(853, 569);
            this.listProductDgw.TabIndex = 9;
            this.listProductDgw.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.listProductDgw.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listProductDgw.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.listProductDgw.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listProductDgw.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listProductDgw.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.listProductDgw.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listProductDgw.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.listProductDgw.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listProductDgw.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.listProductDgw.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.listProductDgw.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.listProductDgw.ThemeStyle.HeaderStyle.Height = 4;
            this.listProductDgw.ThemeStyle.ReadOnly = false;
            this.listProductDgw.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listProductDgw.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listProductDgw.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.listProductDgw.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listProductDgw.ThemeStyle.RowsStyle.Height = 22;
            this.listProductDgw.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listProductDgw.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // uc_AddListProduct1
            // 
            this.uc_AddListProduct1.Location = new System.Drawing.Point(-3, 61);
            this.uc_AddListProduct1.Name = "uc_AddListProduct1";
            this.uc_AddListProduct1.Size = new System.Drawing.Size(856, 569);
            this.uc_AddListProduct1.TabIndex = 10;
            // 
            // Uc_ListProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listProductDgw);
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.uc_AddListProduct1);
            this.Name = "Uc_ListProduct";
            this.Size = new System.Drawing.Size(850, 630);
            this.Load += new System.EventHandler(this.Uc_ListProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listProductDgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView listProductDgw;
        private Uc_AddListProduct uc_AddListProduct1;
    }
}
