using System.ComponentModel.DataAnnotations;

namespace Domain.Entities {
  public class User {
    public User(Guid id, string name, string email){
      Id = id;
      Name = name;
      Email = email;
    }

    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;
  }
}