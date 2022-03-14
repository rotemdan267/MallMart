namespace MallMartUI
{
    partial class NewCategoryUC
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
            this.backLbl = new System.Windows.Forms.Label();
            this.saveCtgryBtn = new System.Windows.Forms.Button();
            this.nameDetailsTxtbx = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.BackColor = System.Drawing.Color.Transparent;
            this.backLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.backLbl.ForeColor = System.Drawing.Color.DimGray;
            this.backLbl.Location = new System.Drawing.Point(387, 51);
            this.backLbl.Name = "backLbl";
            this.backLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.backLbl.Size = new System.Drawing.Size(50, 18);
            this.backLbl.TabIndex = 19;
            this.backLbl.Text = "Back";
            this.backLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // saveCtgryBtn
            // 
            this.saveCtgryBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.saveCtgryBtn.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.saveCtgryBtn.FlatAppearance.BorderSize = 2;
            this.saveCtgryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveCtgryBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveCtgryBtn.ForeColor = System.Drawing.Color.DimGray;
            this.saveCtgryBtn.Location = new System.Drawing.Point(756, 450);
            this.saveCtgryBtn.Name = "saveCtgryBtn";
            this.saveCtgryBtn.Size = new System.Drawing.Size(137, 39);
            this.saveCtgryBtn.TabIndex = 18;
            this.saveCtgryBtn.Text = "Save Category";
            this.saveCtgryBtn.UseVisualStyleBackColor = false;
            this.saveCtgryBtn.Click += new System.EventHandler(this.saveCtgryBtn_Click);
            // 
            // nameDetailsTxtbx
            // 
            this.nameDetailsTxtbx.BackColor = System.Drawing.Color.LightCyan;
            this.nameDetailsTxtbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameDetailsTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.nameDetailsTxtbx.Location = new System.Drawing.Point(555, 111);
            this.nameDetailsTxtbx.Name = "nameDetailsTxtbx";
            this.nameDetailsTxtbx.Size = new System.Drawing.Size(96, 26);
            this.nameDetailsTxtbx.TabIndex = 17;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.ForeColor = System.Drawing.Color.DimGray;
            this.nameLbl.Location = new System.Drawing.Point(574, 83);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.nameLbl.Size = new System.Drawing.Size(60, 18);
            this.nameLbl.TabIndex = 16;
            this.nameLbl.Text = "Name:";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NewCategoryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.saveCtgryBtn);
            this.Controls.Add(this.nameDetailsTxtbx);
            this.Controls.Add(this.nameLbl);
            this.Name = "NewCategoryUC";
            this.Size = new System.Drawing.Size(1280, 540);
            this.Load += new System.EventHandler(this.NewCategoryUC_Load);
            this.Resize += new System.EventHandler(this.NewCategoryUC_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label backLbl;
        private Button saveCtgryBtn;
        private TextBox nameDetailsTxtbx;
        private Label nameLbl;
    }
}
