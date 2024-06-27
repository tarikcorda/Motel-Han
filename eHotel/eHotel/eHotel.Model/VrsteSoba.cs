using System.ComponentModel.DataAnnotations;

namespace eHotel.eHotel.Model;

public class VrsteSoba
{
    [Key]
    public int VrstaId { get; set; }
    public string Naziv { get; set; } = null!;
}
