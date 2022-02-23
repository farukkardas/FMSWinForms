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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_ListProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.emptyPicture = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.listProductDgw = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.uc_AddProduct1 = new FMSWindows.UserControls.List_Product.Uc_AddProduct();
            ((System.ComponentModel.ISupportInitialize)(this.emptyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProductDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoverState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(745, 45);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(147, 34);
            this.siticoneButton2.TabIndex = 7;
            this.siticoneButton2.Text = "Add Product";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // emptyPicture
            // 
            this.emptyPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emptyPicture.Image = ((System.Drawing.Image)(resources.GetObject("emptyPicture.Image")));
            this.emptyPicture.ImageRotate = 0F;
            this.emptyPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("emptyPicture.InitialImage")));
            this.emptyPicture.Location = new System.Drawing.Point(274, 211);
            this.emptyPicture.Name = "emptyPicture";
            this.emptyPicture.ShadowDecoration.Parent = this.emptyPicture;
            this.emptyPicture.Size = new System.Drawing.Size(260, 278);
            this.emptyPicture.TabIndex = 10;
            this.emptyPicture.TabStop = false;
            // 
            // listProductDgw
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.listProductDgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listProductDgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listProductDgw.BackgroundColor = System.Drawing.Color.White;
            this.listProductDgw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listProductDgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listProductDgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listProductDgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listProductDgw.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listProductDgw.DefaultCellStyle = dataGridViewCellStyle3;
            this.listProductDgw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listProductDgw.EnableHeadersVisualStyles = false;
            this.listProductDgw.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listProductDgw.Location = new System.Drawing.Point(0, 90);
            this.listProductDgw.Name = "listProductDgw";
            this.listProductDgw.RowHeadersVisible = false;
            this.listProductDgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listProductDgw.Size = new System.Drawing.Size(1050, 560);
            this.listProductDgw.TabIndex = 12;
            this.listProductDgw.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.listProductDgw.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listProductDgw.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.listProductDgw.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listProductDgw.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listProductDgw.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.listProductDgw.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listProductDgw.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red;
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
            // uc_AddProduct1
            // 
            this.uc_AddProduct1.Location = new System.Drawing.Point(0, 75);
            this.uc_AddProduct1.Name = "uc_AddProduct1";
            this.uc_AddProduct1.Size = new System.Drawing.Size(850, 555);
            this.uc_AddProduct1.TabIndex = 11;
            // 
            // Uc_ListProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listProductDgw);
            this.Controls.Add(this.emptyPicture);
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.uc_AddProduct1);
            this.Name = "Uc_ListProduct";
            this.Size = new System.Drawing.Size(1050, 650);
            this.Load += new System.EventHandler(this.Uc_ListProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emptyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProductDgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox emptyPicture;
        private Uc_AddProduct uc_AddProduct1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView listProductDgw;
    }
}
