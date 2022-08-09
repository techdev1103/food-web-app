global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;

namespace Foody.Entities.Models;

public abstract class BaseEntity
{
    [Key]
    [Column(Order = 0)]
    public int Id { get; set; }

    [ScaffoldColumn(false)]
    public int Status { get; set; } = 1;

    [ScaffoldColumn(false)]
    public DateTime AddedOn { get; set; } = DateTime.UtcNow;

    [ScaffoldColumn(false)]
    public DateTime Updated { get; set; }
}