using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace librarymanagement1.Models
{
    public class ViewModel
    {
        // public IEnumerable<Bookdetails> BookdetailsViewModel { get; set; }
        // public IEnumerable<Studentdetails> StudentdetailsViewModel { get; set; }
        public int AccessionNo { get; set; }
        public Nullable<int> BarcodeID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }
        public string Publisher { get; set; }
        public int AdmissionNo { get; set; }
        public string StudentName { get; set; }
        public string Class { get; set; }
        public Nullable<System.DateTime> WithdrawlNo_Date { get; set; }
        
        public Nullable<System.DateTime> Date { get; set; }
        public string Name { get; set; }
        public int AddmissionNo { get; set; }
        public Nullable<int> RollNo { get; set; }
        public string FName { get; set; }
        public Nullable<long> FMobile { get; set; }
        public int SrNo { get; set; }
        public string Remarks { get; set; }
        public Nullable<long> Cost { get; set; }
        public string Edition { get; set; }
        public string Section { get; set; }
        public string AddmissionNoFilter { get; set; }
        public string AccessionNoFilter { get; set; }

    }
}