using BUS;
using BUS.Services;
using DAL.Models;
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
        public void LoadDataGridView()
        {
            dgvListProduct.Columns.Add("IDproduct", "ID product");
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "ProductImage";
            imgCol.HeaderText = "Product image";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgCol.Width = 100;
            dgvListProduct.Columns.Add(imgCol);
            dgvListProduct.Columns.Add("ProductName", "Product name");
            dgvListProduct.Columns.Add("IdCompany", "ID company");
            dgvListProduct.Columns.Add("Ram", "Ram");
            dgvListProduct.Columns.Add("IdCpu", "ID CPU");
            dgvListProduct.Columns.Add("ScreenSize", "Screen size");
            dgvListProduct.Columns.Add("ScreenResolution", "Screen resolution");
            dgvListProduct.Columns.Add("RefreshRate", "Refresh rate");
            dgvListProduct.Columns.Add("CameraResolution", "Camera resolution");
            dgvListProduct.Columns.Add("Pin", "Pin");
            dgvListProduct.Columns.Add("IdAccount", "ID account");
            dgvListProduct.Columns.Add("ProductStatus", "Product status");
            dgvListProduct.RowTemplate.Height = 100;
        }
        public void ShowOnDataGridView(List<Product> products)
        {
            dgvListProduct.Rows.Clear();
            foreach (Product product in products)
            {
                try
                {
                    System.Net.WebRequest request = System.Net.WebRequest.Create(product.ProductImage);
                    System.Net.WebResponse response = request.GetResponse();
                    System.IO.Stream responseStream = response.GetResponseStream();
                    Bitmap img = new Bitmap(responseStream);
                    dgvListProduct.Rows.Add(product.Idproduct, img, product.ProductName, product.Idcompany, product.Ram, product.Idcpu, product.ScreenSize, product.ScreenResolution, product.RefreshRate, product.CameraResolution, product.Pin, product.Idaccount, product.ProductStatus);
                }
                catch (Exception)
                {
                    System.Net.WebRequest request = System.Net.WebRequest.Create("https://cdn2.fptshop.com.vn/unsafe/180x0/filters:quality(60)/2023_10_30_638342502751589917_ip-15-pro-max-dd-bh-2-nam.jpg");
                    System.Net.WebResponse response = request.GetResponse();
                    System.IO.Stream responseStream = response.GetResponseStream();
                    Bitmap img = new Bitmap(responseStream);
                    dgvListProduct.Rows.Add(product.Idproduct, img, product.ProductName, product.Idcompany, product.Ram, product.Idcpu, product.ScreenSize, product.ScreenResolution, product.RefreshRate, product.CameraResolution, product.Pin, product.Idaccount, product.ProductStatus);
                }

            }
        }
        public void LoadCbbWhenDropDown(ComboBox currentCbb, List<string> originList)
        {
            currentCbb.Items.Clear();
            foreach (var item in originList.Where(c => c.Contains(currentCbb.Text)))
            {
                currentCbb.Items.Add(item);
            }
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
            txtProductID.Text = string.Empty;
            txtProductImage.Clear();
            txtProductName.Clear();
            cbbIDAccount.Text = string.Empty;
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
            LoadDataGridView();
            List<Product> products = productBUS.GetAllProduct();
            ShowOnDataGridView(products);

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
            var productID = txtProductID.Text;
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
                    if (productBUS.CheckProductIfExist(productID))
                    {
                        if (productBUS.AddNewProduct(productID, productImage, productName, idCompany, int.Parse(ram), idCPU, double.Parse(screenSize), screenResolution, int.Parse(refreshRate), double.Parse(cameraResolution), int.Parse(pin), idAccount, status))
                            MessageBox.Show("Thêm thành công");
                        else
                            MessageBox.Show("Thêm thất bại");
                    }
                    else
                        MessageBox.Show("ID product này đã tồn tại");
                }
                else
                    MessageBox.Show(checkNum);
            }
            else
                MessageBox.Show("Nhập đầy đủ thông tin trước khi thêm");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var productID = txtProductID.Text;
            var productImage = txtProductImage.Text;
            var productName = txtProductName.Text;
            var idCompany = cbbIDCompany.SelectedValue.ToString();
            var ram = txtRam.Text;
            var pin = txtPin.Text;
            var refreshRate = txtRefreshRate.Text;
            var idAccount = cbbIDAccount.SelectedValue.ToString();
            var idCPU = cbbIDCPU.SelectedValue.ToString();
            var screenResolution = txtScreenResolution.Text;
            var cameraResolution = txtCameraResolution.Text;
            var screenSize = txtScreenSize.Text;
            var status = rdoActivated.Checked ? true : false;
            if (CheckNull(productID, productImage, productName, idCompany, ram, pin, refreshRate, idAccount, idCPU, cameraResolution, screenResolution, screenSize) == false)
            {
                var checkNum = CheckIsNumberInProduct(txtRam, txtPin, txtRefreshRate, txtCameraResolution, txtScreenSize);
                if (checkNum != null)
                {
                    if (productBUS.UpdateProduct(productID, productImage, productName, idCompany, int.Parse(ram), idCPU, double.Parse(screenSize), screenResolution, int.Parse(refreshRate), double.Parse(cameraResolution), int.Parse(pin), idAccount, status))
                        MessageBox.Show("Sửa thành công");
                    else
                        MessageBox.Show("Sửa thất bại");
                }
                else
                    MessageBox.Show(checkNum);
            }
            else
                MessageBox.Show("Nhập đầy đủ thông tin trước khi sửa");
        }

        private void cbbIDCompany_DropDown(object sender, EventArgs e)
        {
            LoadCbbWhenDropDown(cbbIDCompany, productCompanyBUS.GetAllIDCompany());
        }

        private void cbbIDAccount_DropDown(object sender, EventArgs e)
        {
            LoadCbbWhenDropDown(cbbIDAccount, accountBUS.GetAllIDAccount());
        }

        private void cbbIDCPU_DropDown(object sender, EventArgs e)
        {
            LoadCbbWhenDropDown(cbbIDCPU, cpuBUS.GetAllIDCpu());
        }

        private void dgvListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvListProduct.Rows[e.RowIndex];
                var idProduct= row.Cells[0].Value.ToString();
                var product = productBUS.GetProductByID(idProduct);
                txtProductID.Text = product.Idproduct;
                txtProductImage.Text=product.ProductImage;
                txtProductName.Text = product.ProductName;
                cbbIDCompany.Text=product.Idcompany;
                txtRam.Text=product.Ram.ToString();
                txtPin.Text=product.Pin.ToString();
                txtRefreshRate.Text=product.RefreshRate.ToString();
                cbbIDAccount.Text=product.Idaccount;
                cbbIDCPU.Text=product.Idcpu;
                txtScreenSize.Text=product.ScreenSize.ToString();
                txtScreenResolution.Text=product.ScreenResolution.ToString();
                txtCameraResolution.Text=product.CameraResolution.ToString();
                if (product.ProductStatus)
                {
                    rdoActivated.Checked = true;
                    rdoUnActivated.Checked = false;
                } 
                else
                {
                    rdoActivated.Checked = false;
                    rdoUnActivated.Checked = true;
                }    
            }
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            ResetFormProduct();
        }
    }
}
