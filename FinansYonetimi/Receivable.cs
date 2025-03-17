using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinansYonetimi
{
    public class Receivable
    {
        [Key]
        public int RID { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime? Date { get; set; }
        public string? Description { get; set; }
    }
}
