using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class OrderService
    {   
        OrderRepos repos = new OrderRepos();
        public OrderService()
        {
            
        }
        public List<Order> ChucNangShow()
        {
            return repos.GetAll();
        }
        //Tìm 
        public List<Order> CNTimTheoIdOrder(string idorder)
        {
            return repos.GetByIdOrder(idorder);
        }
        public List<Order> CNTimTheoIdAccount(string idaccount)
        {
            return repos.GetByIdAccount(idaccount);
        }
        public List<Order> CNTimTheoIdCustom(string idcustom)
        {
            return repos.GetByIdCustom(idcustom);
        }
        public List<Order> CNTimTheoEstablishedDate(DateTime fromdate, DateTime todate)
        {
            return repos.GetByEstablishedDate(fromdate, todate);
        }
        //Thêm
        public string ChucNangThem(string idorder, string idaccount, string idcustomer, DateTime establishedDate, decimal totalamount, string idvoucher, bool paid)
        {
            Order order = new Order()
            {
                Idorder = idorder,
                Idaccount = idaccount,
                Idcustomer = idcustomer,
                EstablishedDate = establishedDate,
                TotalAmount = totalamount,
                Idvorcher = idvoucher,
                Paid = paid
            };
            if (repos.AddOrder(order))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        //Sửa
        public string ChucNangSua(string idorder, string idaccount, string idcustomer, DateTime establishedDate, decimal totalamount, string idvoucher, bool paid)
        {
            Order order = new Order()
            {
                Idorder = idorder,
                Idaccount = idaccount,
                Idcustomer = idcustomer,
                EstablishedDate = establishedDate,
                TotalAmount = totalamount,
                Idvorcher = idvoucher,
                Paid = paid
            };
            if (repos.UpdateOrder(order))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
        //Xóa
        public string ChucNangXoa(string idorder)
        {
            if (repos.DeleteOrder(idorder))
            {
                return "Xóa thành công";
            }
            else return "Xóa thất bại";
        }
    }
}
