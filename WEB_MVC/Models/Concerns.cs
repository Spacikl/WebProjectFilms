using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB_MVC.Models;

public class Concerns
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    [ForeignKey("BrandId")]
    public int BrandId { get; set; }
    public List<Brand> Brands { get; set; }
}