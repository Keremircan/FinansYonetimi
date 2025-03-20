using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinansYonetimi.Model;
using Microsoft.EntityFrameworkCore;

namespace FinansYonetimi.Dal
{
    internal class PayableDal
    {
        public List<Payable> GetAll()
        {
            using (var _context = new FYContext())
            {
                return _context.Payables.ToList();
            }
        }
        public List<Payable> GetByName(string key)
        {
            using (var _context = new FYContext())
            {
                return _context.Payables.Where(r => r.Isim.Contains(key)).ToList();
            }
        }
        public void Add(Payable payable)
        {
            using (var _context = new FYContext())
            {
                _context.Payables.Add(payable);
                _context.SaveChanges();
            }
        }
        public void Update(Payable payable)
        {
            using (var _context = new FYContext())
            {
                var entity = _context.Entry(payable);
                entity.State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
        public void Delete(Payable payable)
        {
            using (var _context = new FYContext())
            {
                var entity = _context.Entry(payable);
                entity.State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }
    }
}
