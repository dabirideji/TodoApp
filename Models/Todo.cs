using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApp.Models;
public class Todo
{
    [Key]
    //MAKE SURE YOU USE INT FOR THE PRIMARY KEY 
    //FOR EASY  TESTING OF THE RELATIONSHIP
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public DateTime DateIssued {get;set;}

    //THIS IS THE PART TO LINK TO ONE USER
    //A TASK CAN ONLY HAVE ONE USER

    public int UserId { get; set; }

    //the data annotation here means that the property userid above
    //is the foreign key that is used to reference this user property
    [ForeignKey("UserId")]
    public User user { get; set; }

}