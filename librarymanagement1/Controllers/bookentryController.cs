
using librarymanagement1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace librarymanagement1.Controllers
{
    public class bookentryController : Controller
    {

        private library_mangEntities1 db = new library_mangEntities1();
        private static List<Book> books = new List<Book>();


        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Book/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "AccessionNo,BarcodeID,Title,Author,Subject,Publisher,Edition,Year,Pages,Vol,Location,Topic,ISBN,Source,Class,BillNo,Date,BookNo,Cost,WithdrawlNo_Date,Remarks")] Book book)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Books.Add(book);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(book);
        //}

        //// GET: Book
        //public ActionResult Index()
        //{
        //    return View(db.Books.ToList());
        //}







        // GET: bookentry
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Index(Book model)
        {

            // To open a connection to the database
            using (var context = new library_mangEntities1())
            {
                // Add data to the particular table
                context.Books.Add(model);

                // save the changes
                context.SaveChanges();
            }
            string message = "Created the record successfully";

            // To display the message on the screen
            // after the record is created successfully
            ViewBag.Message = message;

            // write @Viewbag.Message in the created
            // view at the place where you want to
            // display the message
            return View();
        }



        public JsonResult Delete(int AccessionNo)
        {
            var book = db.Books.Find(AccessionNo);
            if (book != null)
            {
                db.Books.Remove(book);
                db.SaveChanges();
                return Json(new { success = true, message = "Book deleted successfully" });
            }
            return Json(new { success = false, message = "Book not found" });
        }


        public ActionResult Update(int Accessoinno)
        {
            using (var context = new library_mangEntities1())
            {
                var data = context.Books.Where(x => x.AccessionNo == Accessoinno).SingleOrDefault();
                return View(data);
            }
        }

        // To specify that this will be 
        // invoked when post method is called
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int Accessoinno, Book model)
        {
            using (var context = new library_mangEntities1())
            {

                // Use of lambda expression to access
                // particular record from a database
                var data = context.Books.FirstOrDefault(x => x.AccessionNo == Accessoinno);

                // Checking if any such record exist 
                if (data != null)
                {
                    data.BarcodeID = model.BarcodeID;
                    data.Title = model.Topic;
                    data.Subject = model.Subject;
                    data.Publisher = model.Publisher;
                    data.Author = model.Author;
                    data.Edition = model.Edition;
                    data.Year = model.Year;
                    data.Pages = model.Pages;
                    data.Vol = model.Vol;
                    data.Location = model.Location;
                    data.Topic = model.Topic;
                    data.ISBN = model.ISBN;
                    data.Source = model.Source;
                    data.Class = model.Class;
                    data.BillNo = model.BillNo;
                    data.Date = model.Date;
                    data.BookNo = model.BookNo;
                    data.Cost = model.Cost;
                    data.WithdrawlNo_Date = model.WithdrawlNo_Date;
                    data.Remarks = model.Remarks;
                    context.SaveChanges();

                    // It will redirect to 
                    // the Read method
                    return RedirectToAction("Index");
                }
                else
                    return View();
            }
        }

    //GET:  bookentry/Create
    //public ActionResult Create()
    //{
    //    return View();
    //}

    ////POST: bookentry/Create
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public ActionResult Create([Bind(Include = "AccessionNo,BarcodeID,Title,Author,Subject,Publisher,Edition,Year,Pages,Vol,Location,Topic,ISBN,Source,Class,BillNo,Date,BookNo,Cost,WithdrawlNo_Date,Remarks")] Book book)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        book.AccessionNo = books.Count + 1;
    //        books.Add(book);
    //        return RedirectToAction("Index");
    //    }
    //    return View(book);
    //}

    // POST: Book/Delete/5
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public ActionResult Delete(int AccessionNo)
    //{
    //    //Book book = books.Find(AccessionNo);
    //    if (book != null)
    //    {
    //        books.Remove(book);
    //        //books.SaveChanges();
    //    }
    //    return RedirectToAction("Index");
    //    //Book book = db.Books.Find(id);
    //    //db.Books.Remove(book);
    //    //db.SaveChanges();
    //    //return RedirectToAction("Index");
    //}
}
}
