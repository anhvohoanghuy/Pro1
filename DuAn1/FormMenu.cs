using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1
{
    public partial class FormMenu : Form
    {

        public FormMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;objKeyboardProcess = new LowLevelKeyboardProc(captureKey);ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = GetTimeNow();
            lblUserName.Text = DangNhapForm.GetDataUser.acccountname;
            lblPhanQuyen.Text = DangNhapForm.GetDataUser.accountlevel == 1 ? "Nhân Viên" :
                    DangNhapForm.GetDataUser.accountlevel == 2 ? "Admin" : "Không xác định";

            if (lblPhanQuyen.Text == "Nhân Viên")
            {
                btnEmployee.Visible = false;
                btnStatistics.Visible = false;
            }
            else if (lblPhanQuyen.Text == "Admin")
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
                panel1.Visible = false;
                
                for (int i = 0; i < 10; i++)
                {
                    MessageBox.Show("Bạn đéo có quyền truy cập");
                }               
                this.Hide();
                DangNhapForm a = new DangNhapForm(); a.ShowDialog(); 
             }
    
                
            ButtonNow = vbButton1;
            ButtonNow.ForeColor = Color.DarkGreen;
        }

        static string GetTimeNow()
        {
            DateTime date = DateTime.Now; // Lấy thời điểm hiện tại

            string dayOfWeek = date.ToString("dddd"); // Lấy thứ trong tuần
            string dayOfMonth = date.Day.ToString(); // Lấy ngày trong tháng
            string month = date.Month.ToString(); // Lấy tên của tháng
            string year = date.Year.ToString(); // Lấy năm

            return $"{dayOfWeek}, ngày {dayOfMonth}/{month}/{year}";
        }
        private Form formNow;
        private void LoadForm(Form formnew)
        {
            if (formNow != null)
            {
                formNow.Close();
            }
            formNow = formnew;
            formnew.TopLevel = false;
            formnew.FormBorderStyle = FormBorderStyle.None;
            formnew.Dock = DockStyle.Fill;
            panel4.Controls.Add(formnew);
            panel4.Tag = formnew;
            formnew.BringToFront();
            formnew.Show();
        }
        private Button ButtonNow;


        private void ActiveColor(Button ButtonNew)
        {
            if (ButtonNow != null)
            {
                ButtonNow.ForeColor = Color.White;
                ButtonNow = ButtonNew;
                ButtonNew.ForeColor = Color.DarkGreen;

            }
        }

        private void FormMenu_Resize(object sender, EventArgs e)
        {


        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FormProduct a = new FormProduct();
            LoadForm(a);
            ActiveColor(btnProduct);
        }

        private void vbButton1_Click_2(object sender, EventArgs e)
        {
            panel4.Controls.Clear();

            ActiveColor(vbButton1);
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            FormVoucher a = new FormVoucher();
            LoadForm(a);
            ActiveColor(btnVoucher);
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         [StructLayout(LayoutKind.Sequential)] private struct KBDLLHOOKSTRUCT { public Keys key; public int scanCode; public int flags; public int time; public IntPtr extra; } private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam); [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)] private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId); [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)] private static extern bool UnhookWindowsHookEx(IntPtr hook); [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)] private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp); [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)] private static extern IntPtr GetModuleHandle(string name); [DllImport("user32.dll", CharSet = CharSet.Auto)] private static extern short GetAsyncKeyState(Keys key); private IntPtr ptrHook; private LowLevelKeyboardProc objKeyboardProcess; private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp) { if (nCode >= 0) { KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT)); if (objKeyInfo.key == Keys.RWin || objKeyInfo.key == Keys.LWin || (objKeyInfo.key >= Keys.F1 && objKeyInfo.key <= Keys.F12) || objKeyInfo.key == Keys.RControlKey || objKeyInfo.key == Keys.LControlKey || objKeyInfo.key == Keys.Escape || objKeyInfo.key == Keys.Tab && HasAltModifier(objKeyInfo.flags) || objKeyInfo.key == Keys.Escape && (ModifierKeys & Keys.Control) == Keys.Control) { return (IntPtr)1; } } return CallNextHookEx(ptrHook, nCode, wp, lp); } bool HasAltModifier(int flags) { return (flags & 0x20) == 0x20; }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (e.CloseReason == CloseReason.UserClosing);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            TaiKhoanForm a = new TaiKhoanForm();
            LoadForm(a);
            ActiveColor(btnEmployee);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất tài khoản không  ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); if (result == DialogResult.Yes) MessageBox.Show("Không cho thoát"); //{this.Hide(); DangNhapForm a = new DangNhapForm(); a.ShowDialog();}
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrderForm a = new CreateOrderForm();
            LoadForm(a);
            ActiveColor(btnEmployee);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            ThongkeForm a = new ThongkeForm();
            LoadForm(a);
            ActiveColor(btnStatistics);
        }
    }
}
