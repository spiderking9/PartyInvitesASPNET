using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="prosze podac imie i nazwisko")]
        public string Name { get; set; }
        [Required(ErrorMessage = "prosze podac email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage ="prosze podac prawidłowy adres email")]

        public string Email { get; set; }
        [Required(ErrorMessage = "prosze podac nr tel")]

        public string Phone { get; set; }
        [Required(ErrorMessage = "prosze okreslic czy wezmiesz udzial")]

        public bool? WillAttend { get; set; }
    }
}
