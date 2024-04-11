namespace PetAdoptionProject.Models
{
    public class ClientDB
    {
        public int ClientID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ClientAddress { get; set; }
        public string? PetType { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? AnimalID { get; set; }

    }
}
