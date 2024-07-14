using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class OrderRepos
    {
        Pro1QuanLiDienThoaiFinalContext context = new Pro1QuanLiDienThoaiFinalContext();
        public OrderRepos()
        {
            
        }
        //Lấy danh sách order
        public List<Order> GetAll()
        {
            return context.Orders.ToList();
        }
        public List<Order> GetOrder(string id)
        {
            return context.Orders.Where(o => o.Idorder == id).ToList();
        }
        //Thêm order
        public bool AddOrder(Order order)
        {
            try
            {
                context.Orders.Add(order);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //Sửa Order
        public bool UpdateOrder(Order order)
        {
            try
            {
                var updateitem = context.Orders.Find(order.Idorder);
                updateitem.Idorder = order.Idorder;
                updateitem.Idaccount = order.Idaccount;
                updateitem.Idcustomer = order.Idcustomer;
                updateitem.EstablishedDate = order.EstablishedDate;
                updateitem.TotalAmount = order.TotalAmount;
                updateitem.Idvorcher = order.Idvorcher;
                updateitem.Paid = order.Paid;
                context.Orders.Update(updateitem);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DeleteOrder(string idorder)
        {
            try
            {
                var deleteitem = context.Orders.Find(idorder);
                
                context.Orders.Remove(deleteitem);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
