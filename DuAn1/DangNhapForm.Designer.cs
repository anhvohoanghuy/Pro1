
namespace DuAn1
{
    partial class DangNhapForm
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
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPass = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            cbViewPass = new CheckBox();
            btnLogin = new CustomButton.VBButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(706, 169);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(706, 249);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.WhiteSmoke;
            txtUserName.Location = new Point(706, 200);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(244, 27);
            txtUserName.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.WhiteSmoke;
            txtPass.Location = new Point(706, 280);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(244, 27);
            txtPass.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.network_connection_background_abstract_style_23_21488757381;
            panel1.Location = new Point(-4, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 548);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(725, 72);
            label3.Name = "label3";
            label3.Size = new Size(202, 41);
            label3.TabIndex = 5;
            label3.Text = "Đăng nhập";
            // 
            // cbViewPass
            // 
            cbViewPass.AutoSize = true;
            cbViewPass.Location = new Point(706, 313);
            cbViewPass.Name = "cbViewPass";
            cbViewPass.Size = new Size(148, 24);
            cbViewPass.TabIndex = 6;
            cbViewPass.Text = "Hiển thị mật khẩu";
            cbViewPass.UseVisualStyleBackColor = true;
            cbViewPass.CheckedChanged += cbViewPass_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSlateBlue;
            btnLogin.BackgroundColor = Color.MediumSlateBlue;
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 20;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(737, 375);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(166, 50);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // DangNhapForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 522);
            Controls.Add(btnLogin);
            Controls.Add(cbViewPass);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(txtPass);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DangNhapForm";
            Text = "DangNhapForm";
            Load += DangNhapForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPass;
        private Panel panel1;
        private Label label3;
        private CheckBox cbViewPass;
        private CustomButton.VBButton btnLogin;
    }
}