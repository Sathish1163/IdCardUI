using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Idcardmvc.Models
{
    public partial class IdDetail
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage ="This Field is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Profession { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string ContactNumber { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Website { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Location { get; set; }
    }
}
