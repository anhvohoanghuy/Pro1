using DAL.Models;
using DAL.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ProductCompanyBUS
    {
        ProductCompanyDAL productCompanyDAL=new ProductCompanyDAL();
        public List<ProductCompany> GetAllCompany()
        {
            return productCompanyDAL.GetAllCompany();
        }
        public List<string> GetAllIDCompany()
        {
            var listCompany=GetAllCompany();
            var listIDCompany= new List<string>();
            foreach (var company in listCompany) 
            {
                listIDCompany.Add(company.Idcompany);
            }
            return listIDCompany;
        }
        public ProductCompany GetCompanyById(string id) 
        {
            return productCompanyDAL.GetAllCompany().FirstOrDefault(x => x.Idcompany == id);
        }
        public bool AddNewCompany(string idCompany, string companyName, string idAccount)
        {
            ProductCompany productCompany = new ProductCompany()
            {
                Idcompany = idCompany,
                CompanyName = companyName,
                Idaccount = idAccount
            };
            if(productCompanyDAL.AddNewCompany(productCompany))
                return true;
            return false;
        }
        public bool UpdateCompany(string idCompany, string companyName, string idAccount)
        {
            ProductCompany productCompany = new ProductCompany()
            {
                Idcompany = idCompany,
                CompanyName = companyName,
                Idaccount = idAccount
            };
            if (productCompanyDAL.UpdateCompany(productCompany))
                return true;
            return false;
        }
    }
}
