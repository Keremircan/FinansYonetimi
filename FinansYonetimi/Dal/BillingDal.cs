using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinansYonetimi.Model;
using Microsoft.EntityFrameworkCore;

namespace FinansYonetimi.Dal
{
    internal class BillingDal
    {
        public List<Billing> GetAll()
        {
            using (var _context = new FYContext())
            {
                return _context.Billings.ToList();
            }
        }
        public List<Billing> GetByName(string key)
        {
            using (var _context = new FYContext())
            {
                return _context.Billings.Where(r => r.Banka.Contains(key)).ToList();
            }
        }
        public void Add(Billing billing)
        {
            using (var _context = new FYContext())
            {
                _context.Billings.Add(billing);
                _context.SaveChanges();
            }
        }
        public void Update(Billing billing)
        {
            using (var _context = new FYContext())
            {
                var entity = _context.Entry(billing);
                entity.State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
        public void Delete(Billing billing)
        {
            using (var _context = new FYContext())
            {
                var entity = _context.Entry(billing);
                entity.State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }
    }
}
