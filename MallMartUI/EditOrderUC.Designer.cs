namespace MallMartUI
{
    partial class EditOrderUC
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
            this.saveOrdBtn = new System.Windows.Forms.Button();
            this.customerLbl = new System.Windows.Forms.Label();
            this.dateOrderedLbl = new System.Windows.Forms.Label();
            this.firstTimeLbl = new System.Windows.Forms.Label();
            this.lastTimeAskedLbl = new System.Windows.Forms.Label();
            this.arrivalTimeLbl = new System.Windows.Forms.Label();
            this.totalPriceLbl = new System.Windows.Forms.Label();
            this.totalPriceDetailsTxtbx = new System.Windows.Forms.TextBox();
            this.isOrdDoneCombx = new System.Windows.Forms.ComboBox();
            this.employeesCombox = new System.Windows.Forms.ComboBox();
            this.backLbl = new System.Windows.Forms.Label();
            this.customerDetailsBtn = new System.Windows.Forms.Label();
            this.dateOrderedDetailsLbl = new System.Windows.Forms.Label();
            this.firstTimeDetailsLbl = new System.Windows.Forms.Label();
            this.lastTimeDetailsLbl = new System.Windows.Forms.Label();
            this.arrivalTimeDetailsLbl = new System.Windows.Forms.Label();
            this.pricePaidLbl = new System.Windows.Forms.Label();
            this.pricePaidDetailsLbl = new System.Windows.Forms.Label();
            this.isOrdDoneLbl = new System.Windows.Forms.Label();
            this.commentLbl = new System.Windows.Forms.Label();
            this.employeeLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.commentDetailsTxtbx = new System.Windows.Forms.TextBox();
            this.delOrdBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveOrdBtn
            // 
            this.saveOrdBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.saveOrdBtn.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.saveOrdBtn.FlatAppearance.BorderSize = 2;
            this.saveOrdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveOrdBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveOrdBtn.ForeColor = System.Drawing.Color.DimGray;
            this.saveOrdBtn.Location = new System.Drawing.Point(126, 417);
            this.saveOrdBtn.Name = "saveOrdBtn";
            this.saveOrdBtn.Size = new System.Drawing.Size(128, 39);
            this.saveOrdBtn.TabIndex = 4;
            this.saveOrdBtn.Text = "Save Order";
            this.saveOrdBtn.UseVisualStyleBackColor = false;
            this.saveOrdBtn.Click += new System.EventHandler(this.saveEmpBtn_Click);
            // 
            // customerLbl
            // 
            this.customerLbl.AutoSize = true;
            this.customerLbl.BackColor = System.Drawing.Color.Transparent;
            this.customerLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerLbl.ForeColor = System.Drawing.Color.DimGray;
            this.customerLbl.Location = new System.Drawing.Point(95, 45);
            this.customerLbl.Name = "customerLbl";
            this.customerLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.customerLbl.Size = new System.Drawing.Size(86, 18);
            this.customerLbl.TabIndex = 2;
            this.customerLbl.Text = "Customer:";
            this.customerLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateOrderedLbl
            // 
            this.dateOrderedLbl.AutoSize = true;
            this.dateOrderedLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateOrderedLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateOrderedLbl.ForeColor = System.Drawing.Color.DimGray;
            this.dateOrderedLbl.Location = new System.Drawing.Point(96, 125);
            this.dateOrderedLbl.Name = "dateOrderedLbl";
            this.dateOrderedLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.dateOrderedLbl.Size = new System.Drawing.Size(114, 18);
            this.dateOrderedLbl.TabIndex = 2;
            this.dateOrderedLbl.Text = "Date Ordered:";
            this.dateOrderedLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // firstTimeLbl
            // 
            this.firstTimeLbl.AutoSize = true;
            this.firstTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.firstTimeLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstTimeLbl.ForeColor = System.Drawing.Color.DimGray;
            this.firstTimeLbl.Location = new System.Drawing.Point(80, 186);
            this.firstTimeLbl.Name = "firstTimeLbl";
            this.firstTimeLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.firstTimeLbl.Size = new System.Drawing.Size(130, 18);
            this.firstTimeLbl.TabIndex = 2;
            this.firstTimeLbl.Text = "First time asked:";
            this.firstTimeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lastTimeAskedLbl
            // 
            this.lastTimeAskedLbl.AutoSize = true;
            this.lastTimeAskedLbl.BackColor = System.Drawing.Color.Transparent;
            this.lastTimeAskedLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastTimeAskedLbl.ForeColor = System.Drawing.Color.DimGray;
            this.lastTimeAskedLbl.Location = new System.Drawing.Point(76, 252);
            this.lastTimeAskedLbl.Name = "lastTimeAskedLbl";
            this.lastTimeAskedLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lastTimeAskedLbl.Size = new System.Drawing.Size(129, 18);
            this.lastTimeAskedLbl.TabIndex = 2;
            this.lastTimeAskedLbl.Text = "Last time asked:";
            this.lastTimeAskedLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // arrivalTimeLbl
            // 
            this.arrivalTimeLbl.AutoSize = true;
            this.arrivalTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.arrivalTimeLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrivalTimeLbl.ForeColor = System.Drawing.Color.DimGray;
            this.arrivalTimeLbl.Location = new System.Drawing.Point(85, 318);
            this.arrivalTimeLbl.Name = "arrivalTimeLbl";
            this.arrivalTimeLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.arrivalTimeLbl.Size = new System.Drawing.Size(96, 18);
            this.arrivalTimeLbl.TabIndex = 2;
            this.arrivalTimeLbl.Text = "Arrival time:";
            this.arrivalTimeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // totalPriceLbl
            // 
            this.totalPriceLbl.AutoSize = true;
            this.totalPriceLbl.BackColor = System.Drawing.Color.Transparent;
            this.totalPriceLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPriceLbl.ForeColor = System.Drawing.Color.DimGray;
            this.totalPriceLbl.Location = new System.Drawing.Point(334, 45);
            this.totalPriceLbl.Name = "totalPriceLbl";
            this.totalPriceLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.totalPriceLbl.Size = new System.Drawing.Size(89, 18);
            this.totalPriceLbl.TabIndex = 2;
            this.totalPriceLbl.Text = "Total price:";
            this.totalPriceLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // totalPriceDetailsTxtbx
            // 
            this.totalPriceDetailsTxtbx.BackColor = System.Drawing.Color.LightCyan;
            this.totalPriceDetailsTxtbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPriceDetailsTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.totalPriceDetailsTxtbx.Location = new System.Drawing.Point(334, 76);
            this.totalPriceDetailsTxtbx.Name = "totalPriceDetailsTxtbx";
            this.totalPriceDetailsTxtbx.Size = new System.Drawing.Size(96, 26);
            this.totalPriceDetailsTxtbx.TabIndex = 3;
            this.totalPriceDetailsTxtbx.Leave += new System.EventHandler(this.totalPriceDetailsTxtbx_Leave);
            // 
            // isOrdDoneCombx
            // 
            this.isOrdDoneCombx.BackColor = System.Drawing.Color.LightCyan;
            this.isOrdDoneCombx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isOrdDoneCombx.ForeColor = System.Drawing.Color.DimGray;
            this.isOrdDoneCombx.FormattingEnabled = true;
            this.isOrdDoneCombx.Location = new System.Drawing.Point(785, 80);
            this.isOrdDoneCombx.Name = "isOrdDoneCombx";
            this.isOrdDoneCombx.Size = new System.Drawing.Size(115, 26);
            this.isOrdDoneCombx.TabIndex = 12;
            this.isOrdDoneCombx.SelectedIndexChanged += new System.EventHandler(this.isOrdDoneCombx_SelectedIndexChanged);
            // 
            // employeesCombox
            // 
            this.employeesCombox.BackColor = System.Drawing.Color.LightCyan;
            this.employeesCombox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeesCombox.ForeColor = System.Drawing.Color.DimGray;
            this.employeesCombox.FormattingEnabled = true;
            this.employeesCombox.Location = new System.Drawing.Point(312, 156);
            this.employeesCombox.Name = "employeesCombox";
            this.employeesCombox.Size = new System.Drawing.Size(200, 26);
            this.employeesCombox.TabIndex = 12;
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
            // customerDetailsBtn
            // 
            this.customerDetailsBtn.AutoSize = true;
            this.customerDetailsBtn.BackColor = System.Drawing.Color.Transparent;
            this.customerDetailsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerDetailsBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.customerDetailsBtn.ForeColor = System.Drawing.Color.DimGray;
            this.customerDetailsBtn.Location = new System.Drawing.Point(80, 73);
            this.customerDetailsBtn.Name = "customerDetailsBtn";
            this.customerDetailsBtn.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.customerDetailsBtn.Size = new System.Drawing.Size(155, 22);
            this.customerDetailsBtn.TabIndex = 15;
            this.customerDetailsBtn.Text = "customer details";
            this.customerDetailsBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customerDetailsBtn.Click += new System.EventHandler(this.customerDetailsBtn_Click);
            // 
            // dateOrderedDetailsLbl
            // 
            this.dateOrderedDetailsLbl.AutoSize = true;
            this.dateOrderedDetailsLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateOrderedDetailsLbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateOrderedDetailsLbl.ForeColor = System.Drawing.Color.DimGray;
            this.dateOrderedDetailsLbl.Location = new System.Drawing.Point(69, 156);
            this.dateOrderedDetailsLbl.Name = "dateOrderedDetailsLbl";
            this.dateOrderedDetailsLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.dateOrderedDetailsLbl.Size = new System.Drawing.Size(185, 22);
            this.dateOrderedDetailsLbl.TabIndex = 15;
            this.dateOrderedDetailsLbl.Text = "date ordered details";
            this.dateOrderedDetailsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // firstTimeDetailsLbl
            // 
            this.firstTimeDetailsLbl.AutoSize = true;
            this.firstTimeDetailsLbl.BackColor = System.Drawing.Color.Transparent;
            this.firstTimeDetailsLbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstTimeDetailsLbl.ForeColor = System.Drawing.Color.DimGray;
            this.firstTimeDetailsLbl.Location = new System.Drawing.Point(80, 218);
            this.firstTimeDetailsLbl.Name = "firstTimeDetailsLbl";
            this.firstTimeDetailsLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.firstTimeDetailsLbl.Size = new System.Drawing.Size(148, 22);
            this.firstTimeDetailsLbl.TabIndex = 15;
            this.firstTimeDetailsLbl.Text = "first time details";
            this.firstTimeDetailsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lastTimeDetailsLbl
            // 
            this.lastTimeDetailsLbl.AutoSize = true;
            this.lastTimeDetailsLbl.BackColor = System.Drawing.Color.Transparent;
            this.lastTimeDetailsLbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastTimeDetailsLbl.ForeColor = System.Drawing.Color.DimGray;
            this.lastTimeDetailsLbl.Location = new System.Drawing.Point(76, 284);
            this.lastTimeDetailsLbl.Name = "lastTimeDetailsLbl";
            this.lastTimeDetailsLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lastTimeDetailsLbl.Size = new System.Drawing.Size(146, 22);
            this.lastTimeDetailsLbl.TabIndex = 15;
            this.lastTimeDetailsLbl.Text = "last time details";
            this.lastTimeDetailsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // arrivalTimeDetailsLbl
            // 
            this.arrivalTimeDetailsLbl.AutoSize = true;
            this.arrivalTimeDetailsLbl.BackColor = System.Drawing.Color.Transparent;
            this.arrivalTimeDetailsLbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrivalTimeDetailsLbl.ForeColor = System.Drawing.Color.DimGray;
            this.arrivalTimeDetailsLbl.Location = new System.Drawing.Point(76, 346);
            this.arrivalTimeDetailsLbl.Name = "arrivalTimeDetailsLbl";
            this.arrivalTimeDetailsLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.arrivalTimeDetailsLbl.Size = new System.Drawing.Size(125, 22);
            this.arrivalTimeDetailsLbl.TabIndex = 15;
            this.arrivalTimeDetailsLbl.Text = "arrival details";
            this.arrivalTimeDetailsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pricePaidLbl
            // 
            this.pricePaidLbl.AutoSize = true;
            this.pricePaidLbl.BackColor = System.Drawing.Color.Transparent;
            this.pricePaidLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pricePaidLbl.ForeColor = System.Drawing.Color.DimGray;
            this.pricePaidLbl.Location = new System.Drawing.Point(485, 45);
            this.pricePaidLbl.Name = "pricePaidLbl";
            this.pricePaidLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pricePaidLbl.Size = new System.Drawing.Size(90, 18);
            this.pricePaidLbl.TabIndex = 2;
            this.pricePaidLbl.Text = "Price paid:";
            this.pricePaidLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pricePaidDetailsLbl
            // 
            this.pricePaidDetailsLbl.AutoSize = true;
            this.pricePaidDetailsLbl.BackColor = System.Drawing.Color.Transparent;
            this.pricePaidDetailsLbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pricePaidDetailsLbl.ForeColor = System.Drawing.Color.DimGray;
            this.pricePaidDetailsLbl.Location = new System.Drawing.Point(463, 80);
            this.pricePaidDetailsLbl.Name = "pricePaidDetailsLbl";
            this.pricePaidDetailsLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pricePaidDetailsLbl.Size = new System.Drawing.Size(159, 22);
            this.pricePaidDetailsLbl.TabIndex = 15;
            this.pricePaidDetailsLbl.Text = "price paid details";
            this.pricePaidDetailsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // isOrdDoneLbl
            // 
            this.isOrdDoneLbl.AutoSize = true;
            this.isOrdDoneLbl.BackColor = System.Drawing.Color.Transparent;
            this.isOrdDoneLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isOrdDoneLbl.ForeColor = System.Drawing.Color.DimGray;
            this.isOrdDoneLbl.Location = new System.Drawing.Point(785, 45);
            this.isOrdDoneLbl.Name = "isOrdDoneLbl";
            this.isOrdDoneLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.isOrdDoneLbl.Size = new System.Drawing.Size(115, 18);
            this.isOrdDoneLbl.TabIndex = 2;
            this.isOrdDoneLbl.Text = "Is Order Done:";
            this.isOrdDoneLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // commentLbl
            // 
            this.commentLbl.AutoSize = true;
            this.commentLbl.BackColor = System.Drawing.Color.Transparent;
            this.commentLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commentLbl.ForeColor = System.Drawing.Color.DimGray;
            this.commentLbl.Location = new System.Drawing.Point(553, 125);
            this.commentLbl.Name = "commentLbl";
            this.commentLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.commentLbl.Size = new System.Drawing.Size(86, 18);
            this.commentLbl.TabIndex = 2;
            this.commentLbl.Text = "Comment:";
            this.commentLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // employeeLbl
            // 
            this.employeeLbl.AutoSize = true;
            this.employeeLbl.BackColor = System.Drawing.Color.Transparent;
            this.employeeLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeLbl.ForeColor = System.Drawing.Color.DimGray;
            this.employeeLbl.Location = new System.Drawing.Point(334, 125);
            this.employeeLbl.Name = "employeeLbl";
            this.employeeLbl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.employeeLbl.Size = new System.Drawing.Size(88, 18);
            this.employeeLbl.TabIndex = 2;
            this.employeeLbl.Text = "Employee:";
            this.employeeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.dataGridView1.Location = new System.Drawing.Point(295, 218);
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
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(817, 265);
            this.dataGridView1.TabIndex = 16;
            // 
            // commentDetailsTxtbx
            // 
            this.commentDetailsTxtbx.BackColor = System.Drawing.Color.Azure;
            this.commentDetailsTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commentDetailsTxtbx.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commentDetailsTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.commentDetailsTxtbx.Location = new System.Drawing.Point(553, 156);
            this.commentDetailsTxtbx.Multiline = true;
            this.commentDetailsTxtbx.Name = "commentDetailsTxtbx";
            this.commentDetailsTxtbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentDetailsTxtbx.Size = new System.Drawing.Size(168, 26);
            this.commentDetailsTxtbx.TabIndex = 3;
            this.commentDetailsTxtbx.Text = "comment details";
            this.commentDetailsTxtbx.Leave += new System.EventHandler(this.totalPriceDetailsTxtbx_Leave);
            // 
            // delOrdBtn
            // 
            this.delOrdBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.delOrdBtn.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.delOrdBtn.FlatAppearance.BorderSize = 2;
            this.delOrdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delOrdBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delOrdBtn.ForeColor = System.Drawing.Color.DimGray;
            this.delOrdBtn.Location = new System.Drawing.Point(126, 471);
            this.delOrdBtn.Name = "delOrdBtn";
            this.delOrdBtn.Size = new System.Drawing.Size(128, 39);
            this.delOrdBtn.TabIndex = 4;
            this.delOrdBtn.Text = "Delete Order";
            this.delOrdBtn.UseVisualStyleBackColor = false;
            this.delOrdBtn.Click += new System.EventHandler(this.delOrdBtn_Click);
            // 
            // EditOrderUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pricePaidDetailsLbl);
            this.Controls.Add(this.arrivalTimeDetailsLbl);
            this.Controls.Add(this.lastTimeDetailsLbl);
            this.Controls.Add(this.firstTimeDetailsLbl);
            this.Controls.Add(this.dateOrderedDetailsLbl);
            this.Controls.Add(this.customerDetailsBtn);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.employeesCombox);
            this.Controls.Add(this.isOrdDoneCombx);
            this.Controls.Add(this.delOrdBtn);
            this.Controls.Add(this.saveOrdBtn);
            this.Controls.Add(this.commentDetailsTxtbx);
            this.Controls.Add(this.totalPriceDetailsTxtbx);
            this.Controls.Add(this.isOrdDoneLbl);
            this.Controls.Add(this.pricePaidLbl);
            this.Controls.Add(this.totalPriceLbl);
            this.Controls.Add(this.arrivalTimeLbl);
            this.Controls.Add(this.lastTimeAskedLbl);
            this.Controls.Add(this.commentLbl);
            this.Controls.Add(this.firstTimeLbl);
            this.Controls.Add(this.dateOrderedLbl);
            this.Controls.Add(this.employeeLbl);
            this.Controls.Add(this.customerLbl);
            this.Name = "EditOrderUC";
            this.Size = new System.Drawing.Size(1280, 540);
            this.Load += new System.EventHandler(this.EditOrderUC_Load);
            this.Resize += new System.EventHandler(this.EditOrderUC_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button saveOrdBtn;
        private Label customerLbl;
        private Label dateOrderedLbl;
        private Label firstTimeLbl;
        private Label lastTimeAskedLbl;
        private Label arrivalTimeLbl;
        private Label totalPriceLbl;
        private TextBox totalPriceDetailsTxtbx;
        private ComboBox isOrdDoneCombx;
        private ComboBox employeesCombox;
        private Label backLbl;
        private Label customerDetailsBtn;
        private Label dateOrderedDetailsLbl;
        private Label firstTimeDetailsLbl;
        private Label lastTimeDetailsLbl;
        private Label arrivalTimeDetailsLbl;
        private Label pricePaidLbl;
        private Label pricePaidDetailsLbl;
        private Label isOrdDoneLbl;
        private Label commentLbl;
        private Label employeeLbl;
        private DataGridView dataGridView1;
        private TextBox commentDetailsTxtbx;
        private Button delOrdBtn;
    }
}
