namespace DuAn1
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panel1 = new Panel();
            lblPhanQuyen = new Label();
            label2 = new Label();
            lblDateTime = new Label();
            lblUserName = new Label();
            panel6 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            btnVoucher = new CustomButton.VBButton();
            panel7 = new Panel();
            btnLogOut = new CustomButton.VBButton();
            btnStatistics = new CustomButton.VBButton();
            btnEmployee = new CustomButton.VBButton();
            btnOrder = new CustomButton.VBButton();
            btnCreateOrder = new CustomButton.VBButton();
            btnProduct = new CustomButton.VBButton();
            vbButton1 = new CustomButton.VBButton();
            panel5 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(lblPhanQuyen);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblDateTime);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(227, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 62);
            panel1.TabIndex = 0;
            // 
            // lblPhanQuyen
            // 
            lblPhanQuyen.AutoSize = true;
            lblPhanQuyen.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhanQuyen.ForeColor = SystemColors.ButtonHighlight;
            lblPhanQuyen.Location = new Point(384, 19);
            lblPhanQuyen.Name = "lblPhanQuyen";
            lblPhanQuyen.Size = new Size(41, 23);
            lblPhanQuyen.TabIndex = 7;
            lblPhanQuyen.Text = "Null";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(292, 19);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 6;
            label2.Text = "Chức vụ : ";
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateTime.ForeColor = SystemColors.ButtonHighlight;
            lblDateTime.Location = new Point(592, 17);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(109, 25);
            lblDateTime.TabIndex = 5;
            lblDateTime.Text = "ddd/mm/yy";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = SystemColors.ButtonHighlight;
            lblUserName.Location = new Point(159, 19);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(41, 23);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "Null";
            // 
            // panel6
            // 
            panel6.BackgroundImage = Properties.Resources.add_user;
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(124, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(29, 38);
            panel6.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(1093, 638);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.MediumSlateBlue;
            panel2.Controls.Add(btnVoucher);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnStatistics);
            panel2.Controls.Add(btnEmployee);
            panel2.Controls.Add(btnOrder);
            panel2.Controls.Add(btnCreateOrder);
            panel2.Controls.Add(btnProduct);
            panel2.Controls.Add(vbButton1);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-5, 5);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 700);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnVoucher
            // 
            btnVoucher.BackColor = Color.MediumSlateBlue;
            btnVoucher.BackgroundColor = Color.MediumSlateBlue;
            btnVoucher.BorderColor = Color.PaleVioletRed;
            btnVoucher.BorderRadius = 20;
            btnVoucher.BorderSize = 0;
            btnVoucher.FlatAppearance.BorderSize = 0;
            btnVoucher.FlatStyle = FlatStyle.Flat;
            btnVoucher.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoucher.ForeColor = Color.White;
            btnVoucher.Image = (Image)resources.GetObject("btnVoucher.Image");
            btnVoucher.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoucher.Location = new Point(21, 379);
            btnVoucher.Name = "btnVoucher";
            btnVoucher.Size = new Size(188, 50);
            btnVoucher.TabIndex = 21;
            btnVoucher.Text = "Voucher";
            btnVoucher.TextColor = Color.White;
            btnVoucher.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVoucher.UseVisualStyleBackColor = false;
            btnVoucher.Click += btnVoucher_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BackgroundImageLayout = ImageLayout.None;
            panel7.Location = new Point(17, 600);
            panel7.Margin = new Padding(3, 0, 3, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(192, 3);
            panel7.TabIndex = 14;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogOut.BackColor = Color.MediumSlateBlue;
            btnLogOut.BackgroundColor = Color.MediumSlateBlue;
            btnLogOut.BorderColor = Color.PaleVioletRed;
            btnLogOut.BorderRadius = 20;
            btnLogOut.BorderSize = 0;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(21, 637);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(188, 50);
            btnLogOut.TabIndex = 20;
            btnLogOut.Text = "Đăng xuất";
            btnLogOut.TextColor = Color.White;
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.BackColor = Color.MediumSlateBlue;
            btnStatistics.BackgroundColor = Color.MediumSlateBlue;
            btnStatistics.BorderColor = Color.PaleVioletRed;
            btnStatistics.BorderRadius = 20;
            btnStatistics.BorderSize = 0;
            btnStatistics.FlatAppearance.BorderSize = 0;
            btnStatistics.FlatStyle = FlatStyle.Flat;
            btnStatistics.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStatistics.ForeColor = Color.White;
            btnStatistics.Image = (Image)resources.GetObject("btnStatistics.Image");
            btnStatistics.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatistics.Location = new Point(21, 521);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(188, 50);
            btnStatistics.TabIndex = 19;
            btnStatistics.Text = "Thống kê";
            btnStatistics.TextColor = Color.White;
            btnStatistics.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStatistics.UseVisualStyleBackColor = false;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.MediumSlateBlue;
            btnEmployee.BackgroundColor = Color.MediumSlateBlue;
            btnEmployee.BorderColor = Color.PaleVioletRed;
            btnEmployee.BorderRadius = 20;
            btnEmployee.BorderSize = 0;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmployee.ForeColor = Color.White;
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(21, 449);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(188, 50);
            btnEmployee.TabIndex = 18;
            btnEmployee.Text = "Tài khoản";
            btnEmployee.TextColor = Color.White;
            btnEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.MediumSlateBlue;
            btnOrder.BackgroundColor = Color.MediumSlateBlue;
            btnOrder.BorderColor = Color.PaleVioletRed;
            btnOrder.BorderRadius = 20;
            btnOrder.BorderSize = 0;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrder.ForeColor = Color.White;
            btnOrder.Image = (Image)resources.GetObject("btnOrder.Image");
            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(17, 238);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(188, 50);
            btnOrder.TabIndex = 17;
            btnOrder.Text = "Đơn hàng";
            btnOrder.TextColor = Color.White;
            btnOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.BackColor = Color.MediumSlateBlue;
            btnCreateOrder.BackgroundColor = Color.MediumSlateBlue;
            btnCreateOrder.BorderColor = Color.PaleVioletRed;
            btnCreateOrder.BorderRadius = 20;
            btnCreateOrder.BorderSize = 0;
            btnCreateOrder.FlatAppearance.BorderSize = 0;
            btnCreateOrder.FlatStyle = FlatStyle.Flat;
            btnCreateOrder.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateOrder.ForeColor = Color.White;
            btnCreateOrder.Image = (Image)resources.GetObject("btnCreateOrder.Image");
            btnCreateOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateOrder.Location = new Point(17, 159);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(211, 50);
            btnCreateOrder.TabIndex = 16;
            btnCreateOrder.Text = "Tạo đơn hàng";
            btnCreateOrder.TextColor = Color.White;
            btnCreateOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreateOrder.UseVisualStyleBackColor = false;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.MediumSlateBlue;
            btnProduct.BackgroundColor = Color.MediumSlateBlue;
            btnProduct.BorderColor = Color.PaleVioletRed;
            btnProduct.BorderRadius = 20;
            btnProduct.BorderSize = 0;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = Color.White;
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(17, 313);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(188, 50);
            btnProduct.TabIndex = 15;
            btnProduct.Text = "Sản Phẩm";
            btnProduct.TextColor = Color.White;
            btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // vbButton1
            // 
            vbButton1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            vbButton1.BackColor = Color.MediumSlateBlue;
            vbButton1.BackgroundColor = Color.MediumSlateBlue;
            vbButton1.BorderColor = Color.PaleVioletRed;
            vbButton1.BorderRadius = 20;
            vbButton1.BorderSize = 0;
            vbButton1.FlatAppearance.BorderSize = 0;
            vbButton1.FlatStyle = FlatStyle.Flat;
            vbButton1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vbButton1.ForeColor = Color.White;
            vbButton1.Image = Properties.Resources._25694__2_;
            vbButton1.ImageAlign = ContentAlignment.MiddleLeft;
            vbButton1.Location = new Point(17, 86);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(188, 50);
            vbButton1.TabIndex = 14;
            vbButton1.Text = "Trang chủ";
            vbButton1.TextColor = Color.White;
            vbButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            vbButton1.UseVisualStyleBackColor = false;
            vbButton1.Click += vbButton1_Click_2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BackgroundImageLayout = ImageLayout.None;
            panel5.Location = new Point(17, 57);
            panel5.Margin = new Padding(3, 0, 3, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(192, 3);
            panel5.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(34, 4);
            label1.Name = "label1";
            label1.Size = new Size(161, 46);
            label1.TabIndex = 0;
            label1.Text = "Xin chào";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSize = true;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Location = new Point(230, 64);
            panel4.Name = "panel4";
            panel4.Size = new Size(990, 638);
            panel4.TabIndex = 0;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1220, 704);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMenu";
            Text = "FormMenu";
            FormClosing += FormMenu_FormClosing;
            Load += FormMenu_Load;
            Resize += FormMenu_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Label label1;
        private Panel panel4;
        private Label lblDateTime;
        private Label lblUserName;
        private Panel panel6;
        private CustomButton.VBButton btnLogOut;
        private CustomButton.VBButton btnStatistics;
        private CustomButton.VBButton btnEmployee;
        private CustomButton.VBButton btnOrder;
        private CustomButton.VBButton btnCreateOrder;
        private CustomButton.VBButton btnProduct;
        private CustomButton.VBButton vbButton1;
        private Panel panel7;
        private CustomButton.VBButton btnVoucher;
        private Label lblPhanQuyen;
        private Label label2;
    }
}