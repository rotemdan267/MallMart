namespace MallMartUI
{
    partial class Shop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categotyLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.editProfile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(260, 41);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label2.Size = new System.Drawing.Size(657, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hello *Customer*, there are our products. You can add a product to your cart ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Coral;
            this.dataGridView1.Location = new System.Drawing.Point(0, 121);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.RowTemplate.Height = 75;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(1280, 419);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(884, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // cartLbl
            // 
            this.cartLbl.AutoSize = true;
            this.cartLbl.BackColor = System.Drawing.Color.Transparent;
            this.cartLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.cartLbl.ForeColor = System.Drawing.Color.DimGray;
            this.cartLbl.Location = new System.Drawing.Point(1179, 9);
            this.cartLbl.Name = "cartLbl";
            this.cartLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cartLbl.Size = new System.Drawing.Size(68, 18);
            this.cartLbl.TabIndex = 5;
            this.cartLbl.Text = "My Cart";
            this.cartLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cartLbl.Click += new System.EventHandler(this.cartLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(410, 83);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sort by: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // categotyLbl
            // 
            this.categotyLbl.AutoSize = true;
            this.categotyLbl.BackColor = System.Drawing.Color.Transparent;
            this.categotyLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categotyLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categotyLbl.ForeColor = System.Drawing.Color.DimGray;
            this.categotyLbl.Location = new System.Drawing.Point(502, 86);
            this.categotyLbl.Name = "categotyLbl";
            this.categotyLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.categotyLbl.Size = new System.Drawing.Size(85, 19);
            this.categotyLbl.TabIndex = 5;
            this.categotyLbl.Text = "Category";
            this.categotyLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.categotyLbl.Click += new System.EventHandler(this.categotyLbl_Click);
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.BackColor = System.Drawing.Color.Transparent;
            this.priceLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priceLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLbl.ForeColor = System.Drawing.Color.DimGray;
            this.priceLbl.Location = new System.Drawing.Point(593, 86);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.priceLbl.Size = new System.Drawing.Size(51, 18);
            this.priceLbl.TabIndex = 5;
            this.priceLbl.Text = "Price";
            this.priceLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.priceLbl.Click += new System.EventHandler(this.priceLbl_Click);
            // 
            // editProfile
            // 
            this.editProfile.AutoSize = true;
            this.editProfile.BackColor = System.Drawing.Color.Transparent;
            this.editProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editProfile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.editProfile.ForeColor = System.Drawing.Color.DimGray;
            this.editProfile.Location = new System.Drawing.Point(13, 9);
            this.editProfile.Name = "editProfile";
            this.editProfile.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.editProfile.Size = new System.Drawing.Size(113, 18);
            this.editProfile.TabIndex = 5;
            this.editProfile.Text = "Edit my profile";
            this.editProfile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editProfile.Click += new System.EventHandler(this.editProfile_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.categotyLbl);
            this.Controls.Add(this.editProfile);
            this.Controls.Add(this.cartLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Shop";
            this.Size = new System.Drawing.Size(1280, 540);
            this.Load += new System.EventHandler(this.Shop_Load);
            this.Resize += new System.EventHandler(this.Shop_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label cartLbl;
        private Label label1;
        private Label categotyLbl;
        private Label priceLbl;
        private Label editProfile;
    }
}
