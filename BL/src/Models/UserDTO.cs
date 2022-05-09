namespace DigiVisio2030.BL.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public CityDTO? City { get; set; }
    }
}
