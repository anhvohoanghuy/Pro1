using BUS;
using BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1
{
    public partial class FormProduct : Form
    {
        ProductBUS productBUS = new ProductBUS();
        ProductCompanyBUS productCompanyBUS = new ProductCompanyBUS();
        AccountBUS accountBUS = new AccountBUS();
        CpuBUS cpuBUS = new CpuBUS();
        Validate validate = new Validate();
        public FormProduct()
        {
            InitializeComponent();
        }
        public void LoadCbbWhenTextChange(ComboBox currentCbb, List<string> originList)
        {
            int cursorPosition = currentCbb.SelectionStart;
            var text = currentCbb.Text;
            foreach (var item in originList.Where(c => c.Contains(text)))
            {
                currentCbb.Items.Add(item);
            }
            currentCbb.DroppedDown = true;
            currentCbb.SelectionStart = cursorPosition;
            currentCbb.SelectionLength = 0;
        }
        public bool CheckNull(params string[] strings)
        {
            foreach (var item in strings)
            {
                if (string.IsNullOrEmpty(item))
                    return true;
            }
            return false;
        }
        public string CheckIsNumberInProduct(TextBox ram, TextBox pin, TextBox refreshRate, TextBox cameraResolution, TextBox screenSize)
        {
            if (int.TryParse(ram.Text, out _))
                return "Ram phải là số nguyên";
            else if (int.TryParse(pin.Text, out _))
                return "Pin phải là số nguyên tính theo mAh";
            else if (int.TryParse(refreshRate.Text, out _))
                return "Refresh rate phải là số nguyên";
            else if (double.TryParse(cameraResolution.Text, out _))
                return "Camera resolution phải là số";
            else if (double.TryParse(screenSize.Text, out _))
                return "Screen size phải là số";
            return null;
        }
        public void ResetFormProduct()
        {
            cbbIDProduct.Text = string.Empty;
            txtProductImage.Clear();
            txtProductName.Clear();
            cbbIDAccount.Text= string.Empty;
            txtRam.Clear();
            txtPin.Clear();
            txtRefreshRate.Clear();
            cbbIDAccount.Text = string.Empty;
            cbbIDCPU.Text = string.Empty;
            txtScreenResolution.Clear();
            txtCameraResolution.Clear();
            rdoActivated.Checked = true;
            rdoUnActivated.Checked = false;
        }
        private void FormProduct_Load(object sender, EventArgs e)
        {
            rdoActivated.Checked = true;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            var productID = cbbIDProduct.SelectedItem.ToString();
            var productImage = txtProductImage.Text;
            var productName = txtProductName.Text;
            var idCompany = cbbIDCompany.SelectedItem.ToString();
            var ram = txtRam.Text;
            var pin = txtPin.Text;
            var refreshRate = txtRefreshRate.Text;
            var idAccount = cbbIDAccount.SelectedItem.ToString();
            var idCPU = cbbIDCPU.SelectedItem.ToString();
            var screenResolution = txtScreenResolution.Text;
            var cameraResolution = txtCameraResolution.Text;
            var screenSize = txtScreenSize.Text;
            var status = rdoActivated.Checked ? true : false;
            if (CheckNull(productID, productImage, productName, idCompany, ram, pin, refreshRate, idAccount, idCPU, cameraResolution, screenResolution, screenSize) == false)
            {
                var checkNum = CheckIsNumberInProduct(txtRam, txtPin, txtRefreshRate, txtCameraResolution, txtScreenSize);
                if (checkNum!=null)
                {
                    productBUS.AddNewProduct(productID, productImage, productName, idCompany, int.Parse(ram), idCPU, double.Parse(screenSize), screenResolution, int.Parse(refreshRate), double.Parse(cameraResolution), int.Parse(pin), idAccount, status);
                }
                else
                    MessageBox.Show(checkNum);
            }
            else
                MessageBox.Show("Nhập đầy đủ thông tin trước khi thêm");
        }

        private void cbbIDProduct_TextChanged(object sender, EventArgs e)
        {
            LoadCbbWhenTextChange(cbbIDProduct, productBUS.GetAllIDProduct());
        }

        private void cbbIDCompany_TextChanged(object sender, EventArgs e)
        {
            LoadCbbWhenTextChange(cbbIDCompany, productCompanyBUS.GetAllIDCompany());
        }

        private void cbbIDAccount_TextChanged(object sender, EventArgs e)
        {
            LoadCbbWhenTextChange(cbbIDAccount, accountBUS.GetAllIDAccount());
        }

        private void cbbIDCPU_TextUpdate(object sender, EventArgs e)
        {
            LoadCbbWhenTextChange(cbbIDCPU, cpuBUS.GetAllIDCpu());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var productID = cbbIDProduct.SelectedItem.ToString();
            var productImage = txtProductImage.Text;
            var productName = txtProductName.Text;
            var idCompany = cbbIDCompany.SelectedItem.ToString();
            var ram = txtRam.Text;
            var pin = txtPin.Text;
            var refreshRate = txtRefreshRate.Text;
            var idAccount = cbbIDAccount.SelectedItem.ToString();
            var idCPU = cbbIDCPU.SelectedItem.ToString();
            var screenResolution = txtScreenResolution.Text;
            var cameraResolution = txtCameraResolution.Text;
            var screenSize = txtScreenSize.Text;
            var status = rdoActivated.Checked ? true : false;
            if (CheckNull(productID, productImage, productName, idCompany, ram, pin, refreshRate, idAccount, idCPU, cameraResolution, screenResolution, screenSize) == false)
            {
                var checkNum = CheckIsNumberInProduct(txtRam, txtPin, txtRefreshRate, txtCameraResolution, txtScreenSize);
                if (checkNum != null)
                {
                    productBUS.UpdateProduct(productID, productImage, productName, idCompany, int.Parse(ram), idCPU, double.Parse(screenSize), screenResolution, int.Parse(refreshRate), double.Parse(cameraResolution), int.Parse(pin), idAccount, status);
                }
                else
                    MessageBox.Show(checkNum);
            }
            else
                MessageBox.Show("Nhập đầy đủ thông tin trước khi sửa");
        }
    }
}
