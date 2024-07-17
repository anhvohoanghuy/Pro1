using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void FormProduct_Load(object sender, EventArgs e)
        {

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

            // Thêm form mới vào Panel (giả sử bạn có Panel tên là panelContainer)
            

            formnew.BringToFront();
            formnew.Show();
        }
        private Button ButtonNow;
        private void btnProductDetail_Click(object sender, EventArgs e)
        {

           ProductDeltailForm a = new ProductDeltailForm();
            a.Show();
            
        }
    }
}
