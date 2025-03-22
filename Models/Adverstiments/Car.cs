using CarLibraryAPI.Enums.Car;

namespace CarLibraryAPI.Models.Adverstiments;

public class Car
{
	public int Id { get; set; }
	public CarModel ModelName { get; set; }
	public CarBrand BrandName { get; set; }
	public string? Year { get; set; }
	public int Mileage { get; set; }
	public string? Color { get; set; }
	public LightsType Lights { get; set; }
	public FuelType Fuel { get; set; }
	public string? Engine { get; set; }
	public TransmisionType Transmission { get; set; }
	public WheelType Wheel { get; set; }
}