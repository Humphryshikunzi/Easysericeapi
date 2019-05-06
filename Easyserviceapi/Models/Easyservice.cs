using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Easyserviceapi.Models
{
    public class Easyservice
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FullName { get; set; }
        public int NationalId { get; set; }
        public long PhoneNumber { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Profession { get; set; }
        public string ProfilePicture { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Location { get; set; }
        public string MoreBio { get; set; }
        public string Comments { get; set; }
        public string UserName  { get; set; }
        public string Password { get; set; }

    }
}