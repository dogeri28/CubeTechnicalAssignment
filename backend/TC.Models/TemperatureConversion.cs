using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TC.Models;

[Table(name: "TemperatureConversions")]
public class TemperatureConversion
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public decimal? TemperatureValueFrom { get; set; }

    public decimal? TemperatureValueTo { get; set; }

    public TemperatureType TemperatureTypeFrom { get; set; }

    public TemperatureType TemperatureTypeTo { get; set; }

    public DateTime TimeStamp { get; set; }
}
