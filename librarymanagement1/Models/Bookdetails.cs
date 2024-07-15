using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace librarymanagement1.Models
{
    public class Bookdetails
    {
        public int AccessionNo { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }
        public string Publisher { get; set; }
    }
}