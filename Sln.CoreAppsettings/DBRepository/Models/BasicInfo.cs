using System;

namespace DBRepository.Models
{
    public class BasicInfo
    {
        public long BasicInfoID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string MobileNo { get; set; }
        public string NID { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
    }
}
