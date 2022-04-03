using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CollectCoinsEF
{
    public class Coin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Type { get; set; }
        public string? Year { get; set; }
        public string? Matherial { get; set; }
        public string? Desc { get; set; }
        public string? Diametr { get; set; } 
        public string? Country { get; set; }
        public string? State { get; set; }         // Состояние
        public double? Circulation { get; set; }  // Тираж
        public string? Bitkin { get; set; }         // Номер по каталогу Биткина

    }

    public class CoinsPhoto
    {
        public string? NamePhoto { get; set; }
        public int Id { get; set; } 
        public int CoinsId { get; set; }
        public Coin? Coin { get; set; }
        public byte[]? Photo { get; set; }
    }

    public class AppContext: DbContext
    {
        public DbSet<Coin> Coins => Set<Coin>();
        public DbSet<CoinsPhoto> CoinsPhoto => Set<CoinsPhoto>();
        public string connectionString;

        public AppContext(string connectionString)
        {
            this.connectionString = connectionString;   // получаем извне строку подключения
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
