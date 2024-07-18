using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respositories
{
    public class ProductCompanyDAL
    {
        Pro1QuanLiDienThoaiFinalContext db = new Pro1QuanLiDienThoaiFinalContext();
        public List<ProductCompany> GetAllCompany()
        {
            return db.ProductCompanys.ToList();
        }
        public bool AddNewCompany(ProductCompany company)
        {
            try
            {
                db.ProductCompanys.Add(company);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateCompany(ProductCompany company)
        {
            try
            {
                var current = GetAllCompany().FirstOrDefault(c => c.Idcompany == company.Idcompany);
                current.Idcompany = company.Idcompany;
                current.CompanyName = company.CompanyName;
                current.Idaccount = company.Idaccount;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
