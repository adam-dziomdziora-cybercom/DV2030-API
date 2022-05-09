namespace DigiVisio2030.DA.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; }
        public int? CityId { get; set; }
    }
}
