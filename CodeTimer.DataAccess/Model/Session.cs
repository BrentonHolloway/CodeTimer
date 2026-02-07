using System.ComponentModel.DataAnnotations;

namespace CodeTimer.DataAccess.Model;

public record Session
{
    [Key]
    public int Id { get; set; }

    [MaxLength(256)]
    public string TaskName { get; set; } = string.Empty;
    public DateTime StartDateTime { get; set; }
    public DateTime? EndDateTime { get; set; }
    public ICollection<SessionActivity> Activity { get; private set; } = [];
    public ICollection<Tag> Tags { get; private set; } = [];
    public ICollection<FileActivity> FileActivity { get; private set; } = [];
}
