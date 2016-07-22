using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace owinn.Models
{
    public class User:IdentityUser
    {

        

        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        //[Required]
        //[EmailAddress]
        //public String EmailId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        public AddressInfo Address { get; set; }

     
       



        public class AddressInfo
        {
            [Required]
            public string Street1 { get; set; }


            public string Street2 { get; set; }

            [Required]
            public string CityName { get; set; }

            [Required]
            public string StateName { get; set; }

            [Required]
            public string CountryName { get; set; }

            [Required]
            public int PIN { get; set; }

            [Required]
            [Phone]
            public string ContactNo { get; set; }
        }
    }
}
    
