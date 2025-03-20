using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinansYonetimi.Model
{
    public class Billing
    {
        [Key]
        public int No { get; set; }
        [Required]
        public string Banka { get; set; } = string.Empty;
        [Required]
        public decimal Miktar { get; set; }
        [Required]
        public string ParaBirimi { get; set; } = "TL";
        public DateTime? KesimTarihi { get; set; }
        public string? Aciklama { get; set; }
    }
}
