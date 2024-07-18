namespace DuAn1
{
    partial class FormProduct
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            rdoUnActivated = new RadioButton();
            rdoActivated = new RadioButton();
            cbbIDCPU = new ComboBox();
            cbbIDAccount = new ComboBox();
            cbbIDCompany = new ComboBox();
            cbbIDProduct = new ComboBox();
            btnProductDetail = new CustomButton.VBButton();
            btnExcel = new CustomButton.VBButton();
            vbButton2 = new CustomButton.VBButton();
            btnSua = new CustomButton.VBButton();
            btnThem = new CustomButton.VBButton();
            vbButton1 = new CustomButton.VBButton();
            textBox7 = new TextBox();
            label36 = new Label();
            label38 = new Label();
            txtPin = new TextBox();
            label39 = new Label();
            txtCameraResolution = new TextBox();
            label40 = new Label();
            txtRefreshRate = new TextBox();
            label41 = new Label();
            txtScreenResolution = new TextBox();
            label42 = new Label();
            txtScreenSize = new TextBox();
            label45 = new Label();
            labelo = new Label();
            txtRam = new TextBox();
            label47 = new Label();
            label48 = new Label();
            txtProductName = new TextBox();
            label49 = new Label();
            txtProductImage = new TextBox();
            label50 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            EmployeeId = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            HomeTown = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left;
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(cbbIDCPU);
            panel2.Controls.Add(cbbIDAccount);
            panel2.Controls.Add(cbbIDCompany);
            panel2.Controls.Add(cbbIDProduct);
            panel2.Controls.Add(btnProductDetail);
            panel2.Controls.Add(btnExcel);
            panel2.Controls.Add(vbButton2);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(vbButton1);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label36);
            panel2.Controls.Add(label38);
            panel2.Controls.Add(txtPin);
            panel2.Controls.Add(label39);
            panel2.Controls.Add(txtCameraResolution);
            panel2.Controls.Add(label40);
            panel2.Controls.Add(txtRefreshRate);
            panel2.Controls.Add(label41);
            panel2.Controls.Add(txtScreenResolution);
            panel2.Controls.Add(label42);
            panel2.Controls.Add(txtScreenSize);
            panel2.Controls.Add(label45);
            panel2.Controls.Add(labelo);
            panel2.Controls.Add(txtRam);
            panel2.Controls.Add(label47);
            panel2.Controls.Add(label48);
            panel2.Controls.Add(txtProductName);
            panel2.Controls.Add(label49);
            panel2.Controls.Add(txtProductImage);
            panel2.Controls.Add(label50);
            panel2.Location = new Point(16, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(1427, 373);
            panel2.TabIndex = 63;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdoUnActivated);
            groupBox3.Controls.Add(rdoActivated);
            groupBox3.Location = new Point(1023, 28);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(374, 101);
            groupBox3.TabIndex = 88;
            groupBox3.TabStop = false;
            groupBox3.Text = "Product status";
            // 
            // rdoUnActivated
            // 
            rdoUnActivated.AutoSize = true;
            rdoUnActivated.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoUnActivated.Location = new Point(204, 41);
            rdoUnActivated.Name = "rdoUnActivated";
            rdoUnActivated.Size = new Size(126, 29);
            rdoUnActivated.TabIndex = 84;
            rdoUnActivated.TabStop = true;
            rdoUnActivated.Text = "Unactivated";
            rdoUnActivated.UseVisualStyleBackColor = true;
            // 
            // rdoActivated
            // 
            rdoActivated.AutoSize = true;
            rdoActivated.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoActivated.Location = new Point(28, 41);
            rdoActivated.Name = "rdoActivated";
            rdoActivated.Size = new Size(107, 29);
            rdoActivated.TabIndex = 83;
            rdoActivated.TabStop = true;
            rdoActivated.Text = "Activated";
            rdoActivated.UseVisualStyleBackColor = true;
            // 
            // cbbIDCPU
            // 
            cbbIDCPU.FormattingEnabled = true;
            cbbIDCPU.Location = new Point(488, 208);
            cbbIDCPU.Name = "cbbIDCPU";
            cbbIDCPU.Size = new Size(172, 28);
            cbbIDCPU.TabIndex = 87;
            cbbIDCPU.TextUpdate += cbbIDCPU_TextUpdate;
            // 
            // cbbIDAccount
            // 
            cbbIDAccount.FormattingEnabled = true;
            cbbIDAccount.Location = new Point(488, 126);
            cbbIDAccount.Name = "cbbIDAccount";
            cbbIDAccount.Size = new Size(172, 28);
            cbbIDAccount.TabIndex = 86;
            cbbIDAccount.TextChanged += cbbIDAccount_TextChanged;
            // 
            // cbbIDCompany
            // 
            cbbIDCompany.FormattingEnabled = true;
            cbbIDCompany.Location = new Point(238, 34);
            cbbIDCompany.Name = "cbbIDCompany";
            cbbIDCompany.Size = new Size(172, 28);
            cbbIDCompany.TabIndex = 85;
            cbbIDCompany.TextChanged += cbbIDCompany_TextChanged;
            // 
            // cbbIDProduct
            // 
            cbbIDProduct.FormattingEnabled = true;
            cbbIDProduct.Location = new Point(16, 35);
            cbbIDProduct.Name = "cbbIDProduct";
            cbbIDProduct.Size = new Size(172, 28);
            cbbIDProduct.TabIndex = 84;
            cbbIDProduct.TextChanged += cbbIDProduct_TextChanged;
            // 
            // btnProductDetail
            // 
            btnProductDetail.Anchor = AnchorStyles.Left;
            btnProductDetail.BackColor = Color.MediumSlateBlue;
            btnProductDetail.BackgroundColor = Color.MediumSlateBlue;
            btnProductDetail.BorderColor = Color.PaleVioletRed;
            btnProductDetail.BorderRadius = 20;
            btnProductDetail.BorderSize = 0;
            btnProductDetail.FlatAppearance.BorderSize = 0;
            btnProductDetail.FlatStyle = FlatStyle.Flat;
            btnProductDetail.ForeColor = Color.White;
            btnProductDetail.Location = new Point(1153, 319);
            btnProductDetail.Name = "btnProductDetail";
            btnProductDetail.Size = new Size(135, 40);
            btnProductDetail.TabIndex = 83;
            btnProductDetail.Text = "product detail";
            btnProductDetail.TextColor = Color.White;
            btnProductDetail.UseVisualStyleBackColor = false;
            btnProductDetail.Click += btnProductDetail_Click;
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
            btnExcel.Location = new Point(978, 319);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(135, 40);
            btnExcel.TabIndex = 81;
            btnExcel.Text = "Xuất excel";
            btnExcel.TextColor = Color.White;
            btnExcel.UseVisualStyleBackColor = false;
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
            vbButton2.Location = new Point(806, 316);
            vbButton2.Name = "vbButton2";
            vbButton2.Size = new Size(135, 40);
            vbButton2.TabIndex = 78;
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
            btnSua.Location = new Point(628, 316);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(135, 40);
            btnSua.TabIndex = 76;
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
            btnThem.Location = new Point(477, 316);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(135, 40);
            btnThem.TabIndex = 75;
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
            vbButton1.Location = new Point(356, 319);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(72, 29);
            vbButton1.TabIndex = 74;
            vbButton1.TextColor = Color.White;
            vbButton1.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Left;
            textBox7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.ForeColor = Color.Gray;
            textBox7.Location = new Point(34, 316);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(403, 36);
            textBox7.TabIndex = 73;
            textBox7.Text = "Tìm kiếm";
            // 
            // label36
            // 
            label36.Anchor = AnchorStyles.Left;
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 11F);
            label36.Location = new Point(488, 104);
            label36.Name = "label36";
            label36.Size = new Size(97, 25);
            label36.TabIndex = 41;
            label36.Text = "IdAccount";
            // 
            // label38
            // 
            label38.Anchor = AnchorStyles.Left;
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 11F);
            label38.Location = new Point(238, 184);
            label38.Name = "label38";
            label38.Size = new Size(39, 25);
            label38.TabIndex = 36;
            label38.Text = "Pin";
            // 
            // txtPin
            // 
            txtPin.Anchor = AnchorStyles.Left;
            txtPin.Location = new Point(238, 207);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(172, 27);
            txtPin.TabIndex = 34;
            // 
            // label39
            // 
            label39.Anchor = AnchorStyles.Left;
            label39.AutoSize = true;
            label39.Font = new Font("Segoe UI", 11F);
            label39.Location = new Point(776, 104);
            label39.Name = "label39";
            label39.Size = new Size(165, 25);
            label39.TabIndex = 37;
            label39.Text = "CameraResolution";
            // 
            // txtCameraResolution
            // 
            txtCameraResolution.Anchor = AnchorStyles.Left;
            txtCameraResolution.Location = new Point(779, 127);
            txtCameraResolution.Name = "txtCameraResolution";
            txtCameraResolution.Size = new Size(172, 27);
            txtCameraResolution.TabIndex = 35;
            // 
            // label40
            // 
            label40.Anchor = AnchorStyles.Left;
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 11F);
            label40.Location = new Point(488, 2);
            label40.Name = "label40";
            label40.Size = new Size(111, 25);
            label40.TabIndex = 33;
            label40.Text = "RefreshRate";
            // 
            // txtRefreshRate
            // 
            txtRefreshRate.Anchor = AnchorStyles.Left;
            txtRefreshRate.Location = new Point(488, 34);
            txtRefreshRate.Name = "txtRefreshRate";
            txtRefreshRate.Size = new Size(172, 27);
            txtRefreshRate.TabIndex = 32;
            // 
            // label41
            // 
            label41.Anchor = AnchorStyles.Left;
            label41.AutoSize = true;
            label41.Font = new Font("Segoe UI", 11F);
            label41.Location = new Point(779, 2);
            label41.Name = "label41";
            label41.Size = new Size(157, 25);
            label41.TabIndex = 31;
            label41.Text = "ScreenResolution";
            // 
            // txtScreenResolution
            // 
            txtScreenResolution.Anchor = AnchorStyles.Left;
            txtScreenResolution.Location = new Point(779, 35);
            txtScreenResolution.Name = "txtScreenResolution";
            txtScreenResolution.Size = new Size(172, 27);
            txtScreenResolution.TabIndex = 30;
            // 
            // label42
            // 
            label42.Anchor = AnchorStyles.Left;
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 11F);
            label42.Location = new Point(769, 184);
            label42.Name = "label42";
            label42.Size = new Size(103, 25);
            label42.TabIndex = 29;
            label42.Text = "ScreenSize";
            // 
            // txtScreenSize
            // 
            txtScreenSize.Anchor = AnchorStyles.Left;
            txtScreenSize.Location = new Point(769, 209);
            txtScreenSize.Name = "txtScreenSize";
            txtScreenSize.Size = new Size(172, 27);
            txtScreenSize.TabIndex = 28;
            // 
            // label45
            // 
            label45.Anchor = AnchorStyles.Left;
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI", 11F);
            label45.Location = new Point(488, 184);
            label45.Name = "label45";
            label45.Size = new Size(66, 25);
            label45.TabIndex = 23;
            label45.Text = "IDCPU";
            // 
            // labelo
            // 
            labelo.Anchor = AnchorStyles.Left;
            labelo.AutoSize = true;
            labelo.Font = new Font("Segoe UI", 11F);
            labelo.Location = new Point(232, 104);
            labelo.Name = "labelo";
            labelo.Size = new Size(49, 25);
            labelo.TabIndex = 21;
            labelo.Text = "Ram";
            // 
            // txtRam
            // 
            txtRam.Anchor = AnchorStyles.Left;
            txtRam.Location = new Point(238, 126);
            txtRam.Name = "txtRam";
            txtRam.Size = new Size(172, 27);
            txtRam.TabIndex = 20;
            // 
            // label47
            // 
            label47.Anchor = AnchorStyles.Left;
            label47.AutoSize = true;
            label47.Font = new Font("Segoe UI", 11F);
            label47.Location = new Point(240, 2);
            label47.Name = "label47";
            label47.Size = new Size(110, 25);
            label47.TabIndex = 19;
            label47.Text = "IDCompany";
            // 
            // label48
            // 
            label48.Anchor = AnchorStyles.Left;
            label48.AutoSize = true;
            label48.Font = new Font("Segoe UI", 11F);
            label48.Location = new Point(14, 184);
            label48.Name = "label48";
            label48.Size = new Size(128, 25);
            label48.TabIndex = 17;
            label48.Text = "ProductName";
            // 
            // txtProductName
            // 
            txtProductName.Anchor = AnchorStyles.Left;
            txtProductName.Location = new Point(16, 207);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(172, 27);
            txtProductName.TabIndex = 16;
            // 
            // label49
            // 
            label49.Anchor = AnchorStyles.Left;
            label49.AutoSize = true;
            label49.Font = new Font("Segoe UI", 11F);
            label49.Location = new Point(14, 100);
            label49.Name = "label49";
            label49.Size = new Size(130, 25);
            label49.TabIndex = 17;
            label49.Text = "ProductImage";
            // 
            // txtProductImage
            // 
            txtProductImage.Anchor = AnchorStyles.Left;
            txtProductImage.Location = new Point(16, 126);
            txtProductImage.Name = "txtProductImage";
            txtProductImage.Size = new Size(172, 27);
            txtProductImage.TabIndex = 16;
            // 
            // label50
            // 
            label50.Anchor = AnchorStyles.Left;
            label50.AutoSize = true;
            label50.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label50.Location = new Point(14, 2);
            label50.Name = "label50";
            label50.Size = new Size(92, 25);
            label50.TabIndex = 6;
            label50.Text = "IDProduct";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Location = new Point(20, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1491, 405);
            groupBox1.TabIndex = 65;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(36, 474);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1475, 268);
            groupBox2.TabIndex = 66;
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
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle13.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeId, Username, Password, name, HomeTown, Email });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.MediumSlateBlue;
            dataGridView1.Location = new Point(3, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle16.ForeColor = Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.HighlightText;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1469, 235);
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
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1524, 847);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormProduct";
            Text = "FormProduct";
            Load += FormProduct_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private CustomButton.VBButton vbButton2;
        private CustomButton.VBButton btnSua;
        private CustomButton.VBButton btnThem;
        private CustomButton.VBButton vbButton1;
        private TextBox textBox7;
        private Label label36;
        private Label label38;
        private TextBox txtPin;
        private Label label39;
        private TextBox txtCameraResolution;
        private Label label40;
        private TextBox txtRefreshRate;
        private Label label41;
        private TextBox txtScreenResolution;
        private Label label42;
        private TextBox txtScreenSize;
        private Label label45;
        private Label labelo;
        private TextBox txtRam;
        private Label label47;
        private Label label48;
        private TextBox txtProductName;
        private Label label49;
        private TextBox txtProductImage;
        private Label label50;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CustomButton.VBButton btnExcel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn EmployeeId;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn HomeTown;
        private DataGridViewTextBoxColumn Email;
        private CustomButton.VBButton btnProductDetail;
        private ComboBox cbbIDAccount;
        private ComboBox cbbIDCompany;
        private ComboBox cbbIDProduct;
        private ComboBox cbbIDCPU;
        private GroupBox groupBox3;
        private RadioButton rdoActivated;
        private RadioButton rdoUnActivated;
    }
}