namespace CarLibraryAPI.Models.Adverstiments
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<string> Socials { get; set; }
    }
}
