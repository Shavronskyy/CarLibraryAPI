namespace CarLibraryAPI.Models.Adverstiments;

public class Adverstiment
{
	public int Id { get; set; }
	public decimal Price { get; set; }
	public List<string> Images { get; set; }
	public Car Car { get; set; }
}