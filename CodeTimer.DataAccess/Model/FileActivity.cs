using System.ComponentModel.DataAnnotations;

namespace CodeTimer.DataAccess.Model;

public record FileActivity
{
    [Key]
    public int Id { get; set; }
    public string FileName { get; set; } = string.Empty;
    public DateTime OpenedDateTime { get; set; }
    public DateTime? ClosedDateTime { get; set; }
    public int LinesAdded { get; set; }
    public int LinesRemoved { get; set; }
    public int LinesAltered { get; set; }
}
