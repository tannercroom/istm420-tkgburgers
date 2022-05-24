using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team2.Models
{
    public class Checkout
    {
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Street Address is required.")]
        public string Street { get; set; }

        //Optional Field for Apt/Suite
        public string Apt { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required.")]
        [StringLength(2), MinLength(2)]
        public string State { get; set; }

        [Required(ErrorMessage = "ZIP Code is Invalid.")]
        [Range(10001, 99999, ErrorMessage = "ZIP Code is Invalid.")]
        public int? ZIP { get; set; }

        [Required(ErrorMessage = "Phone Number is Invalid.")]
        [Range(0, 9999999999, ErrorMessage = "Phone Number is Invalid.")]
        public long? Phone { get; set; }

        [Required(ErrorMessage = "An E-Mail Address is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please select a Payment Type.")]
        public string PaymentType { get; set; }

        [Required(ErrorMessage = "A Cardholder Name is required.")]
        public string CardholderName { get; set; }

        [Required(ErrorMessage = "Card Number is Invalid.")]
        [Range(0, 9999999999999999, ErrorMessage = "Card Number is Invalid.")]
        public long? CardNumber { get; set; }

        [Required(ErrorMessage = "CVV is Invalid.")]
        [Range(100, 9999, ErrorMessage = "CVV is Invalid.")]
        public int? CVV { get; set; }

        [Required(ErrorMessage = "Expiration Date is Invalid.")]
        [DisplayFormat(DataFormatString = "{0:MM/yyyy}")]
        public DateTime? ExpirationDate { get; set; }

    }
}
