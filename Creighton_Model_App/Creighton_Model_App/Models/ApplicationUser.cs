using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace Creighton_Model_App.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(55, ErrorMessage = "Please enter your nickname")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(55, ErrorMessage = "Sorry, too long")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Address")]
        [StringLength(55, ErrorMessage = "Please enter your street, city, state and zip")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Doctor Name")]
        [StringLength(55, ErrorMessage = "Please enter your Doctor's name")]
        public string DoctorName { get; set; }

        public virtual ICollection<ChartEntry> ChartEntries { get; set; }
    }
}
