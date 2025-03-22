namespace CarLibraryAPI.Models.Adverstiments;

public class Adverstiment
{
	public int Id { get; set; }
	public decimal Price { get; set; }
	public List<string> Images { get; set; }
	public Car Car { get; set; }
	public Seller Seller { get; set; }
	public string Location { get; set; }
    public string Description { get; set; }
    public string ShortDescription { get; set; }
	public int Likes { get; set; }
}