using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinansYonetimi
{
    internal class ReceivableDal
    {
        public List<Receivable> GetAll() 
        {
            using (var _context = new FYContext()) {
                return _context.Receivables.ToList();
            }
        } 
        public void Add(Receivable receivable)
        {
            using (var _context = new FYContext())
            {
                _context.Receivables.Add(receivable);
                _context.SaveChanges();
            }
        }
    }
}
