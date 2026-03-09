using System.ComponentModel.DataAnnotations;

namespace OrganizeApi.Models;

public class ToDo
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    public bool IsCompleted { get; set; }
}