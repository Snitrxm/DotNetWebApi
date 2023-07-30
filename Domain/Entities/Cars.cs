using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities {
  public class Car {
    public Car(Guid id, string model, string brand, Guid userId){
      Id = id;
      Model = model;
      Brand = brand;  
      UserId = userId;
    }

    [Key]
    public Guid Id { get; set; }

    public string Model { get; set; } = string.Empty;

    public string Brand { get; set; } = string.Empty;

    public Guid UserId { get; set; }

    [ForeignKey("UserId")]  
    public User User { get; set; }
  }
}