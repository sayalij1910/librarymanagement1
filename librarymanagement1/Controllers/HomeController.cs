using librarymanagement1.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace librarymanagement1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult listbooks()
        {
            //List<Book> books = new List<Book>();ss
            ////new Book
            //{
            //    AccessionNo = 1,
            //    Author = "MCCONNELL",
            //    BarcodeID = 1,
            //    BillNo = 20,
            //    BookNo = 200,
            //    Class = "10th",
            //    Cost = 300
            //};
            //new Book
            //{
            //    AccessionNo = 1,
            //    Author = "MCCONNELL",
            //    BarcodeID = 1,
            //    BillNo = 20,
            //    BookNo = 200,
            //    Class = "10th",
            //    Cost = 300

            //};

            // Get your data here; this is just a placeholder
            var books = GetBooksFromDataSource(); // Replace with your actual data retrieval logic
            return View(books);


        }

        // Action to export data to Excel
        public ActionResult listbook()
        {
            // Retrieve your data for export (example)
            var books = GetBooksFromDataSource(); // Replace with your actual data retrieval logic

            // Create Excel package using EPPlus
            ExcelPackage excelPackage = new ExcelPackage();
            var worksheet = excelPackage.Workbook.Worksheets.Add("listbooks");

            // Set header row
            worksheet.Cells[1, 1].Value = "AccessionNo";
            worksheet.Cells[1, 2].Value = "BarcodeID";
            worksheet.Cells[1, 3].Value = "Title";
            worksheet.Cells[1, 4].Value = "Author";
            worksheet.Cells[1, 5].Value = "Subject";
            worksheet.Cells[1, 6].Value = "Publisher";
            worksheet.Cells[1, 7].Value = "Edition";
            worksheet.Cells[1, 8].Value = "Year";
            worksheet.Cells[1, 9].Value = "Pages";
            worksheet.Cells[1, 10].Value = "Vol";
            worksheet.Cells[1, 11].Value = "Location";
            worksheet.Cells[1, 12].Value = "ISBN";
            worksheet.Cells[1, 13].Value = "Source";
            worksheet.Cells[1, 14].Value = "Class";
            worksheet.Cells[1, 15].Value = "BillNo";
            worksheet.Cells[1, 16].Value = "Date";
            worksheet.Cells[1, 17].Value = "BookNo";
            worksheet.Cells[1, 18].Value = "Cost";
            worksheet.Cells[1, 19].Value = "WithdrawlNo_Date";
            worksheet.Cells[1, 20].Value = "Remarks";


            // Populate data rows
            int row = 2;
            foreach (var book in books)
            {
                worksheet.Cells[row, 1].Value = book.AccessionNo;
                worksheet.Cells[row, 2].Value = book.BarcodeID;
                worksheet.Cells[row, 3].Value = book.Title;
                worksheet.Cells[row, 4].Value = book.Author;
                worksheet.Cells[row, 5].Value = book.Subject;
                worksheet.Cells[row, 6].Value = book.Publisher;
                worksheet.Cells[row, 7].Value = book.Edition;
                worksheet.Cells[row, 8].Value = book.Year;
                worksheet.Cells[row, 9].Value = book.Pages;
                worksheet.Cells[row, 10].Value = book.Vol;
                worksheet.Cells[row, 11].Value = book.Location;
                worksheet.Cells[row, 12].Value = book.ISBN;
                worksheet.Cells[row, 13].Value = book.Source;
                worksheet.Cells[row, 14].Value = book.Class;
                worksheet.Cells[row, 15].Value = book.BillNo;
                worksheet.Cells[row, 16].Value = book.Date;
                worksheet.Cells[row, 17].Value = book.BookNo;
                worksheet.Cells[row, 18].Value = book.Cost;
                worksheet.Cells[row, 19].Value = book.WithdrawlNo_Date;
                worksheet.Cells[row, 20].Value = book.Remarks;
                row++;
            }

            // Prepare file content
            byte[] fileContents = excelPackage.GetAsByteArray();

            // Return Excel file
            return File(fileContents, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "listbook.xlsx");
        }

        // Replace this method with your actual data retrieval logic
        private List<Book> GetBooksFromDataSource()
        {
            // Simulated data retrieval; replace with actual database query or API call
            var books = new List<Book>
        {
            new Book {AccessionNo= 1,BarcodeID=1, Title = "Book 1", Author = "Author 1",Subject="java", Publisher = "sayali",Edition="1st",Year=2020,Pages=200,Vol="1",Location="Rack1",ISBN="89",Source="programming",Class="MCA",BillNo=11,Date=DateTime.Now,BookNo=11,Cost=300,WithdrawlNo_Date=DateTime.Now,Remarks="NA" },
            new Book {AccessionNo= 1,BarcodeID=1, Title = "Book 1", Author = "Author 1",Subject="java", Publisher = "sayali",Edition="1st",Year=2020,Pages=200,Vol="1",Location="Rack1",ISBN="89",Source="programming",Class="MCA",BillNo=11,Date=DateTime.Now,BookNo=11,Cost=300,WithdrawlNo_Date=DateTime.Now,Remarks="NA" },
            new Book {AccessionNo= 1,BarcodeID=1, Title = "Book 1", Author = "Author 1",Subject="java", Publisher = "sayali",Edition="1st",Year=2020,Pages=200,Vol="1",Location="Rack1",ISBN="89",Source="programming",Class="MCA",BillNo=11,Date=DateTime.Now,BookNo=11,Cost=300,WithdrawlNo_Date=DateTime.Now,Remarks="NA" },
            new Book {AccessionNo= 1,BarcodeID=1, Title = "Book 1", Author = "Author 1",Subject="java", Publisher = "sayali",Edition="1st",Year=2020,Pages=200,Vol="1",Location="Rack1",ISBN="89",Source="programming",Class="MCA",BillNo=11,Date=DateTime.Now,BookNo=11,Cost=300,WithdrawlNo_Date=DateTime.Now,Remarks="NA" },
            new Book {AccessionNo= 1,BarcodeID=1, Title = "Book 1", Author = "Author 1",Subject="java", Publisher = "sayali",Edition="1st",Year=2020,Pages=200,Vol="1",Location="Rack1",ISBN="89",Source="programming",Class="MCA",BillNo=11,Date=DateTime.Now,BookNo=11,Cost=300,WithdrawlNo_Date=DateTime.Now,Remarks="NA" },
            new Book {AccessionNo= 1,BarcodeID=1, Title = "Book 1", Author = "Author 1",Subject="java", Publisher = "sayali",Edition="1st",Year=2020,Pages=200,Vol="1",Location="Rack1",ISBN="89",Source="programming",Class="MCA",BillNo=11,Date=DateTime.Now,BookNo=11,Cost=300,WithdrawlNo_Date=DateTime.Now,Remarks="NA" },
            new Book {AccessionNo= 1,BarcodeID=1, Title = "Book 1", Author = "Author 1",Subject="java", Publisher = "sayali",Edition="1st",Year=2020,Pages=200,Vol="1",Location="Rack1",ISBN="89",Source="programming",Class="MCA",BillNo=11,Date=DateTime.Now,BookNo=11,Cost=300,WithdrawlNo_Date=DateTime.Now,Remarks="NA" },
            new Book {AccessionNo= 1,BarcodeID=1, Title = "Book 1", Author = "Author 1",Subject="java", Publisher = "sayali",Edition="1st",Year=2020,Pages=200,Vol="1",Location="Rack1",ISBN="89",Source="programming",Class="MCA",BillNo=11,Date=DateTime.Now,BookNo=11,Cost=300,WithdrawlNo_Date=DateTime.Now,Remarks="NA" }

        };

            return books;
        }
    }




}

    
