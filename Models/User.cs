using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models;
public class User
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password {get;set;}


    //THIS IS THE PART TO LINK TO MANY TODO
    //ONE USER CAN HAVE MANY TASKS 
    public List<Todo> Todos{get;set;}
    
}