using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using BUS.Services;
using DAL;
using DAL.Models;
using DAL.Repositories;
using DoAn1_QuanLyPhanMemBanPKDT;
namespace DuAn1
{

    public partial class TaiKhoanForm : Form
    {
        AcontDAL cc = new AcontDAL();
        AcontBLL ac = new AcontBLL();
        LoginBLL lgbll = new LoginBLL();
        List<Account> listAC;
        private string originalId;

        public TaiKhoanForm()
        {
            InitializeComponent();
        }

        public dynamic GetListAccount()
        {
            listAC = ac.getListAccount().ToList();
            var TG = ac.getListAccount().Select(s => new { s.Idaccount, s.PassAccount, s.AccountLevel, s.AccountName, s.Email }).ToList();
            return TG;
        }
        public void LoadDataGridView()
        {
            dataGridView1.DataSource = GetListAccount();
        }

        private void TaiKhoanForm_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.CurrentCell = null;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtTImKiem_Click(object sender, EventArgs e)
        {
            txtTImKiem.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbbLevel.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                originalId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện chức năng này !");
            }
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            try
            {

                int concac = cc.InsertAC(txtTImKiem.Text).Count;
                if (concac > 0)
                {
                    var list = cc.InsertAC(txtTImKiem.Text).ToList();
                    dataGridView1.DataSource = list.Select(x => new { x.Idaccount, x.PassAccount, x.AccountLevel, x.AccountName, x.Email }).ToList();

                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên nào");
                }


            }
            catch
            {
                MessageBox.Show("Có lỗi khi tìm kiếm ! ");
            }
        }
        public bool CheckTextBox()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("ID không được để trống.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên không được để trống.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống.");
                return false;
            }

            if (!IsValidAccountLevel(cbbLevel.Text))
            {
                MessageBox.Show("Cấp độ tài khoản không hợp lệ. Vui lòng chọn 1 hoặc 2.");
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidAccountLevel(string level)
        {
            return level == "1" || level == "2";
        }
        private void btnresset_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
            cbbLevel.SelectedIndex = -1;
            LoadDataGridView();
        }
        public Account ObjectNV()
        {
            if (CheckTextBox())
            {
                Account nv = new Account
                {
                    Idaccount = txtId.Text,
                    PassAccount = txtPass.Text,
                    AccountName = txtName.Text,
                    Email = txtEmail.Text,
                    AccountLevel = int.Parse(cbbLevel.Text)
                };
                return nv;
            }
            return null;
        
    }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var newAccount = ObjectNV();
            if (newAccount != null)
            {
                if (listAC.Find(s => s.Idaccount == newAccount.Idaccount) == null)
                {
                    if (lgbll.TimkiemTK(newAccount.Idaccount) == null)
                    {
                        cc.AddTaiKhoan(newAccount);
                        LoadDataGridView();
                        MessageBox.Show("Thêm nhân viên thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản này đã tồn tại, hãy nhập lại!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã nhân viên này đã tồn tại, hãy nhập lại!");
                }
            }
            else
            {
                
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem ID có được nhập vào hay không
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Vui lòng nhập ID của tài khoản cần xóa.");
                return;
            }

            // Kiểm tra xem tài khoản với ID đã nhập có tồn tại trong danh sách không
            Account accountToDelete = listAC.Find(s => s.Idaccount == txtId.Text);
            if (accountToDelete != null)
            {
                // Xóa tài khoản khỏi danh sách và cơ sở dữ liệu
                listAC.Remove(accountToDelete);
                cc.DeleteTaiKhoan(accountToDelete);

                MessageBox.Show("Xóa thành công tài khoản này.");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản với ID đã nhập.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var updatedAccount = ObjectNV();
            if (updatedAccount != null)
            {
                var existingAccount = listAC.Find(s => s.Idaccount == updatedAccount.Idaccount);
                if (existingAccount != null)
                {
                    ac.Replace(updatedAccount);
                    listAC.Remove(existingAccount);
                    listAC.Add(updatedAccount);
                    MessageBox.Show("Sửa thành công!");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể sửa id!");
                }
            }
            else
            {
               
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            XuatExcel xuatExcel = new XuatExcel();
            string[] tieudecolumn = { "Id Account", "PassWord", "Level", "Name", "Email" };
            xuatExcel.ExportToExcel(dataGridView1, "Danh Sách Account", tieudecolumn, "danhsachAccount.xlsx");
        }
    }
}
