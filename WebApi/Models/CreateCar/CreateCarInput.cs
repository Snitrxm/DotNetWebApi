namespace WebApi.Models.CreateCar {
  public class CreateCarInput {
    public string Model { get; set; } = string.Empty;

    public string Brand { get; set; } = string.Empty;

    public Guid UserId { get; set; }
  }
}