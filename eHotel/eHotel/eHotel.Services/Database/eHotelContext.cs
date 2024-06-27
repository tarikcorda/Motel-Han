using eHotel.eHotel.Model;
using Microsoft.EntityFrameworkCore;

namespace eHotel.eHotel.Services.Database;

public partial class eHotelContext : DbContext
{
    public eHotelContext()
    {
    }
    public eHotelContext(DbContextOptions<eHotelContext> options) : base(options)
    {
    }
    public DbSet<JediniceMjere> JediniceMjere { get; set; }
    public DbSet<Korisnici> Korisnici { get; set; }
    public DbSet<KorisniciUloge> KorisniciUloge { get; set; }
    public DbSet<Sobe> Sobe { get; set; }
    public DbSet<Uloge> Uloge { get; set; }
    public DbSet<VrsteSoba> VrsteSoba { get; set; }
}
