using System.ComponentModel.DataAnnotations;

namespace WEB_MVC.Models;

public class Person
{
    [Key] 
    public int Id { get; set; }
    public string ProfilePicture { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Nationality { get; set; }
}