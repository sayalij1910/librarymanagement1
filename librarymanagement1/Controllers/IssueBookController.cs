using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using librarymanagement1.Models;

namespace librarymanagement1.Controllers
{
    public class IssueBookController : Controller
    {
        // GET: IssueBook
        //public ActionResult Index()
        //{
        //    return View();
        //}


        // GET: IssueBook

        private library_mangEntities1 db = new library_mangEntities1();

        public ActionResult Issuebook(ViewModel viewModel)
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


            if (!string.IsNullOrEmpty(viewModel.AdmissionNoFilter) && !string.IsNullOrEmpty(viewModel.AccessionNoFilter))
            {
                //    var student = db.Students.FirstOrDefault(s => s.AddmissionNo == viewModel.AddmissionNoFilter);
                //    var book = db.Books.FirstOrDefault(b => b.AccessionNo == viewModel.AccessionNoFilter);

                //    if (student != null && book != null)
                //    {
                //        viewModel.Name = student.Name;
                //        viewModel.Class = student.Class;
                //        viewModel.RollNo = student.RollNo;
                //        viewModel.FName = student.FName;
                //        viewModel.FMobile = student.FMobile;
                //        viewModel.Title = book.Title;
                //        viewModel.Author = book.Author;
                //        viewModel.Subject = book.Subject;
                //        viewModel.Publisher = book.Publisher;
                //    }
                //}

                int admissionNo;
                int accessionNo;

                // Try to parse the AddmissionNoFilter and AccessionNoFilter to integers
                if (int.TryParse(viewModel.AdmissionNoFilter, out admissionNo) && int.TryParse(viewModel.AccessionNoFilter, out accessionNo))
                {
                    var student = db.Students.FirstOrDefault(s => s.AdmissionNo == admissionNo);
                    var book = db.Books.FirstOrDefault(b => b.AccessionNo == accessionNo);

                    if (student != null && book != null)
                    {
                        viewModel.StudentName = student.StudentName;
                        viewModel.Class = student.Class;
                        viewModel.RollNo = student.RollNo;
                        viewModel.FName = student.FName;
                        viewModel.FMobile = student.FMobile;
                        viewModel.Title = book.Title;
                        viewModel.Author = book.Author;
                        viewModel.Subject = book.Subject;
                        viewModel.Publisher = book.Publisher;
                    }
                }
                else
                {
                    // Handle the case where the input values are not valid integers
                    ModelState.AddModelError(string.Empty, "Invalid AddmissionNo or AccessionNo.");
                }
            }




            return View(viewModel);
        }
        public ActionResult Receivebook()
        {

            return View();
        }

        
        public ActionResult IssueR̥egister(ViewModel viewModel)
        {
            var issuedBooks = db.ViewModels.AsQueryable();

            // Apply filters
            if (string.IsNullOrEmpty(viewModel.AdmissionNoFilter))
            {
            }
            else
            {
                int admissionNo;
                if (int.TryParse(viewModel.AdmissionNoFilter, out admissionNo))
                {
                    issuedBooks = issuedBooks.Where(b => b.AdmissionNo == admissionNo);
                }
            }

            if (!string.IsNullOrEmpty(viewModel.AccessionNoFilter))
            {
                int accessionNo;
                if (int.TryParse(viewModel.AccessionNoFilter, out accessionNo))
                {
                    issuedBooks = issuedBooks.Where(b => b.AccessionNo == accessionNo);
                }
            }

            viewModel.ViewModels = issuedBooks.ToList();
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
                    AdmissionNo = 7,
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
                    AdmissionNo = 3,
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
