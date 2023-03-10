using System.ComponentModel.DataAnnotations;

namespace WEB_MVC.Models;

public class Phone
{
    [Key]
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Image { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DataType _Data { get; set; }
    public string Color { get; set; }
    public int Price { get; set; }
    public string Category { get; set; }
}