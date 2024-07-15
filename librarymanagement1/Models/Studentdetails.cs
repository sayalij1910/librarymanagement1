using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace librarymanagement1.Models
{
    public class Studentdetails
    {
        public int SrNo { get; set; }
        public int AddmissionNo { get; set; }
        public Nullable<int> RollNo { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string FName { get; set; }
        public string Remarks { get; set; }
        public Nullable<long> FMobile { get; set; }


    }
}