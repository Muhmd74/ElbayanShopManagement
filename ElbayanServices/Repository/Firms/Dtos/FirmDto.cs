using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanServices.Repository.Firms.Dtos
{
   public class FirmDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LogoInvoice { get; set; }
        public string Address { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string MessageInvoice { get; set; }
        public int Mobile { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string NatureWork { get; set; }
    }
}
