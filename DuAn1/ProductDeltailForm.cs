using BUS.Services;
using DAL.Models;
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
    public partial class ProductDeltailForm : Form
    {
        ProductDetailBUS productDetailBUS = new ProductDetailBUS();
        ProductBUS productBUS = new ProductBUS();
        CpuBUS cpuBUS = new CpuBUS();
        ProductColorBUS colorBUS = new ProductColorBUS();
        PromotionBUS promotionBUS = new PromotionBUS();
        AccountBUS accountBUS = new AccountBUS();
        public ProductDeltailForm()
        {
            InitializeComponent();
        }
        public bool CheckProductDetailIfExists(string idProductDetail)
        {
            if (productDetailBUS.GetProductDetailByID(idProductDetail) != null)
                return true;
            return false;
        }
        public bool CheckNullInProductDetail(params string[] strings)
        {
            foreach (string s in strings)
            {
                if (string.IsNullOrEmpty(s))
                    return true;
            }
            return false;
        }
        public string CheckIsNumberProductDetail(string storage, string price, string warrantyPeriod, string inventory)
        {
            if (int.TryParse(storage, out _))
                return "Storage phải là số nguyên";
            else if (decimal.TryParse(price, out _))
                return "Price phải là số";
            else if (int.TryParse(warrantyPeriod, out _))
                return "Warranty period phải là số nguyên";
            else if (int.TryParse(inventory, out _))
                return "Inventory phải là số nguyên";
            return null;
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            var idProduct = cbbIdProduct.SelectedValue.ToString();
            var idCpu = cbbIdCpu.SelectedValue.ToString();
            var idProductDetail = txtIdProductDetail.Text;
            var idColor = cbbIdColor.SelectedValue.ToString();
            var storage = txtStorage.Text;
            var price = txtPrice.Text;
            var idPromotion = cbbIdProduct.SelectedValue.ToString();
            var warrantyPeriod = txtWarrantyPeriod.Text;
            var inventory = txtInventory.Text;
            var imeiNumber = txtImeiNumber.Text;
            var idAccount = cbbIdAccount.SelectedValue.ToString();
            if (!CheckNullInProductDetail(idProduct, idCpu, idProductDetail, idColor, storage, price, idPromotion, warrantyPeriod, inventory, imeiNumber, idAccount))
            {
                if (CheckProductDetailIfExists(cbbIdProduct.SelectedValue.ToString()) == false)
                {
                    var check = CheckIsNumberProductDetail(storage, price, warrantyPeriod, inventory);
                    if (check == null)
                    {
                        if (productDetailBUS.AddNewProductDetail(idProduct, idProductDetail, idColor, int.Parse(storage), decimal.Parse(price), idPromotion, int.Parse(warrantyPeriod), int.Parse(inventory), idAccount))
                            MessageBox.Show("Thêm thành công");
                        else
                            MessageBox.Show("Thêm thất bại");
                    }
                    else
                        MessageBox.Show(check);
                }
                else
                    MessageBox.Show("Product detail này đã tồn tại");
            }
            else
                MessageBox.Show("Nhập đầy đủ thông tin trước khi thêm");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var idProduct = cbbIdProduct.SelectedValue.ToString();
            var idCpu = cbbIdCpu.SelectedValue.ToString();
            var idProductDetail = txtIdProductDetail.Text;
            var idColor = cbbIdColor.SelectedValue.ToString();
            var storage = txtStorage.Text;
            var price = txtPrice.Text;
            var idPromotion = cbbIdProduct.SelectedValue.ToString();
            var warrantyPeriod = txtWarrantyPeriod.Text;
            var inventory = txtInventory.Text;
            var imeiNumber = txtImeiNumber.Text;
            var idAccount = cbbIdAccount.SelectedValue.ToString();
            if (!CheckNullInProductDetail(idProduct, idCpu, idProductDetail, idColor, storage, price, idPromotion, warrantyPeriod, inventory, imeiNumber, idAccount))
            {
                if (CheckProductDetailIfExists(cbbIdProduct.SelectedValue.ToString()) == false)
                {
                    var check = CheckIsNumberProductDetail(storage, price, warrantyPeriod, inventory);
                    if (check == null)
                    {
                        if (productDetailBUS.UpdateProductDetail(idProduct, idProductDetail, idColor, int.Parse(storage), decimal.Parse(price), idPromotion, int.Parse(warrantyPeriod), int.Parse(inventory), idAccount))
                            MessageBox.Show("Sửa thành công");
                        else
                            MessageBox.Show("Sửa thất bại");
                    }
                    else
                        MessageBox.Show(check);
                }
                else
                    MessageBox.Show("Product detail này đã tồn tại");
            }
            else
                MessageBox.Show("Nhập đầy đủ thông tin trước khi sửa");
        }

        private void cbbIdProduct_TextChanged(object sender, EventArgs e)
        {
            LoadCbbWhenTextChange(cbbIdProduct, productBUS.GetAllIDProduct());
        }

        private void cbbIdCpu_TextChanged(object sender, EventArgs e)
        {
            LoadCbbWhenTextChange(cbbIdCpu, cpuBUS.GetAllIDCpu());
        }

        private void cbbIdColor_TextChanged(object sender, EventArgs e)
        {
            LoadCbbWhenTextChange(cbbIdColor, colorBUS.GetAllIdColor());
        }

        private void cbbIdPromotion_TextChanged(object sender, EventArgs e)
        {
            LoadCbbWhenTextChange(cbbIdPromotion, promotionBUS.GetAllIdPromotion());
        }

        private void cbbIdAccount_TextChanged(object sender, EventArgs e)
        {
            LoadCbbWhenTextChange(cbbIdAccount, accountBUS.GetAllIDAccount());
        }
    }
}
