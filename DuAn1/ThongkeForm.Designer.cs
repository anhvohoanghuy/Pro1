namespace DuAn1
{
    partial class ThongkeForm
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
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            idOrder = new DataGridViewTextBoxColumn();
            IdStaff = new DataGridViewTextBoxColumn();
            IdProd = new DataGridViewTextBoxColumn();
            NameProd = new DataGridViewTextBoxColumn();
            IdCustomer = new DataGridViewTextBoxColumn();
            NameCus = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            vbButton1 = new CustomButton.VBButton();
            textBox7 = new TextBox();
            btninfoOrder = new CustomButton.VBButton();
            vbButton2 = new CustomButton.VBButton();
            vbButton3 = new CustomButton.VBButton();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1356, 427);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "List Bill";
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
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idOrder, IdStaff, IdProd, NameProd, IdCustomer, NameCus, Phone, Date, TotalAmount });
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
            dataGridView1.Location = new Point(3, 27);
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
            dataGridView1.Size = new Size(1350, 397);
            dataGridView1.TabIndex = 1;
            // 
            // idOrder
            // 
            idOrder.HeaderText = "Id Order";
            idOrder.MinimumWidth = 6;
            idOrder.Name = "idOrder";
            idOrder.ReadOnly = true;
            // 
            // IdStaff
            // 
            IdStaff.HeaderText = "IdStaff";
            IdStaff.MinimumWidth = 6;
            IdStaff.Name = "IdStaff";
            IdStaff.ReadOnly = true;
            // 
            // IdProd
            // 
            IdProd.HeaderText = "IDprod";
            IdProd.MinimumWidth = 6;
            IdProd.Name = "IdProd";
            IdProd.ReadOnly = true;
            // 
            // NameProd
            // 
            NameProd.HeaderText = "NameProd";
            NameProd.MinimumWidth = 6;
            NameProd.Name = "NameProd";
            NameProd.ReadOnly = true;
            // 
            // IdCustomer
            // 
            IdCustomer.HeaderText = "Id Customer";
            IdCustomer.MinimumWidth = 6;
            IdCustomer.Name = "IdCustomer";
            IdCustomer.ReadOnly = true;
            // 
            // NameCus
            // 
            NameCus.HeaderText = "NameCus";
            NameCus.MinimumWidth = 6;
            NameCus.Name = "NameCus";
            NameCus.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // TotalAmount
            // 
            TotalAmount.HeaderText = "Total Amount(VNĐ)";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(vbButton3);
            groupBox1.Controls.Add(vbButton2);
            groupBox1.Controls.Add(btninfoOrder);
            groupBox1.Controls.Add(vbButton1);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Location = new Point(56, 492);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1087, 93);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
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
            vbButton1.Location = new Point(350, 32);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(72, 29);
            vbButton1.TabIndex = 76;
            vbButton1.TextColor = Color.White;
            vbButton1.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Left;
            textBox7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.ForeColor = Color.Gray;
            textBox7.Location = new Point(28, 32);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(403, 36);
            textBox7.TabIndex = 75;
            textBox7.Text = "Tìm kiếm";
            // 
            // btninfoOrder
            // 
            btninfoOrder.BackColor = Color.MediumSlateBlue;
            btninfoOrder.BackgroundColor = Color.MediumSlateBlue;
            btninfoOrder.BorderColor = Color.PaleVioletRed;
            btninfoOrder.BorderRadius = 20;
            btninfoOrder.BorderSize = 0;
            btninfoOrder.FlatAppearance.BorderSize = 0;
            btninfoOrder.FlatStyle = FlatStyle.Flat;
            btninfoOrder.ForeColor = Color.White;
            btninfoOrder.Location = new Point(460, 32);
            btninfoOrder.Name = "btninfoOrder";
            btninfoOrder.Size = new Size(168, 40);
            btninfoOrder.TabIndex = 105;
            btninfoOrder.Text = "Xem chi tiết đơn hàng";
            btninfoOrder.TextColor = Color.White;
            btninfoOrder.UseVisualStyleBackColor = false;
            // 
            // vbButton2
            // 
            vbButton2.BackColor = Color.MediumSlateBlue;
            vbButton2.BackgroundColor = Color.MediumSlateBlue;
            vbButton2.BorderColor = Color.PaleVioletRed;
            vbButton2.BorderRadius = 20;
            vbButton2.BorderSize = 0;
            vbButton2.FlatAppearance.BorderSize = 0;
            vbButton2.FlatStyle = FlatStyle.Flat;
            vbButton2.ForeColor = Color.White;
            vbButton2.Location = new Point(666, 32);
            vbButton2.Name = "vbButton2";
            vbButton2.Size = new Size(168, 40);
            vbButton2.TabIndex = 106;
            vbButton2.Text = "Xuất Excel";
            vbButton2.TextColor = Color.White;
            vbButton2.UseVisualStyleBackColor = false;
            // 
            // vbButton3
            // 
            vbButton3.BackColor = Color.MediumSlateBlue;
            vbButton3.BackgroundColor = Color.MediumSlateBlue;
            vbButton3.BorderColor = Color.PaleVioletRed;
            vbButton3.BorderRadius = 20;
            vbButton3.BorderSize = 0;
            vbButton3.FlatAppearance.BorderSize = 0;
            vbButton3.FlatStyle = FlatStyle.Flat;
            vbButton3.ForeColor = Color.White;
            vbButton3.Location = new Point(865, 32);
            vbButton3.Name = "vbButton3";
            vbButton3.Size = new Size(129, 40);
            vbButton3.TabIndex = 107;
            vbButton3.Text = "Refesh";
            vbButton3.TextColor = Color.White;
            vbButton3.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(56, 591);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(825, 90);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 36);
            label1.Name = "label1";
            label1.Size = new Size(198, 31);
            label1.TabIndex = 0;
            label1.Text = "Tổng doanh thu: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(249, 36);
            label2.Name = "label2";
            label2.Size = new Size(69, 31);
            label2.TabIndex = 1;
            label2.Text = "Value";
            // 
            // ThongkeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 790);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "ThongkeForm";
            Text = "ThongkeForm";
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idOrder;
        private DataGridViewTextBoxColumn IdStaff;
        private DataGridViewTextBoxColumn IdProd;
        private DataGridViewTextBoxColumn NameProd;
        private DataGridViewTextBoxColumn IdCustomer;
        private DataGridViewTextBoxColumn NameCus;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn TotalAmount;
        private GroupBox groupBox1;
        private CustomButton.VBButton vbButton1;
        private TextBox textBox7;
        private CustomButton.VBButton vbButton3;
        private CustomButton.VBButton vbButton2;
        private CustomButton.VBButton btninfoOrder;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
    }
}