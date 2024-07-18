using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respositories
{
    public class CpuDAL
    {
        Pro1QuanLiDienThoaiFinalContext db = new Pro1QuanLiDienThoaiFinalContext();
        public List<Cpu> GetAllCPU()
        {
            return db.Cpus.ToList();
        }
        public bool AddNewCPU(Cpu cpu)
        {
            try
            {
                db.Cpus.Add(cpu);
                return true;
            }
            catch { return false; }
        }
        public bool UpdateCPU(Cpu cpu)
        {
            try
            {
                var current= GetAllCPU().FirstOrDefault(c=>c.Idcpu==cpu.Idcpu);
                if (current != null)
                {
                    current.NameCpu=cpu.NameCpu;
                    current.Idcpu = cpu.Manufacturer;
                    current.Idaccount = cpu.Idaccount;
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch
            { return false; }
        }
    }
}
