using librarymanagement1.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.SqlClient;
using System.Configuration;


namespace librarymanagement1.Controllers
{
    public class IssueBookController : Controller
    {
        // GET: IssueBook
       
    
        public ActionResult Issuebook(ViewModel model)
        {
            /*List<Bookdetails> listOfBookdetails = new List<Bookdetails>();
            listOfBookdetails.Add(new Bookdetails() { AccessionNo = 1, Author = "ABC", Subject = "ABC", Publisher = "ABC" });
            listOfBookdetails.Add(new Bookdetails() { AccessionNo = 2, Author = "ABC", Subject = "ABC", Publisher = "ABC" });
            listOfBookdetails.Add(new Bookdetails() { AccessionNo = 3, Author = "ABC", Subject = "ABC", Publisher = "ABC" });
            listOfBookdetails.Add(new Bookdetails() { AccessionNo = 4, Author = "ABC", Subject = "ABC", Publisher = "ABC" });

         
            List<Studentdetails> listOfStudenttails = new List<Studentdetails>();
            listOfStudenttails.Add(new Studentdetails() { AddmissionNo = 1, Name = "shyam", FName = "tarak mehta", FMobile = 3434343434 });
            listOfStudenttails.Add(new Studentdetails() { AddmissionNo = 2, Name = "shyama", FName = "tarak shah", FMobile = 3434355434 });
            ViewModel objViewModel = new ViewModel();
           // objViewModel.BookdetailsViewModel = listOfBookdetails;
           // objViewModel.StudentdetailsViewModel = listOfStudenttails;*/


            // Assuming ViewModel has properties like AddmissionNoFilter and AccessionNoFilter

            // Implement filtering logic based on model.AddmissionNoFilter and model.AccessionNoFilter
            // Example:


            // Pass filteredResults to view or perform further actions as needed

            return View();  
        }
        public ActionResult Receivebook()
        {

            return View();
        }
        public ActionResult IssueR̥egister()
        {
            return View();
        }
        public ActionResult ReceiveR̥egister()
        {
            List<ViewModel> receiveRegister = new List<ViewModel>
            {
                new  ViewModel
                {
                      Date = DateTime.Today,
                    SrNo = 1,
                    AddmissionNo = 7,
                    AccessionNo = 5,
                    Name = "John Doe",
                    RollNo = 3,
                    Title = "Sample Book",
                    Author = "Jane Smith",
                    Subject = "Science",
                    Publisher = "Publisher ABC",
                    Edition = "1st",
                    Cost = 25,
                    Class = "Class A",
                    Section = "Section 1"
                },
                 new ViewModel
                {
                    Date = DateTime.Today.AddDays(-1),
                    SrNo = 2,
                    AddmissionNo = 3,
                    AccessionNo = 1,
                    Name = "Jane Doe",
                    RollNo = 3,
                    Title = "Another Book",
                    Author = "John Smith",
                    Subject = "History",
                    Publisher = "Publisher XYZ",
                    Edition = "2nd",
                    Cost = 30,
                    Class = "Class B",
                    Section = "Section 2"
                 }

                };

                
            return View(receiveRegister);
        }
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult BookLedger()
        {
            // List<ViewModel> model = List<ViewModel>;

            //return View();

            List<ViewModel> bookLedger = new List<ViewModel>
        {
            new ViewModel
            {
                SrNo = 1,
                Author = "John Doe",
                Title = "Sample Book",
                AccessionNo = 99,
                Date = DateTime.Now,
                Cost = 10,
                Remarks = "Returned"
                // Populate other properties as needed
            },
            new ViewModel
            {
                SrNo = 2,
                Author = "Jane Smith",
                Title = "Another Book",
                AccessionNo = 67,
                Date = DateTime.Now.AddDays(-7),
                Cost = 8,
                Remarks = "Not Returned"
                // Populate other properties as needed
            }
            // Add more ViewModel objects as needed
        };

            return View(bookLedger);
        }

    }
}