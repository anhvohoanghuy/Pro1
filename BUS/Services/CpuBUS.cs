using DAL.Models;
using DAL.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class CpuBUS
    {
        CpuDAL CpuDAL = new CpuDAL();
        public List<Cpu> GetAllCPU() 
        {
            return CpuDAL.GetAllCPU();
        }
        public bool AddNewCPU(string idCpu, string nameCpu, string manufacturer,string idAccount)
        {
            Cpu current = new Cpu()
            {
                Idcpu = idCpu,
                NameCpu = nameCpu,
                Manufacturer = manufacturer,
                Idaccount = idAccount
            };
            if(CpuDAL.AddNewCPU(current))
                return true;
            else
                return false;
        }
        public bool UpdateCPU(string idCpu, string nameCpu, string manufacturer, string idAccount)
        {
            Cpu current = new Cpu()
            {
                Idcpu = idCpu,
                NameCpu = nameCpu,
                Manufacturer = manufacturer,
                Idaccount = idAccount
            };
            if (CpuDAL.UpdateCPU(current))
                return true;
            else
                return false;
        }
    }
}
