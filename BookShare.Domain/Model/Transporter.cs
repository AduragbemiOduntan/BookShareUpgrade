﻿using BookShare.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookShare.Domain.Model
{
    public class Transporter : BaseEntity
    {
        public string TransporterId { get; set; } = Guid.NewGuid().ToString();
        public string CompanyName { get; set; }
        public DocumentType DocumentType { get; set; }
        public string LogoUrl { get; set; }
        public ICollection<Location> Locations { get; set; }
    }
}
