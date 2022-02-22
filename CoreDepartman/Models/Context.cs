using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartman.Models
{
    //tanımladığım tüm sınıfları dabase'e göndermek için buraya eklememiz lazım
    //dbcontext ti miraslama olarak almammız lazım
    //using Microsoft.EntityFrameworkCore; kullanmamız lazım
    public class Context:DbContext
    {
        /*
         add-migration = yeni migration eklemek için kullanılır tablo üzeride değişiklik yapıldığında yeni migration eklemeden update yapılmaz
        update-database = tablo üzerinde yapılan düzenlemeleri yeni migration ' a göndermek için kullanılır
         
         
         
         */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-IN1QIJK\\SQLEXPRESS; database=corepersonel; integrated security=true;");
        }
        public DbSet<Departman> departman { get; set; }
        public DbSet<Personel> personel { get; set; }
    }
}
