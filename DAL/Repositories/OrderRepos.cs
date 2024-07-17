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
        //Tìm theo idorder
        public List<Order> GetByIdOrder(string idorder)
        {
            return context.Orders.Where(o => o.Idorder == idorder).ToList();
        }
        //Tìm theo idAccount
        public List<Order> GetByIdAccount(string idaccount)
        {
            return context.Orders.Where(p=>p.Idaccount == idaccount).ToList();
        }
        //Tìm theo idCustom
        public List<Order> GetByIdCustom(string idcustom)
        {
            return context.Orders.Where(p => p.Idcustomer == idcustom).ToList();
        }
        //Tìm theo EstablishedDate
        public List<Order> GetByEstablishedDate(DateTime fromdate, DateTime todate)
        {
            return context.Orders.Where(p => p.EstablishedDate >= fromdate&&p.EstablishedDate<=todate).ToList();
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
