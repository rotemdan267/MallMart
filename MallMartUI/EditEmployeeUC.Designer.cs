namespace MallMartUI
{
    partial class EditEmployeeUC
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
            this.usernameTxtbx = new System.Windows.Forms.TextBox();
            this.saveEmpBtn = new System.Windows.Forms.Button();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordTxtbx = new System.Windows.Forms.TextBox();
            this.passLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.fNameTxtbx = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.lNameTxtbx = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailTxtbx = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.phoneTxtbx = new System.Windows.Forms.TextBox();
            this.jobTitleCombx = new System.Windows.Forms.ComboBox();
            this.jobTitleLbl = new System.Windows.Forms.Label();
            this.managerLbl = new System.Windows.Forms.Label();
            this.managerCombox = new System.Windows.Forms.ComboBox();
            this.regionsCheckedlist = new System.Windows.Forms.CheckedListBox();
            this.regionsLbl = new System.Windows.Forms.Label();
            this.backLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTxtbx
            // 
            this.usernameTxtbx.BackColor = System.Drawing.Color.LightCyan;
            this.usernameTxtbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.usernameTxtbx.Location = new System.Drawing.Point(95, 78);
            this.usernameTxtbx.Name = "usernameTxtbx";
            this.usernameTxtbx.Size = new System.Drawing.Size(173, 26);
            this.usernameTxtbx.TabIndex = 3;
            this.usernameTxtbx.Leave += new System.EventHandler(this.usernameTxtbx_Leave);
            // 
            // saveEmpBtn
            // 
            this.saveEmpBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.saveEmpBtn.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.saveEmpBtn.FlatAppearance.BorderSize = 2;
            this.saveEmpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEmpBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveEmpBtn.ForeColor = System.Drawing.Color.DimGray;
            this.saveEmpBtn.Location = new System.Drawing.Point(601, 441);
            this.saveEmpBtn.Name = "saveEmpBtn";
            this.saveEmpBtn.Size = new System.Drawing.Size(151, 39);
            this.saveEmpBtn.TabIndex = 4;
            this.saveEmpBtn.Text = "Save Employee";
            this.saveEmpBtn.UseVisualStyleBackColor = false;
            this.saveEmpBtn.Click += new System.EventHandler(this.saveEmpBtn_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLbl.ForeColor = System.Drawing.Color.DimGray;
            this.usernameLbl.Location = new System.Drawing.Point(95, 45);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.usernameLbl.Size = new System.Drawing.Size(90, 18);
            this.usernameLbl.TabIndex = 2;
            this.usernameLbl.Text = "Username:";
            this.usernameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passwordTxtbx
            // 
            this.passwordTxtbx.BackColor = System.Drawing.Color.LightCyan;
            this.passwordTxtbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.passwordTxtbx.Location = new System.Drawing.Point(126, 168);
            this.passwordTxtbx.Name = "passwordTxtbx";
            this.passwordTxtbx.Size = new System.Drawing.Size(173, 26);
            this.passwordTxtbx.TabIndex = 3;
            this.passwordTxtbx.Leave += new System.EventHandler(this.passwordTxtbx_Leave);
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.BackColor = System.Drawing.Color.Transparent;
            this.passLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passLbl.ForeColor = System.Drawing.Color.DimGray;
            this.passLbl.Location = new System.Drawing.Point(126, 140);
            this.passLbl.Name = "passLbl";
            this.passLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.passLbl.Size = new System.Drawing.Size(88, 18);
            this.passLbl.TabIndex = 2;
            this.passLbl.Text = "Password:";
            this.passLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLbl.ForeColor = System.Drawing.Color.DimGray;
            this.firstNameLbl.Location = new System.Drawing.Point(80, 197);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.firstNameLbl.Size = new System.Drawing.Size(95, 18);
            this.firstNameLbl.TabIndex = 2;
            this.firstNameLbl.Text = "First Name:";
            this.firstNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fNameTxtbx
            // 
            this.fNameTxtbx.BackColor = System.Drawing.Color.LightCyan;
            this.fNameTxtbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fNameTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.fNameTxtbx.Location = new System.Drawing.Point(90, 223);
            this.fNameTxtbx.Name = "fNameTxtbx";
            this.fNameTxtbx.Size = new System.Drawing.Size(173, 26);
            this.fNameTxtbx.TabIndex = 3;
            this.fNameTxtbx.Leave += new System.EventHandler(this.fNameTxtbx_Leave);
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLbl.ForeColor = System.Drawing.Color.DimGray;
            this.lastNameLbl.Location = new System.Drawing.Point(50, 257);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lastNameLbl.Size = new System.Drawing.Size(94, 18);
            this.lastNameLbl.TabIndex = 2;
            this.lastNameLbl.Text = "Last Name:";
            this.lastNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lNameTxtbx
            // 
            this.lNameTxtbx.BackColor = System.Drawing.Color.LightCyan;
            this.lNameTxtbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lNameTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.lNameTxtbx.Location = new System.Drawing.Point(47, 278);
            this.lNameTxtbx.Name = "lNameTxtbx";
            this.lNameTxtbx.Size = new System.Drawing.Size(173, 26);
            this.lNameTxtbx.TabIndex = 3;
            this.lNameTxtbx.Leave += new System.EventHandler(this.lNameTxtbx_Leave);
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.BackColor = System.Drawing.Color.Transparent;
            this.emailLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLbl.ForeColor = System.Drawing.Color.DimGray;
            this.emailLbl.Location = new System.Drawing.Point(50, 317);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.emailLbl.Size = new System.Drawing.Size(58, 18);
            this.emailLbl.TabIndex = 2;
            this.emailLbl.Text = "Email:";
            this.emailLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emailTxtbx
            // 
            this.emailTxtbx.BackColor = System.Drawing.Color.LightCyan;
            this.emailTxtbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.emailTxtbx.Location = new System.Drawing.Point(50, 338);
            this.emailTxtbx.Name = "emailTxtbx";
            this.emailTxtbx.Size = new System.Drawing.Size(173, 26);
            this.emailTxtbx.TabIndex = 3;
            this.emailTxtbx.Leave += new System.EventHandler(this.emailTxtbx_Leave);
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.BackColor = System.Drawing.Color.Transparent;
            this.phoneLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneLbl.ForeColor = System.Drawing.Color.DimGray;
            this.phoneLbl.Location = new System.Drawing.Point(47, 378);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.phoneLbl.Size = new System.Drawing.Size(63, 18);
            this.phoneLbl.TabIndex = 2;
            this.phoneLbl.Text = "Phone:";
            this.phoneLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // phoneTxtbx
            // 
            this.phoneTxtbx.BackColor = System.Drawing.Color.LightCyan;
            this.phoneTxtbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.phoneTxtbx.Location = new System.Drawing.Point(50, 399);
            this.phoneTxtbx.Name = "phoneTxtbx";
            this.phoneTxtbx.Size = new System.Drawing.Size(173, 26);
            this.phoneTxtbx.TabIndex = 3;
            this.phoneTxtbx.Leave += new System.EventHandler(this.phoneTxtbx_Leave);
            // 
            // jobTitleCombx
            // 
            this.jobTitleCombx.BackColor = System.Drawing.Color.LightCyan;
            this.jobTitleCombx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jobTitleCombx.ForeColor = System.Drawing.Color.DimGray;
            this.jobTitleCombx.FormattingEnabled = true;
            this.jobTitleCombx.Location = new System.Drawing.Point(756, 83);
            this.jobTitleCombx.Name = "jobTitleCombx";
            this.jobTitleCombx.Size = new System.Drawing.Size(200, 26);
            this.jobTitleCombx.TabIndex = 12;
            this.jobTitleCombx.SelectionChangeCommitted += new System.EventHandler(this.jobTitleCombx_SelectionChangeCommitted);
            // 
            // jobTitleLbl
            // 
            this.jobTitleLbl.AutoSize = true;
            this.jobTitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.jobTitleLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jobTitleLbl.ForeColor = System.Drawing.Color.DimGray;
            this.jobTitleLbl.Location = new System.Drawing.Point(756, 45);
            this.jobTitleLbl.Name = "jobTitleLbl";
            this.jobTitleLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.jobTitleLbl.Size = new System.Drawing.Size(72, 18);
            this.jobTitleLbl.TabIndex = 2;
            this.jobTitleLbl.Text = "Job title:";
            this.jobTitleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // managerLbl
            // 
            this.managerLbl.AutoSize = true;
            this.managerLbl.BackColor = System.Drawing.Color.Transparent;
            this.managerLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.managerLbl.ForeColor = System.Drawing.Color.DimGray;
            this.managerLbl.Location = new System.Drawing.Point(756, 140);
            this.managerLbl.Name = "managerLbl";
            this.managerLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.managerLbl.Size = new System.Drawing.Size(80, 18);
            this.managerLbl.TabIndex = 2;
            this.managerLbl.Text = "Manager:";
            this.managerLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // managerCombox
            // 
            this.managerCombox.BackColor = System.Drawing.Color.LightCyan;
            this.managerCombox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.managerCombox.ForeColor = System.Drawing.Color.DimGray;
            this.managerCombox.FormattingEnabled = true;
            this.managerCombox.Location = new System.Drawing.Point(756, 178);
            this.managerCombox.Name = "managerCombox";
            this.managerCombox.Size = new System.Drawing.Size(200, 26);
            this.managerCombox.TabIndex = 12;
            // 
            // regionsCheckedlist
            // 
            this.regionsCheckedlist.BackColor = System.Drawing.Color.Azure;
            this.regionsCheckedlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regionsCheckedlist.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regionsCheckedlist.ForeColor = System.Drawing.Color.DimGray;
            this.regionsCheckedlist.FormattingEnabled = true;
            this.regionsCheckedlist.Location = new System.Drawing.Point(836, 302);
            this.regionsCheckedlist.Name = "regionsCheckedlist";
            this.regionsCheckedlist.Size = new System.Drawing.Size(120, 105);
            this.regionsCheckedlist.TabIndex = 14;
            this.regionsCheckedlist.Visible = false;
            // 
            // regionsLbl
            // 
            this.regionsLbl.AutoSize = true;
            this.regionsLbl.BackColor = System.Drawing.Color.Transparent;
            this.regionsLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regionsLbl.ForeColor = System.Drawing.Color.DimGray;
            this.regionsLbl.Location = new System.Drawing.Point(756, 257);
            this.regionsLbl.Name = "regionsLbl";
            this.regionsLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.regionsLbl.Size = new System.Drawing.Size(248, 18);
            this.regionsLbl.TabIndex = 2;
            this.regionsLbl.Text = "Where can this employee deliver?";
            this.regionsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.regionsLbl.Visible = false;
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.BackColor = System.Drawing.Color.Transparent;
            this.backLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.backLbl.ForeColor = System.Drawing.Color.DimGray;
            this.backLbl.Location = new System.Drawing.Point(16, 13);
            this.backLbl.Name = "backLbl";
            this.backLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.backLbl.Size = new System.Drawing.Size(50, 18);
            this.backLbl.TabIndex = 15;
            this.backLbl.Text = "Back";
            this.backLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // EditEmployeeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.regionsCheckedlist);
            this.Controls.Add(this.managerCombox);
            this.Controls.Add(this.jobTitleCombx);
            this.Controls.Add(this.saveEmpBtn);
            this.Controls.Add(this.regionsLbl);
            this.Controls.Add(this.managerLbl);
            this.Controls.Add(this.jobTitleLbl);
            this.Controls.Add(this.phoneTxtbx);
            this.Controls.Add(this.emailTxtbx);
            this.Controls.Add(this.lNameTxtbx);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.fNameTxtbx);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.passwordTxtbx);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.usernameTxtbx);
            this.Name = "EditEmployeeUC";
            this.Size = new System.Drawing.Size(1280, 540);
            this.Load += new System.EventHandler(this.EditEmployeeUC_Load);
            this.Resize += new System.EventHandler(this.EditEmployeeUC_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox usernameTxtbx;
        private Button saveEmpBtn;
        private Label usernameLbl;
        private TextBox passwordTxtbx;
        private Label passLbl;
        private Label firstNameLbl;
        private TextBox fNameTxtbx;
        private Label lastNameLbl;
        private TextBox lNameTxtbx;
        private Label emailLbl;
        private TextBox emailTxtbx;
        private Label phoneLbl;
        private TextBox phoneTxtbx;
        private ComboBox jobTitleCombx;
        private Label jobTitleLbl;
        private Label managerLbl;
        private ComboBox managerCombox;
        private CheckedListBox regionsCheckedlist;
        private Label regionsLbl;
        private Label backLbl;
    }
}
