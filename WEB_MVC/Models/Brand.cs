using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB_MVC.Models;

public class Brand
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    [ForeignKey("_Concerns")] public int ConcernId { get; set; }
    public Concerns _Concern { get; set; }
    
    public List<Phone> Phones { get; set; }
}