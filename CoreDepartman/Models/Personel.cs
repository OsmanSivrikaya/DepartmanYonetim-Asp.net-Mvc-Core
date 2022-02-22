using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartman.Models
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public string PerAd { get; set; }
        public string PerSoyad { get; set; }
        public string PerSehir { get; set; }
        public int DepartmanID { get; set; }
        public Departman Departman { get; set; }
    }
}
