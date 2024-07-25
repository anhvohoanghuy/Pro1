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
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
    public partial class CreateOrderForm : Form
    {
        
        private Order selectedOrder;
        private List<Order> orderQueue = new List<Order>();

        public CreateOrderForm()
        {

                                                                                                                                                                                                                                                                                                                                                                                                                InitializeComponent(); this.WindowState = FormWindowState.Maximized; this.FormBorderStyle = FormBorderStyle.None; 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btninfoOrder_Click(object sender, EventArgs e)
        {
            ChiTietDonHangForm a = new ChiTietDonHangForm();
            a.ShowDialog();
        }

        private void btnAddToOrderQueue_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order()
            {
                OrderId = txtId.Text,
                CustomerId = txtIdcus.Text,
                CustomerName = txtName.Text,
                PhoneNumber = txtphone.Text,
                Address = txtaddres.Text,
                Date = DateTime.Now // or parse from the form control
            };

            orderQueue.Add(newOrder);
            AddOrderToComboBox(newOrder);
            cmbOrderQueue.SelectedIndex = cmbOrderQueue.Items.Count - 1;
            MessageBox.Show("Thông tin đơn hàng đã được cập nhật.");

        }


        private void AddOrderToComboBox(Order order)
        {
            cmbOrderQueue.Items.Add(new ComboBoxItem
            {
                Text = $"{order.OrderId} - {order.CustomerName}",
                Value = order
            });
        }


        private void ShowOrderDetails(Order order)
        {
            // Hiển thị thông tin đơn hàng chi tiết
            txtId.Text = order.OrderId;
            txtIdcus.Text = order.CustomerId;
            txtName.Text = order.CustomerName;
            txtphone.Text = order.PhoneNumber;
            txtaddres.Text = order.Address;
            // Hiển thị các thông tin khác nếu cần
        }



        private void cmbOrderQueue_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            if (cmb != null && cmb.SelectedItem != null)
            {
                ComboBoxItem selectedItem = cmb.SelectedItem as ComboBoxItem;
                if (selectedItem != null)
                {
                    selectedOrder = selectedItem.Value as Order;
                    if (selectedOrder != null)
                    {
                        ShowOrderDetails(selectedOrder);
                    }
                }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (selectedOrder != null)
            {
                // Cập nhật thông tin đơn hàng từ các control
                selectedOrder.OrderId = txtId.Text;
                selectedOrder.CustomerId = txtIdcus.Text;
                selectedOrder.CustomerName = txtName.Text;
                selectedOrder.PhoneNumber = txtphone.Text;
                selectedOrder.Address = txtaddres.Text;
                // Cập nhật các thông tin khác nếu cần

                // Cập nhật lại text hiển thị của mục trong ComboBox
                int selectedIndex = cmbOrderQueue.SelectedIndex;
                cmbOrderQueue.Items[selectedIndex] = new ComboBoxItem
                {
                    Text = $"{selectedOrder.OrderId} - {selectedOrder.CustomerName}",
                    Value = selectedOrder
                };

                MessageBox.Show("Thông tin đơn hàng đã được cập nhật.");
            }
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            if (cmbOrderQueue.SelectedIndex != -1)
            {
                // Lấy chỉ mục được chọn
                int selectedIndex = cmbOrderQueue.SelectedIndex;

                // Xóa mục được chọn khỏi ComboBox
                cmbOrderQueue.Items.RemoveAt(selectedIndex);

                // Xóa đơn hàng tương ứng khỏi danh sách orderQueue
                orderQueue.RemoveAt(selectedIndex);



                // Hiển thị thông báo
                MessageBox.Show("Đơn hàng được chọn đã được tạo.");
            }
            else
            {
                // Nếu không có mục nào được chọn, hiển thị thông báo
                MessageBox.Show("Không có đơn hàng nào được chọn để xóa.");
            }

        }

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
