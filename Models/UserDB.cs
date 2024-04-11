﻿namespace PetAdoptionProject.Models
{
    public class UserDB
    {
        public int UserID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PetType { get; set; }
        public string? PetName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? UserAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public int? AnimalID { get; set; }
    }
}

