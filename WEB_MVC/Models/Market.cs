using System.ComponentModel.DataAnnotations;

namespace WEB_MVC.Models;

public class Market
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}