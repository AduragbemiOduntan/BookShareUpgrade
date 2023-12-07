using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Common.Dto.Request
{
    public class BookDto
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }
        public string BookCategory { get; set; }
        public string IsAvailable { get; set; }
        public string ImageUrl { get; set; }
        public string Quantity { get; set; }
    }
}
