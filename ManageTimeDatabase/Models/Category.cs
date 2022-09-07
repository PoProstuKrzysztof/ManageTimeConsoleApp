using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ManageTimeLibrary;

namespace ManageTimeDatabase.Models;
public class Category 
{
    [Key]
    public int Id { get; set; } = 0;
    
    [Required]
    public string? CategoryTitle { get; set; } 
    
    [Column(TypeName = "decimal(4,2)")]
    public TimeSpan TimeSpend { get; set; }

    public ICollection<Category> Categories { get; set; } = null!;

}
