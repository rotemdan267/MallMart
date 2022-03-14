namespace MallMartUI
{
    partial class RegisterUC
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
            this.registerBtn = new System.Windows.Forms.Button();
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
            this.apartNoLbl = new System.Windows.Forms.Label();
            this.apartNoTxtbx = new System.Windows.Forms.TextBox();
            this.entranceLbl = new System.Windows.Forms.Label();
            this.entranceTxtbx = new System.Windows.Forms.TextBox();
            this.cityLbl = new System.Windows.Forms.Label();
            this.cityTxtbx = new System.Windows.Forms.TextBox();
            this.streetLbl = new System.Windows.Forms.Label();
            this.streetTxtbx = new System.Windows.Forms.TextBox();
            this.regionLbl = new System.Windows.Forms.Label();
            this.streetNoLbl = new System.Windows.Forms.Label();
            this.streetNumTxtbx = new System.Windows.Forms.TextBox();
            this.postalLbl = new System.Windows.Forms.Label();
            this.payMethodLbl = new System.Windows.Forms.Label();
            this.payDetailsLbl = new System.Windows.Forms.Label();
            this.payDetailsTxtbx = new System.Windows.Forms.TextBox();
            this.postalTxtbx = new System.Windows.Forms.TextBox();
            this.regionCombx = new System.Windows.Forms.ComboBox();
            this.payMethCombx = new System.Windows.Forms.ComboBox();
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
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.registerBtn.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.registerBtn.FlatAppearance.BorderSize = 2;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerBtn.ForeColor = System.Drawing.Color.DimGray;
            this.registerBtn.Location = new System.Drawing.Point(545, 444);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(120, 39);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
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
            // apartNoLbl
            // 
            this.apartNoLbl.AutoSize = true;
            this.apartNoLbl.BackColor = System.Drawing.Color.Transparent;
            this.apartNoLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apartNoLbl.ForeColor = System.Drawing.Color.DimGray;
            this.apartNoLbl.Location = new System.Drawing.Point(794, 238);
            this.apartNoLbl.Name = "apartNoLbl";
            this.apartNoLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.apartNoLbl.Size = new System.Drawing.Size(149, 18);
            this.apartNoLbl.TabIndex = 2;
            this.apartNoLbl.Text = "Apartment Number:";
            this.apartNoLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // apartNoTxtbx
            // 
            this.apartNoTxtbx.BackColor = System.Drawing.Color.LightCyan;
            this.apartNoTxtbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apartNoTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.apartNoTxtbx.Location = new System.Drawing.Point(794, 278);
            this.apartNoTxtbx.Name = "apartNoTxtbx";
            this.apartNoTxtbx.PlaceholderText = "   (Optional)";
            this.apartNoTxtbx.Size = new System.Drawing.Size(173, 26);
            this.apartNoTxtbx.TabIndex = 3;
            this.apartNoTxtbx.Leave += new System.EventHandler(this.apartNoTxtbx_Leave);
            // 
            // entranceLbl
            // 
            this.entranceLbl.AutoSize = true;
            this.entranceLbl.BackColor = System.Drawing.Color.Transparent;
            this.entranceLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entranceLbl.ForeColor = System.Drawing.Color.DimGray;
            this.entranceLbl.Location = new System.Drawing.Point(652, 238);
            this.entranceLbl.Name = "entranceLbl";
            this.entranceLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.entranceLbl.Size = new System.Drawing.Size(80, 18);
            this.entranceLbl.TabIndex = 2;
            this.entranceLbl.Text = "Entrance:";
            this.entranceLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // entranceTxtbx
            // 
            this.entranceTxtbx.BackColor = System.Drawing.Color.LightCyan;
            this.entranceTxtbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entranceTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.entranceTxtbx.Location = new System.Drawing.Point(652, 277);
            this.entranceTxtbx.Name = "entranceTxtbx";
            this.entranceTxtbx.PlaceholderText = "   (Optional)";
            this.entranceTxtbx.Size = new System.Drawing.Size(106, 26);
            this.entranceTxtbx.TabIndex = 3;
            this.entranceTxtbx.Leave += new System.EventHandler(this.entranceTxtbx_Leave);
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.BackColor = System.Drawing.Color.Transparent;
            this.cityLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLbl.ForeColor = System.Drawing.Color.DimGray;
            this.cityLbl.Location = new System.Drawing.Point(922, 57);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cityLbl.Size = new System.Drawing.Size(45, 18);
            this.cityLbl.TabIndex = 2;
            this.cityLbl.Text = "City:";
            this.cityLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cityTxtbx
            // 
            this.cityTxtbx.BackColor = System.Drawing.Color.LightCyan;
            this.cityTxtbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.cityTxtbx.Location = new System.Drawing.Point(906, 96);
            this.cityTxtbx.Name = "cityTxtbx";
            this.cityTxtbx.Size = new System.Drawing.Size(173, 26);
            this.cityTxtbx.TabIndex = 3;
            this.cityTxtbx.Leave += new System.EventHandler(this.cityTxtbx_Leave);
            // 
            // streetLbl
            // 
            this.streetLbl.AutoSize = true;
            this.streetLbl.BackColor = System.Drawing.Color.Transparent;
            this.streetLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.streetLbl.ForeColor = System.Drawing.Color.DimGray;
            this.streetLbl.Location = new System.Drawing.Point(652, 168);
            this.streetLbl.Name = "streetLbl";
            this.streetLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.streetLbl.Size = new System.Drawing.Size(60, 18);
            this.streetLbl.TabIndex = 2;
            this.streetLbl.Text = "Street:";
            this.streetLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // streetTxtbx
            // 
            this.streetTxtbx.BackColor = System.Drawing.Color.LightCyan;
            this.streetTxtbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.streetTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.streetTxtbx.Location = new System.Drawing.Point(651, 209);
            this.streetTxtbx.Name = "streetTxtbx";
            this.streetTxtbx.Size = new System.Drawing.Size(173, 26);
            this.streetTxtbx.TabIndex = 3;
            this.streetTxtbx.Leave += new System.EventHandler(this.streetTxtbx_Leave);
            // 
            // regionLbl
            // 
            this.regionLbl.AutoSize = true;
            this.regionLbl.BackColor = System.Drawing.Color.Transparent;
            this.regionLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regionLbl.ForeColor = System.Drawing.Color.DimGray;
            this.regionLbl.Location = new System.Drawing.Point(651, 57);
            this.regionLbl.Name = "regionLbl";
            this.regionLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.regionLbl.Size = new System.Drawing.Size(68, 18);
            this.regionLbl.TabIndex = 2;
            this.regionLbl.Text = "Region:";
            this.regionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // streetNoLbl
            // 
            this.streetNoLbl.AutoSize = true;
            this.streetNoLbl.BackColor = System.Drawing.Color.Transparent;
            this.streetNoLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.streetNoLbl.ForeColor = System.Drawing.Color.DimGray;
            this.streetNoLbl.Location = new System.Drawing.Point(906, 168);
            this.streetNoLbl.Name = "streetNoLbl";
            this.streetNoLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.streetNoLbl.Size = new System.Drawing.Size(73, 18);
            this.streetNoLbl.TabIndex = 2;
            this.streetNoLbl.Text = "Number:";
            this.streetNoLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // streetNumTxtbx
            // 
            this.streetNumTxtbx.BackColor = System.Drawing.Color.LightCyan;
            this.streetNumTxtbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.streetNumTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.streetNumTxtbx.Location = new System.Drawing.Point(906, 196);
            this.streetNumTxtbx.Name = "streetNumTxtbx";
            this.streetNumTxtbx.Size = new System.Drawing.Size(173, 26);
            this.streetNumTxtbx.TabIndex = 3;
            this.streetNumTxtbx.Leave += new System.EventHandler(this.streetNumTxtbx_Leave);
            // 
            // postalLbl
            // 
            this.postalLbl.AutoSize = true;
            this.postalLbl.BackColor = System.Drawing.Color.Transparent;
            this.postalLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postalLbl.ForeColor = System.Drawing.Color.DimGray;
            this.postalLbl.Location = new System.Drawing.Point(1017, 238);
            this.postalLbl.Name = "postalLbl";
            this.postalLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.postalLbl.Size = new System.Drawing.Size(62, 18);
            this.postalLbl.TabIndex = 2;
            this.postalLbl.Text = "Postal:";
            this.postalLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // payMethodLbl
            // 
            this.payMethodLbl.AutoSize = true;
            this.payMethodLbl.BackColor = System.Drawing.Color.Transparent;
            this.payMethodLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payMethodLbl.ForeColor = System.Drawing.Color.DimGray;
            this.payMethodLbl.Location = new System.Drawing.Point(50, 444);
            this.payMethodLbl.Name = "payMethodLbl";
            this.payMethodLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.payMethodLbl.Size = new System.Drawing.Size(135, 18);
            this.payMethodLbl.TabIndex = 2;
            this.payMethodLbl.Text = "Payment Method:";
            this.payMethodLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // payDetailsLbl
            // 
            this.payDetailsLbl.AutoSize = true;
            this.payDetailsLbl.BackColor = System.Drawing.Color.Transparent;
            this.payDetailsLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payDetailsLbl.ForeColor = System.Drawing.Color.DimGray;
            this.payDetailsLbl.Location = new System.Drawing.Point(284, 444);
            this.payDetailsLbl.Name = "payDetailsLbl";
            this.payDetailsLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.payDetailsLbl.Size = new System.Drawing.Size(132, 18);
            this.payDetailsLbl.TabIndex = 2;
            this.payDetailsLbl.Text = "Payment Details:";
            this.payDetailsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // payDetailsTxtbx
            // 
            this.payDetailsTxtbx.BackColor = System.Drawing.Color.LightCyan;
            this.payDetailsTxtbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payDetailsTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.payDetailsTxtbx.Location = new System.Drawing.Point(301, 465);
            this.payDetailsTxtbx.Name = "payDetailsTxtbx";
            this.payDetailsTxtbx.Size = new System.Drawing.Size(173, 26);
            this.payDetailsTxtbx.TabIndex = 3;
            this.payDetailsTxtbx.Leave += new System.EventHandler(this.payDetailsTxtbx_Leave);
            // 
            // postalTxtbx
            // 
            this.postalTxtbx.BackColor = System.Drawing.Color.LightCyan;
            this.postalTxtbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postalTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.postalTxtbx.Location = new System.Drawing.Point(992, 278);
            this.postalTxtbx.Name = "postalTxtbx";
            this.postalTxtbx.PlaceholderText = "   (Optional)";
            this.postalTxtbx.Size = new System.Drawing.Size(173, 26);
            this.postalTxtbx.TabIndex = 3;
            this.postalTxtbx.Leave += new System.EventHandler(this.postalTxtbx_Leave);
            // 
            // regionCombx
            // 
            this.regionCombx.BackColor = System.Drawing.Color.LightCyan;
            this.regionCombx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regionCombx.ForeColor = System.Drawing.Color.DimGray;
            this.regionCombx.FormattingEnabled = true;
            this.regionCombx.Location = new System.Drawing.Point(651, 96);
            this.regionCombx.Name = "regionCombx";
            this.regionCombx.Size = new System.Drawing.Size(200, 26);
            this.regionCombx.TabIndex = 12;
            // 
            // payMethCombx
            // 
            this.payMethCombx.BackColor = System.Drawing.Color.LightCyan;
            this.payMethCombx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payMethCombx.ForeColor = System.Drawing.Color.DimGray;
            this.payMethCombx.FormattingEnabled = true;
            this.payMethCombx.Location = new System.Drawing.Point(50, 482);
            this.payMethCombx.Name = "payMethCombx";
            this.payMethCombx.Size = new System.Drawing.Size(200, 26);
            this.payMethCombx.TabIndex = 12;
            // 
            // RegisterUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.payMethCombx);
            this.Controls.Add(this.regionCombx);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.payDetailsTxtbx);
            this.Controls.Add(this.postalTxtbx);
            this.Controls.Add(this.streetNumTxtbx);
            this.Controls.Add(this.streetTxtbx);
            this.Controls.Add(this.cityTxtbx);
            this.Controls.Add(this.entranceTxtbx);
            this.Controls.Add(this.payDetailsLbl);
            this.Controls.Add(this.payMethodLbl);
            this.Controls.Add(this.apartNoTxtbx);
            this.Controls.Add(this.postalLbl);
            this.Controls.Add(this.streetNoLbl);
            this.Controls.Add(this.phoneTxtbx);
            this.Controls.Add(this.regionLbl);
            this.Controls.Add(this.streetLbl);
            this.Controls.Add(this.emailTxtbx);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.entranceLbl);
            this.Controls.Add(this.lNameTxtbx);
            this.Controls.Add(this.apartNoLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.fNameTxtbx);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.passwordTxtbx);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.usernameTxtbx);
            this.Name = "RegisterUC";
            this.Size = new System.Drawing.Size(1280, 540);
            this.Load += new System.EventHandler(this.RegisterUC_Load);
            this.Resize += new System.EventHandler(this.RegisterUC_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox usernameTxtbx;
        private Button registerBtn;
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
        private Label apartNoLbl;
        private TextBox apartNoTxtbx;
        private Label entranceLbl;
        private TextBox entranceTxtbx;
        private Label cityLbl;
        private TextBox cityTxtbx;
        private Label streetLbl;
        private TextBox streetTxtbx;
        private Label regionLbl;
        private Label streetNoLbl;
        private TextBox streetNumTxtbx;
        private Label postalLbl;
        private Label payMethodLbl;
        private Label payDetailsLbl;
        private TextBox payDetailsTxtbx;
        private TextBox postalTxtbx;
        private ComboBox regionCombx;
        private ComboBox payMethCombx;
    }
}
