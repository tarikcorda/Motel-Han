using System.ComponentModel.DataAnnotations;

namespace eHotel.eHotel.Model;

public class JediniceMjere
{
    [Key]
    public int JedinicaMjereId { get; set; }
    public string Naziv { get; set; } = null!;
}
