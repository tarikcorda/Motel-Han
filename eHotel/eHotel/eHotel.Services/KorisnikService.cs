using eHotel.eHotel.Model;
using eHotel.eHotel.Services.Database;

namespace eHotel.eHotel.Services;

public class KorisnikService : IKorisnikService
{
    public eHotelContext _context { get; set; }

    public KorisnikService(eHotelContext context)
    {
        _context = context;
    }

    public List<Korisnici> Get()
    {
        return _context.Korisnici.ToList();
    }
}
