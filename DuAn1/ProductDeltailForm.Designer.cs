namespace DuAn1
{
    partial class ProductDeltailForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBox txtNameCpu;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            cbbIdAccount = new ComboBox();
            label1 = new Label();
            cbbIdPromotion = new ComboBox();
            cbbIdColor = new ComboBox();
            label2 = new Label();
            txtColorName = new TextBox();
            cbbIdCpu = new ComboBox();
            cbbIdProduct = new ComboBox();
            btnExcel = new CustomButton.VBButton();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            vbButton2 = new CustomButton.VBButton();
            btnSua = new CustomButton.VBButton();
            btnThem = new CustomButton.VBButton();
            vbButton1 = new CustomButton.VBButton();
            textBox7 = new TextBox();
            label6 = new Label();
            label9 = new Label();
            txtImeiNumber = new TextBox();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            txtDiscount = new TextBox();
            label30 = new Label();
            txtPromotionName = new TextBox();
            label31 = new Label();
            txtInventory = new TextBox();
            label32 = new Label();
            txtWarrantyPeriod = new TextBox();
            label33 = new Label();
            label34 = new Label();
            txtPrice = new TextBox();
            label35 = new Label();
            txtStorage = new TextBox();
            label36 = new Label();
            label37 = new Label();
            txtIdProductDetail = new TextBox();
            label43 = new Label();
            txtManufacturer = new TextBox();
            label44 = new Label();
            label45 = new Label();
            label50 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            EmployeeId = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            HomeTown = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            txtNameCpu = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNameCpu
            // 
            txtNameCpu.Anchor = AnchorStyles.Left;
            txtNameCpu.Location = new Point(17, 190);
            txtNameCpu.Name = "txtNameCpu";
            txtNameCpu.ReadOnly = true;
            txtNameCpu.Size = new Size(172, 27);
            txtNameCpu.TabIndex = 95;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbbIdAccount);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbbIdPromotion);
            groupBox1.Controls.Add(cbbIdColor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtColorName);
            groupBox1.Controls.Add(cbbIdCpu);
            groupBox1.Controls.Add(cbbIdProduct);
            groupBox1.Controls.Add(btnExcel);
            groupBox1.Controls.Add(dtpEndDate);
            groupBox1.Controls.Add(dtpStartDate);
            groupBox1.Controls.Add(vbButton2);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(vbButton1);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtImeiNumber);
            groupBox1.Controls.Add(label27);
            groupBox1.Controls.Add(label28);
            groupBox1.Controls.Add(label29);
            groupBox1.Controls.Add(txtDiscount);
            groupBox1.Controls.Add(label30);
            groupBox1.Controls.Add(txtPromotionName);
            groupBox1.Controls.Add(label31);
            groupBox1.Controls.Add(txtInventory);
            groupBox1.Controls.Add(label32);
            groupBox1.Controls.Add(txtWarrantyPeriod);
            groupBox1.Controls.Add(label33);
            groupBox1.Controls.Add(label34);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label35);
            groupBox1.Controls.Add(txtStorage);
            groupBox1.Controls.Add(label36);
            groupBox1.Controls.Add(label37);
            groupBox1.Controls.Add(txtIdProductDetail);
            groupBox1.Controls.Add(label43);
            groupBox1.Controls.Add(txtManufacturer);
            groupBox1.Controls.Add(label44);
            groupBox1.Controls.Add(txtNameCpu);
            groupBox1.Controls.Add(label45);
            groupBox1.Controls.Add(label50);
            groupBox1.Location = new Point(69, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1302, 421);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // cbbIdAccount
            // 
            cbbIdAccount.FormattingEnabled = true;
            cbbIdAccount.Location = new Point(685, 304);
            cbbIdAccount.Name = "cbbIdAccount";
            cbbIdAccount.Size = new Size(168, 28);
            cbbIdAccount.TabIndex = 151;
            cbbIdAccount.DropDown += cbbIdAccount_DropDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(685, 276);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 150;
            label1.Text = "IdAccount";
            // 
            // cbbIdPromotion
            // 
            cbbIdPromotion.FormattingEnabled = true;
            cbbIdPromotion.Location = new Point(685, 129);
            cbbIdPromotion.Name = "cbbIdPromotion";
            cbbIdPromotion.Size = new Size(168, 28);
            cbbIdPromotion.TabIndex = 148;
            cbbIdPromotion.DropDown += cbbIdPromotion_DropDown;
            // 
            // cbbIdColor
            // 
            cbbIdColor.FormattingEnabled = true;
            cbbIdColor.Location = new Point(344, 135);
            cbbIdColor.Name = "cbbIdColor";
            cbbIdColor.Size = new Size(168, 28);
            cbbIdColor.TabIndex = 147;
            cbbIdColor.DropDown += cbbIdColor_DropDown;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(340, 166);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 146;
            label2.Text = "ColorName";
            // 
            // txtColorName
            // 
            txtColorName.Anchor = AnchorStyles.Left;
            txtColorName.Location = new Point(340, 191);
            txtColorName.Name = "txtColorName";
            txtColorName.ReadOnly = true;
            txtColorName.Size = new Size(172, 27);
            txtColorName.TabIndex = 144;
            // 
            // cbbIdCpu
            // 
            cbbIdCpu.FormattingEnabled = true;
            cbbIdCpu.Location = new Point(21, 135);
            cbbIdCpu.Name = "cbbIdCpu";
            cbbIdCpu.Size = new Size(168, 28);
            cbbIdCpu.TabIndex = 142;
            cbbIdCpu.DropDown += cbbIdCpu_DropDown;
            // 
            // cbbIdProduct
            // 
            cbbIdProduct.FormattingEnabled = true;
            cbbIdProduct.Location = new Point(17, 69);
            cbbIdProduct.Name = "cbbIdProduct";
            cbbIdProduct.Size = new Size(168, 28);
            cbbIdProduct.TabIndex = 140;
            cbbIdProduct.DropDown += cbbIdProduct_DropDown;
            // 
            // btnExcel
            // 
            btnExcel.Anchor = AnchorStyles.Left;
            btnExcel.BackColor = Color.MediumSlateBlue;
            btnExcel.BackgroundColor = Color.MediumSlateBlue;
            btnExcel.BorderColor = Color.PaleVioletRed;
            btnExcel.BorderRadius = 20;
            btnExcel.BorderSize = 0;
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.ForeColor = Color.White;
            btnExcel.Location = new Point(961, 349);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(135, 40);
            btnExcel.TabIndex = 139;
            btnExcel.Text = "Xuất excel";
            btnExcel.TextColor = Color.White;
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Anchor = AnchorStyles.Left;
            dtpEndDate.Location = new Point(979, 299);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(254, 27);
            dtpEndDate.TabIndex = 138;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor = AnchorStyles.Left;
            dtpStartDate.Location = new Point(979, 242);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(254, 27);
            dtpStartDate.TabIndex = 137;
            // 
            // vbButton2
            // 
            vbButton2.Anchor = AnchorStyles.Left;
            vbButton2.BackColor = Color.MediumSlateBlue;
            vbButton2.BackgroundColor = Color.MediumSlateBlue;
            vbButton2.BorderColor = Color.PaleVioletRed;
            vbButton2.BorderRadius = 20;
            vbButton2.BorderSize = 0;
            vbButton2.FlatAppearance.BorderSize = 0;
            vbButton2.FlatStyle = FlatStyle.Flat;
            vbButton2.ForeColor = Color.White;
            vbButton2.Image = Properties.Resources.reset__1_;
            vbButton2.Location = new Point(799, 349);
            vbButton2.Name = "vbButton2";
            vbButton2.Size = new Size(135, 40);
            vbButton2.TabIndex = 136;
            vbButton2.TextColor = Color.White;
            vbButton2.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Left;
            btnSua.BackColor = Color.MediumSlateBlue;
            btnSua.BackgroundColor = Color.MediumSlateBlue;
            btnSua.BorderColor = Color.PaleVioletRed;
            btnSua.BorderRadius = 20;
            btnSua.BorderSize = 0;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(631, 346);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(135, 40);
            btnSua.TabIndex = 134;
            btnSua.Text = "Sửa";
            btnSua.TextColor = Color.White;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Left;
            btnThem.BackColor = Color.MediumSlateBlue;
            btnThem.BackgroundColor = Color.MediumSlateBlue;
            btnThem.BorderColor = Color.PaleVioletRed;
            btnThem.BorderRadius = 20;
            btnThem.BorderSize = 0;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(480, 346);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(135, 40);
            btnThem.TabIndex = 133;
            btnThem.Text = "Thêm";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // vbButton1
            // 
            vbButton1.Anchor = AnchorStyles.Left;
            vbButton1.BackColor = Color.White;
            vbButton1.BackgroundColor = Color.White;
            vbButton1.BorderColor = Color.White;
            vbButton1.BorderRadius = 0;
            vbButton1.BorderSize = 0;
            vbButton1.FlatAppearance.BorderSize = 0;
            vbButton1.FlatStyle = FlatStyle.Flat;
            vbButton1.ForeColor = Color.White;
            vbButton1.Image = Properties.Resources.search__1_3;
            vbButton1.Location = new Point(359, 349);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(72, 29);
            vbButton1.TabIndex = 132;
            vbButton1.TextColor = Color.White;
            vbButton1.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Left;
            textBox7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.ForeColor = Color.Gray;
            textBox7.Location = new Point(37, 346);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(403, 36);
            textBox7.TabIndex = 131;
            textBox7.Text = "Tìm kiếm";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(979, 271);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 130;
            label6.Text = "EndTime";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(979, 37);
            label9.Name = "label9";
            label9.Size = new Size(117, 25);
            label9.TabIndex = 129;
            label9.Text = "ImeiNumber";
            // 
            // txtImeiNumber
            // 
            txtImeiNumber.Anchor = AnchorStyles.Left;
            txtImeiNumber.Location = new Point(979, 65);
            txtImeiNumber.Name = "txtImeiNumber";
            txtImeiNumber.Size = new Size(172, 27);
            txtImeiNumber.TabIndex = 128;
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.Left;
            label27.AutoSize = true;
            label27.Location = new Point(681, 159);
            label27.Name = "label27";
            label27.Size = new Size(0, 20);
            label27.TabIndex = 127;
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Left;
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 11F);
            label28.Location = new Point(974, 219);
            label28.Name = "label28";
            label28.Size = new Size(91, 25);
            label28.TabIndex = 125;
            label28.Text = "StartTime";
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.Left;
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 11F);
            label29.Location = new Point(979, 159);
            label29.Name = "label29";
            label29.Size = new Size(86, 25);
            label29.TabIndex = 126;
            label29.Text = "Discount";
            // 
            // txtDiscount
            // 
            txtDiscount.Anchor = AnchorStyles.Left;
            txtDiscount.Location = new Point(979, 187);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(172, 27);
            txtDiscount.TabIndex = 124;
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Left;
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 11F);
            label30.Location = new Point(979, 102);
            label30.Name = "label30";
            label30.Size = new Size(151, 25);
            label30.TabIndex = 123;
            label30.Text = "PromotionName";
            // 
            // txtPromotionName
            // 
            txtPromotionName.Anchor = AnchorStyles.Left;
            txtPromotionName.Location = new Point(979, 130);
            txtPromotionName.Name = "txtPromotionName";
            txtPromotionName.ReadOnly = true;
            txtPromotionName.Size = new Size(172, 27);
            txtPromotionName.TabIndex = 122;
            // 
            // label31
            // 
            label31.Anchor = AnchorStyles.Left;
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 11F);
            label31.Location = new Point(681, 219);
            label31.Name = "label31";
            label31.Size = new Size(91, 25);
            label31.TabIndex = 121;
            label31.Text = "inventory";
            // 
            // txtInventory
            // 
            txtInventory.Anchor = AnchorStyles.Left;
            txtInventory.Location = new Point(681, 246);
            txtInventory.Name = "txtInventory";
            txtInventory.Size = new Size(172, 27);
            txtInventory.TabIndex = 120;
            // 
            // label32
            // 
            label32.Anchor = AnchorStyles.Left;
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 11F);
            label32.Location = new Point(681, 154);
            label32.Name = "label32";
            label32.Size = new Size(143, 25);
            label32.TabIndex = 119;
            label32.Text = "WarrantyPeriod";
            // 
            // txtWarrantyPeriod
            // 
            txtWarrantyPeriod.Anchor = AnchorStyles.Left;
            txtWarrantyPeriod.Location = new Point(681, 184);
            txtWarrantyPeriod.Name = "txtWarrantyPeriod";
            txtWarrantyPeriod.Size = new Size(172, 27);
            txtWarrantyPeriod.TabIndex = 118;
            // 
            // label33
            // 
            label33.Anchor = AnchorStyles.Left;
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 11F);
            label33.Location = new Point(681, 102);
            label33.Name = "label33";
            label33.Size = new Size(119, 25);
            label33.TabIndex = 116;
            label33.Text = "IDPromotion";
            // 
            // label34
            // 
            label34.Anchor = AnchorStyles.Left;
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 11F);
            label34.Location = new Point(681, 37);
            label34.Name = "label34";
            label34.Size = new Size(54, 25);
            label34.TabIndex = 117;
            label34.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Left;
            txtPrice.Location = new Point(681, 66);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(172, 27);
            txtPrice.TabIndex = 115;
            // 
            // label35
            // 
            label35.Anchor = AnchorStyles.Left;
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 11F);
            label35.Location = new Point(340, 224);
            label35.Name = "label35";
            label35.Size = new Size(76, 25);
            label35.TabIndex = 113;
            label35.Text = "Storage";
            // 
            // txtStorage
            // 
            txtStorage.Anchor = AnchorStyles.Left;
            txtStorage.Location = new Point(340, 248);
            txtStorage.Name = "txtStorage";
            txtStorage.Size = new Size(172, 27);
            txtStorage.TabIndex = 112;
            // 
            // label36
            // 
            label36.Anchor = AnchorStyles.Left;
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 11F);
            label36.Location = new Point(340, 107);
            label36.Name = "label36";
            label36.Size = new Size(74, 25);
            label36.TabIndex = 111;
            label36.Text = "IdColor";
            // 
            // label37
            // 
            label37.Anchor = AnchorStyles.Left;
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 11F);
            label37.Location = new Point(340, 37);
            label37.Name = "label37";
            label37.Size = new Size(143, 25);
            label37.TabIndex = 109;
            label37.Text = "IdProductDetail";
            // 
            // txtIdProductDetail
            // 
            txtIdProductDetail.Anchor = AnchorStyles.Left;
            txtIdProductDetail.Font = new Font("Segoe UI", 11F);
            txtIdProductDetail.Location = new Point(340, 65);
            txtIdProductDetail.Name = "txtIdProductDetail";
            txtIdProductDetail.Size = new Size(172, 32);
            txtIdProductDetail.TabIndex = 108;
            // 
            // label43
            // 
            label43.Anchor = AnchorStyles.Left;
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 11F);
            label43.Location = new Point(15, 224);
            label43.Name = "label43";
            label43.Size = new Size(129, 25);
            label43.TabIndex = 96;
            label43.Text = "ManuFacturer";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Anchor = AnchorStyles.Left;
            txtManufacturer.Location = new Point(17, 249);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.ReadOnly = true;
            txtManufacturer.Size = new Size(172, 27);
            txtManufacturer.TabIndex = 94;
            // 
            // label44
            // 
            label44.Anchor = AnchorStyles.Left;
            label44.AutoSize = true;
            label44.Font = new Font("Segoe UI", 11F);
            label44.Location = new Point(17, 165);
            label44.Name = "label44";
            label44.Size = new Size(98, 25);
            label44.TabIndex = 97;
            label44.Text = "NameCPU";
            // 
            // label45
            // 
            label45.Anchor = AnchorStyles.Left;
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI", 11F);
            label45.Location = new Point(17, 107);
            label45.Name = "label45";
            label45.Size = new Size(66, 25);
            label45.TabIndex = 93;
            label45.Text = "IDCPU";
            // 
            // label50
            // 
            label50.Anchor = AnchorStyles.Left;
            label50.AutoSize = true;
            label50.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label50.Location = new Point(15, 37);
            label50.Name = "label50";
            label50.Size = new Size(92, 25);
            label50.TabIndex = 83;
            label50.Text = "IDProduct";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(42, 521);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1475, 346);
            groupBox2.TabIndex = 67;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeId, Username, Password, name, HomeTown, Email });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.MediumSlateBlue;
            dataGridView1.Location = new Point(3, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.HighlightText;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1469, 313);
            dataGridView1.TabIndex = 1;
            // 
            // EmployeeId
            // 
            EmployeeId.HeaderText = "Employee Id";
            EmployeeId.MinimumWidth = 6;
            EmployeeId.Name = "EmployeeId";
            EmployeeId.ReadOnly = true;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Employee name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // HomeTown
            // 
            HomeTown.HeaderText = "hometown";
            HomeTown.MinimumWidth = 6;
            HomeTown.Name = "HomeTown";
            HomeTown.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // ProductDeltailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1555, 934);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ProductDeltailForm";
            Text = "ProductDeltailForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CustomButton.VBButton btnExcel;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private CustomButton.VBButton vbButton2;
        private CustomButton.VBButton btnSua;
        private CustomButton.VBButton btnThem;
        private CustomButton.VBButton vbButton1;
        private TextBox textBox7;
        private Label label6;
        private Label label9;
        private TextBox txtImeiNumber;
        private Label label27;
        private Label label28;
        private Label label29;
        private TextBox txtDiscount;
        private Label label30;
        private TextBox txtPromotionName;
        private Label label33;
        private Label label36;
        private Label label43;
        private TextBox txtManufacturer;
        private Label label44;
        private TextBox txtNameCpu;
        private Label label45;
        private Label label50;
        private ComboBox cbbIdCpu;
        private ComboBox cbbIdProduct;
        private Label label31;
        private TextBox txtInventory;
        private Label label32;
        private TextBox txtWarrantyPeriod;
        private Label label34;
        private TextBox txtPrice;
        private Label label35;
        private TextBox txtStorage;
        private Label label37;
        private TextBox txtIdProductDetail;
        private Label label2;
        private TextBox txtColorName;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn EmployeeId;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn HomeTown;
        private DataGridViewTextBoxColumn Email;
        private ComboBox cbbIdPromotion;
        private ComboBox cbbIdColor;
        private ComboBox cbbIdAccount;
        private Label label1;
    }
}