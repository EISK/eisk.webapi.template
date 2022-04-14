using System.ComponentModel.DataAnnotations;

namespace Eisk.Domains.ValueObjects
{
    public class Address
    {
        [StringLength(60)]
        [Required(ErrorMessage = "Address line required.")]
        [Display(Name = "Address line")]
        public string AddressLine { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        [StringLength(50)]
        [RegularExpression("\\d{1,50}", ErrorMessage = "Not a valid postal code. Please consider upto 10 digit for valid postal format.")]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Country required.")]
        [StringLength(50)]
        public string Country { get; set; }
                
    }
}