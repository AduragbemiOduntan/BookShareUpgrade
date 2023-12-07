using BookShare.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookShare.Domain.Model
{
    public class KYC
    {
        public string KycId { get; set; } = Guid.NewGuid().ToString();
        public DocumentType DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string DateIssued { get; set; }
        public string ExpiryDate { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
