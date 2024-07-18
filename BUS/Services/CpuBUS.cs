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
        CpuDAL cpuDAL = new CpuDAL();
        public List<Cpu> GetAllCPU() 
        {
            return cpuDAL.GetAllCPU();
        }
        public List<string> GetAllIDCpu()
        {
            var listCpu= GetAllCPU();
            var listIDCpu= new List<string>();
            foreach (var cpu in listCpu)
            {
                listIDCpu.Add(cpu.Idcpu);
            }
            return listIDCpu;
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
            if(cpuDAL.AddNewCPU(current))
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
            if (cpuDAL.UpdateCPU(current))
                return true;
            else
                return false;
        }
    }
}
