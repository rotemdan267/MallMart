namespace MallMartUI
{
    partial class OrderDetailsUC
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
            this.orderDeliveredBtn = new System.Windows.Forms.Button();
            this.backLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.phoneDetailsBtn = new System.Windows.Forms.Label();
            this.emailDetailsBtn = new System.Windows.Forms.Label();
            this.lNameDetailsBtn = new System.Windows.Forms.Label();
            this.fNameDetailsBtn = new System.Windows.Forms.Label();
            this.postalLbl = new System.Windows.Forms.Label();
            this.streetNoLbl = new System.Windows.Forms.Label();
            this.regionLbl = new System.Windows.Forms.Label();
            this.streetLbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.entranceLbl = new System.Windows.Forms.Label();
            this.apartNoLbl = new System.Windows.Forms.Label();
            this.postalDetailsBtn = new System.Windows.Forms.Label();
            this.apartNoDetailsBtn = new System.Windows.Forms.Label();
            this.entraDetailsBtn = new System.Windows.Forms.Label();
            this.streetNoDetailsBtn = new System.Windows.Forms.Label();
            this.streetDetailsBtn = new System.Windows.Forms.Label();
            this.cityDetailsBtn = new System.Windows.Forms.Label();
            this.regionDetailsBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDeliveredBtn
            // 
            this.orderDeliveredBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.orderDeliveredBtn.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.orderDeliveredBtn.FlatAppearance.BorderSize = 2;
            this.orderDeliveredBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderDeliveredBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderDeliveredBtn.ForeColor = System.Drawing.Color.DimGray;
            this.orderDeliveredBtn.Location = new System.Drawing.Point(124, 405);
            this.orderDeliveredBtn.Name = "orderDeliveredBtn";
            this.orderDeliveredBtn.Size = new System.Drawing.Size(154, 39);
            this.orderDeliveredBtn.TabIndex = 4;
            this.orderDeliveredBtn.Text = "Order Delivered!";
            this.orderDeliveredBtn.UseVisualStyleBackColor = false;
            this.orderDeliveredBtn.Click += new System.EventHandler(this.orderDeliveredBtn_Click);
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
            // dataGridView1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Coral;
            this.dataGridView1.Location = new System.Drawing.Point(320, 200);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.RowTemplate.Height = 75;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(817, 265);
            this.dataGridView1.TabIndex = 16;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.BackColor = System.Drawing.Color.Transparent;
            this.phoneLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneLbl.ForeColor = System.Drawing.Color.DimGray;
            this.phoneLbl.Location = new System.Drawing.Point(104, 311);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.phoneLbl.Size = new System.Drawing.Size(63, 18);
            this.phoneLbl.TabIndex = 17;
            this.phoneLbl.Text = "Phone:";
            this.phoneLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.BackColor = System.Drawing.Color.Transparent;
            this.emailLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLbl.ForeColor = System.Drawing.Color.DimGray;
            this.emailLbl.Location = new System.Drawing.Point(104, 248);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.emailLbl.Size = new System.Drawing.Size(58, 18);
            this.emailLbl.TabIndex = 18;
            this.emailLbl.Text = "Email:";
            this.emailLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLbl.ForeColor = System.Drawing.Color.DimGray;
            this.lastNameLbl.Location = new System.Drawing.Point(89, 177);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lastNameLbl.Size = new System.Drawing.Size(94, 18);
            this.lastNameLbl.TabIndex = 19;
            this.lastNameLbl.Text = "Last Name:";
            this.lastNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLbl.ForeColor = System.Drawing.Color.DimGray;
            this.firstNameLbl.Location = new System.Drawing.Point(88, 99);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.firstNameLbl.Size = new System.Drawing.Size(95, 18);
            this.firstNameLbl.TabIndex = 20;
            this.firstNameLbl.Text = "First Name:";
            this.firstNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // phoneDetailsBtn
            // 
            this.phoneDetailsBtn.AutoSize = true;
            this.phoneDetailsBtn.BackColor = System.Drawing.Color.Transparent;
            this.phoneDetailsBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneDetailsBtn.ForeColor = System.Drawing.Color.DimGray;
            this.phoneDetailsBtn.Location = new System.Drawing.Point(88, 338);
            this.phoneDetailsBtn.Name = "phoneDetailsBtn";
            this.phoneDetailsBtn.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.phoneDetailsBtn.Size = new System.Drawing.Size(129, 22);
            this.phoneDetailsBtn.TabIndex = 21;
            this.phoneDetailsBtn.Text = "phone details";
            this.phoneDetailsBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emailDetailsBtn
            // 
            this.emailDetailsBtn.AutoSize = true;
            this.emailDetailsBtn.BackColor = System.Drawing.Color.Transparent;
            this.emailDetailsBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailDetailsBtn.ForeColor = System.Drawing.Color.DimGray;
            this.emailDetailsBtn.Location = new System.Drawing.Point(88, 266);
            this.emailDetailsBtn.Name = "emailDetailsBtn";
            this.emailDetailsBtn.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.emailDetailsBtn.Size = new System.Drawing.Size(121, 22);
            this.emailDetailsBtn.TabIndex = 22;
            this.emailDetailsBtn.Text = "email details";
            this.emailDetailsBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lNameDetailsBtn
            // 
            this.lNameDetailsBtn.AutoSize = true;
            this.lNameDetailsBtn.BackColor = System.Drawing.Color.Transparent;
            this.lNameDetailsBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lNameDetailsBtn.ForeColor = System.Drawing.Color.DimGray;
            this.lNameDetailsBtn.Location = new System.Drawing.Point(89, 211);
            this.lNameDetailsBtn.Name = "lNameDetailsBtn";
            this.lNameDetailsBtn.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lNameDetailsBtn.Size = new System.Drawing.Size(157, 22);
            this.lNameDetailsBtn.TabIndex = 23;
            this.lNameDetailsBtn.Text = "last name details";
            this.lNameDetailsBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fNameDetailsBtn
            // 
            this.fNameDetailsBtn.AutoSize = true;
            this.fNameDetailsBtn.BackColor = System.Drawing.Color.Transparent;
            this.fNameDetailsBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fNameDetailsBtn.ForeColor = System.Drawing.Color.DimGray;
            this.fNameDetailsBtn.Location = new System.Drawing.Point(88, 135);
            this.fNameDetailsBtn.Name = "fNameDetailsBtn";
            this.fNameDetailsBtn.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.fNameDetailsBtn.Size = new System.Drawing.Size(159, 22);
            this.fNameDetailsBtn.TabIndex = 24;
            this.fNameDetailsBtn.Text = "first name details";
            this.fNameDetailsBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // postalLbl
            // 
            this.postalLbl.AutoSize = true;
            this.postalLbl.BackColor = System.Drawing.Color.Transparent;
            this.postalLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postalLbl.ForeColor = System.Drawing.Color.DimGray;
            this.postalLbl.Location = new System.Drawing.Point(914, 237);
            this.postalLbl.Name = "postalLbl";
            this.postalLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.postalLbl.Size = new System.Drawing.Size(62, 18);
            this.postalLbl.TabIndex = 25;
            this.postalLbl.Text = "Postal:";
            this.postalLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // streetNoLbl
            // 
            this.streetNoLbl.AutoSize = true;
            this.streetNoLbl.BackColor = System.Drawing.Color.Transparent;
            this.streetNoLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.streetNoLbl.ForeColor = System.Drawing.Color.DimGray;
            this.streetNoLbl.Location = new System.Drawing.Point(803, 167);
            this.streetNoLbl.Name = "streetNoLbl";
            this.streetNoLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.streetNoLbl.Size = new System.Drawing.Size(73, 18);
            this.streetNoLbl.TabIndex = 26;
            this.streetNoLbl.Text = "Number:";
            this.streetNoLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // regionLbl
            // 
            this.regionLbl.AutoSize = true;
            this.regionLbl.BackColor = System.Drawing.Color.Transparent;
            this.regionLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regionLbl.ForeColor = System.Drawing.Color.DimGray;
            this.regionLbl.Location = new System.Drawing.Point(548, 56);
            this.regionLbl.Name = "regionLbl";
            this.regionLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.regionLbl.Size = new System.Drawing.Size(68, 18);
            this.regionLbl.TabIndex = 27;
            this.regionLbl.Text = "Region:";
            this.regionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // streetLbl
            // 
            this.streetLbl.AutoSize = true;
            this.streetLbl.BackColor = System.Drawing.Color.Transparent;
            this.streetLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.streetLbl.ForeColor = System.Drawing.Color.DimGray;
            this.streetLbl.Location = new System.Drawing.Point(549, 167);
            this.streetLbl.Name = "streetLbl";
            this.streetLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.streetLbl.Size = new System.Drawing.Size(60, 18);
            this.streetLbl.TabIndex = 28;
            this.streetLbl.Text = "Street:";
            this.streetLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.BackColor = System.Drawing.Color.Transparent;
            this.cityLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLbl.ForeColor = System.Drawing.Color.DimGray;
            this.cityLbl.Location = new System.Drawing.Point(819, 56);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cityLbl.Size = new System.Drawing.Size(45, 18);
            this.cityLbl.TabIndex = 29;
            this.cityLbl.Text = "City:";
            this.cityLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // entranceLbl
            // 
            this.entranceLbl.AutoSize = true;
            this.entranceLbl.BackColor = System.Drawing.Color.Transparent;
            this.entranceLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entranceLbl.ForeColor = System.Drawing.Color.DimGray;
            this.entranceLbl.Location = new System.Drawing.Point(549, 237);
            this.entranceLbl.Name = "entranceLbl";
            this.entranceLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.entranceLbl.Size = new System.Drawing.Size(80, 18);
            this.entranceLbl.TabIndex = 30;
            this.entranceLbl.Text = "Entrance:";
            this.entranceLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // apartNoLbl
            // 
            this.apartNoLbl.AutoSize = true;
            this.apartNoLbl.BackColor = System.Drawing.Color.Transparent;
            this.apartNoLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apartNoLbl.ForeColor = System.Drawing.Color.DimGray;
            this.apartNoLbl.Location = new System.Drawing.Point(691, 237);
            this.apartNoLbl.Name = "apartNoLbl";
            this.apartNoLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.apartNoLbl.Size = new System.Drawing.Size(149, 18);
            this.apartNoLbl.TabIndex = 31;
            this.apartNoLbl.Text = "Apartment Number:";
            this.apartNoLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // postalDetailsBtn
            // 
            this.postalDetailsBtn.AutoSize = true;
            this.postalDetailsBtn.BackColor = System.Drawing.Color.Transparent;
            this.postalDetailsBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postalDetailsBtn.ForeColor = System.Drawing.Color.DimGray;
            this.postalDetailsBtn.Location = new System.Drawing.Point(890, 275);
            this.postalDetailsBtn.Name = "postalDetailsBtn";
            this.postalDetailsBtn.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.postalDetailsBtn.Size = new System.Drawing.Size(127, 22);
            this.postalDetailsBtn.TabIndex = 32;
            this.postalDetailsBtn.Text = "postal details";
            this.postalDetailsBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // apartNoDetailsBtn
            // 
            this.apartNoDetailsBtn.AutoSize = true;
            this.apartNoDetailsBtn.BackColor = System.Drawing.Color.Transparent;
            this.apartNoDetailsBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apartNoDetailsBtn.ForeColor = System.Drawing.Color.DimGray;
            this.apartNoDetailsBtn.Location = new System.Drawing.Point(701, 275);
            this.apartNoDetailsBtn.Name = "apartNoDetailsBtn";
            this.apartNoDetailsBtn.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.apartNoDetailsBtn.Size = new System.Drawing.Size(144, 22);
            this.apartNoDetailsBtn.TabIndex = 33;
            this.apartNoDetailsBtn.Text = "apart no details";
            this.apartNoDetailsBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // entraDetailsBtn
            // 
            this.entraDetailsBtn.AutoSize = true;
            this.entraDetailsBtn.BackColor = System.Drawing.Color.Transparent;
            this.entraDetailsBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entraDetailsBtn.ForeColor = System.Drawing.Color.DimGray;
            this.entraDetailsBtn.Location = new System.Drawing.Point(499, 275);
            this.entraDetailsBtn.Name = "entraDetailsBtn";
            this.entraDetailsBtn.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.entraDetailsBtn.Size = new System.Drawing.Size(149, 22);
            this.entraDetailsBtn.TabIndex = 34;
            this.entraDetailsBtn.Text = "entrance details";
            this.entraDetailsBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // streetNoDetailsBtn
            // 
            this.streetNoDetailsBtn.AutoSize = true;
            this.streetNoDetailsBtn.BackColor = System.Drawing.Color.Transparent;
            this.streetNoDetailsBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.streetNoDetailsBtn.ForeColor = System.Drawing.Color.DimGray;
            this.streetNoDetailsBtn.Location = new System.Drawing.Point(764, 200);
            this.streetNoDetailsBtn.Name = "streetNoDetailsBtn";
            this.streetNoDetailsBtn.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.streetNoDetailsBtn.Size = new System.Drawing.Size(150, 22);
            this.streetNoDetailsBtn.TabIndex = 35;
            this.streetNoDetailsBtn.Text = "street no details";
            this.streetNoDetailsBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // streetDetailsBtn
            // 
            this.streetDetailsBtn.AutoSize = true;
            this.streetDetailsBtn.BackColor = System.Drawing.Color.Transparent;
            this.streetDetailsBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.streetDetailsBtn.ForeColor = System.Drawing.Color.DimGray;
            this.streetDetailsBtn.Location = new System.Drawing.Point(499, 200);
            this.streetDetailsBtn.Name = "streetDetailsBtn";
            this.streetDetailsBtn.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.streetDetailsBtn.Size = new System.Drawing.Size(124, 22);
            this.streetDetailsBtn.TabIndex = 36;
            this.streetDetailsBtn.Text = "street details";
            this.streetDetailsBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cityDetailsBtn
            // 
            this.cityDetailsBtn.AutoSize = true;
            this.cityDetailsBtn.BackColor = System.Drawing.Color.Transparent;
            this.cityDetailsBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityDetailsBtn.ForeColor = System.Drawing.Color.DimGray;
            this.cityDetailsBtn.Location = new System.Drawing.Point(764, 99);
            this.cityDetailsBtn.Name = "cityDetailsBtn";
            this.cityDetailsBtn.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cityDetailsBtn.Size = new System.Drawing.Size(104, 22);
            this.cityDetailsBtn.TabIndex = 37;
            this.cityDetailsBtn.Text = "city details";
            this.cityDetailsBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // regionDetailsBtn
            // 
            this.regionDetailsBtn.AutoSize = true;
            this.regionDetailsBtn.BackColor = System.Drawing.Color.Transparent;
            this.regionDetailsBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regionDetailsBtn.ForeColor = System.Drawing.Color.DimGray;
            this.regionDetailsBtn.Location = new System.Drawing.Point(508, 99);
            this.regionDetailsBtn.Name = "regionDetailsBtn";
            this.regionDetailsBtn.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.regionDetailsBtn.Size = new System.Drawing.Size(129, 22);
            this.regionDetailsBtn.TabIndex = 38;
            this.regionDetailsBtn.Text = "region details";
            this.regionDetailsBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OrderDetailsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.postalLbl);
            this.Controls.Add(this.streetNoLbl);
            this.Controls.Add(this.regionLbl);
            this.Controls.Add(this.streetLbl);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.entranceLbl);
            this.Controls.Add(this.apartNoLbl);
            this.Controls.Add(this.postalDetailsBtn);
            this.Controls.Add(this.apartNoDetailsBtn);
            this.Controls.Add(this.entraDetailsBtn);
            this.Controls.Add(this.streetNoDetailsBtn);
            this.Controls.Add(this.streetDetailsBtn);
            this.Controls.Add(this.cityDetailsBtn);
            this.Controls.Add(this.regionDetailsBtn);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.phoneDetailsBtn);
            this.Controls.Add(this.emailDetailsBtn);
            this.Controls.Add(this.lNameDetailsBtn);
            this.Controls.Add(this.fNameDetailsBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.orderDeliveredBtn);
            this.Name = "OrderDetailsUC";
            this.Size = new System.Drawing.Size(1280, 540);
            this.Load += new System.EventHandler(this.OrderDetailsUC_Load);
            this.Resize += new System.EventHandler(this.OrderDetailsUC_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button orderDeliveredBtn;
        private Label backLbl;
        private DataGridView dataGridView1;
        private Label phoneLbl;
        private Label emailLbl;
        private Label lastNameLbl;
        private Label firstNameLbl;
        private Label phoneDetailsBtn;
        private Label emailDetailsBtn;
        private Label lNameDetailsBtn;
        private Label fNameDetailsBtn;
        private Label postalLbl;
        private Label streetNoLbl;
        private Label regionLbl;
        private Label streetLbl;
        private Label cityLbl;
        private Label entranceLbl;
        private Label apartNoLbl;
        private Label postalDetailsBtn;
        private Label apartNoDetailsBtn;
        private Label entraDetailsBtn;
        private Label streetNoDetailsBtn;
        private Label streetDetailsBtn;
        private Label cityDetailsBtn;
        private Label regionDetailsBtn;
    }
}
