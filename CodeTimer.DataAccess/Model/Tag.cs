using System.ComponentModel.DataAnnotations;

namespace CodeTimer.DataAccess.Model;

public record Tag
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    public string ColorHex { get; set; } = "#FFFFFF";

    public ICollection<Session> Sessions { get; private set; } = new List<Session>();
}
