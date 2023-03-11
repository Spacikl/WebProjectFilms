using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WEB_MVC.Data.Enums.Category;
using WEB_MVC.Data.Enums.Color;

namespace WEB_MVC.Models;

public class Phone
{
    [Key]
    public int Id { get; set; }
    
    [ForeignKey("BrandId")]
    public int BrandId { get; set; }
    
    public Brand _Brand { get; set; }
    public string Image { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DataType _Data { get; set; }
    public Color _Color { get; set; }
    public int Price { get; set; }
    public Category _Category { get; set; }
}