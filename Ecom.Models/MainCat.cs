
using System.ComponentModel.DataAnnotations;

namespace Ecom.Models; 
public class MainCat
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
}
