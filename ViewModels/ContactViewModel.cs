using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace DutchTreat.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(5)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [MinLength(95, ErrorMessage = "Moc KRATKEEEY MESSAGEE")]
        public string Message { get; set; }
    }
}

