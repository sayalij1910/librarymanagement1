
using librarymanagement1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace librarymanagement1.Services
{
    public class BookService
    {
        /*  public List<Book> GetBooks()
          {
              return new List<Book>
              {
                  new Book { AccessionNo = 1, BarcodeID = 1, Title = "ABC", Author = "ABC", Subject = "ABC", Publisher = "ABC", Edition = "4TH", Year = 2012, Pages = 123, Vol = "4", Location = "A", Topic = "FRICTION", ISBN = "1234567", Source = "NSK", Class = "10TH", BillNo = 21, Date = "12/02/2012", BookNo = 1234, Cost = 455, WithdrawlNo_Date = "2021-02-20", Remarks = "NA" },
                  new Book { AccessionNo = 2, BarcodeID = 2, Title = "CLEAN CODE", Author = "ROBERT C. MARTIN", Subject = "AGILE SOFTWARE", Publisher = "PRENTICE HALL", Edition = "1ST", Year = 2008, Pages = 464, Vol = "2", Location = "RACK1 AGILE SOFTWARE", Topic = "SOFTWARE", ISBN = "11", Source = "PUNE", Class = "10TH", BillNo = 10, Date = "2012-06-20", BookNo = 1020, Cost = 450, WithdrawlNo_Date = "2013-06-20", Remarks = "NA" },
                  new Book { AccessionNo = 3, BarcodeID = 3, Title = "INTRODUCTION TO ALGORITHMS", Author = "THOMAS H. CORMEN", Subject = "ALGORITHMS", Publisher = "THE MIT PRESS", Edition = "3RD", Year = 2009, Pages = 1292, Vol = "2", Location = "RACK2", Topic = "ALGORITHMS", ISBN = "12", Source = "DELHI", Class = "BCS", BillNo = 30, Date = "2010-01-10", BookNo = 2001, Cost = 500, WithdrawlNo_Date = "2011-02-10", Remarks = "NA" },
                  new Book { AccessionNo = 4, BarcodeID = 4, Title = "STRUCTURE AND INSTERPRETATION COMPUTER PROGRAMS", Author = "HAROLD ABELSON", Subject = "LEARNING PROGRAMMING", Publisher = "THE MIT PRESS", Edition = "2ND", Year = 1996, Pages = 657, Vol = "5", Location = "RACK12 PROGRAMMING", Topic = "SICP", ISBN = "13", Source = "PUNE", Class = "MCA", BillNo = 20, Date = "2005-10-04", BookNo = 2000, Cost = 550, WithdrawlNo_Date = "2010-03-04", Remarks = "NA" },
                  new Book { AccessionNo = 5, BarcodeID = 5, Title = "RREH", Author = "XYZ", Subject = "ABC", Publisher = "ABC", Edition = "2ND", Year = 1991, Pages = 152, Vol = "5", Location = "RACK5", Topic = "SIP", ISBN = "123", Source = "NASHIK", Class = "11TH", BillNo = 123, Date = "2024-06-15", BookNo = 3847, Cost = 334, WithdrawlNo_Date = "2020-09-18", Remarks = "NA" },
                  new Book { AccessionNo = 6, BarcodeID = 6, Title = "CODE COMPLETE", Author = "MCCONNELL", Subject = "SOFTWARE CONSTRUCTION", Publisher = "MICROSOFT PRESS", Edition = "2ND", Year = 2004, Pages = 960, Vol = "3", Location = "RACK2 SOFTWARE", Topic = "A PRACTICAL HANDBOOK OF SOFTWARE CONSTRUCTION", ISBN = "15", Source = "MUMBAI", Class = "BCS", BillNo = 37, Date = "2021-09-11", BookNo = 6578, Cost = 590, WithdrawlNo_Date = "2022-09-22", Remarks = "NA" },
                  new Book { AccessionNo = 7, BarcodeID = 7, Title = "DESIGN PATTERNS", Author = "ERICH GAMMA", Subject = "OBJECT-ORIENTED SOFTWARE", Publisher = "ADDISION-WESLEY PROFESSIONAL", Edition = "1ST", Year = 1994, Pages = 960, Vol = "4", Location = "RACK3 OOPS", Topic = "ELEMENTS OF REUSABLE OBJECT-ORIENTED SOFTWARE", ISBN = "16", Source = "PUNE", Class = "MCA", BillNo = 36, Date = "2018-09-18", BookNo = 3689, Cost = 490, WithdrawlNo_Date = "2010-10-24", Remarks = "NA" },
                  new Book { AccessionNo = 8, BarcodeID = 8, Title = "THE PRAGMATIC PROGRAMMER", Author = "ANDREW HUNT", Subject = "YOUR JOURNEY TO MASTERY", Publisher = "ADDISION-WESLEY PROFESSIONAL", Edition = "2ND", Year = 2019, Pages = 352, Vol = "5", Location = "RACK2 CODING", Topic = "PROGRAMMING", ISBN = "17", Source = "NASHIK", Class = "10TH", BillNo = 38, Date = "2020-09-15", BookNo = 7839, Cost = 600, WithdrawlNo_Date = "2022-04-10", Remarks = "NA" },
                  new Book { AccessionNo = 9, BarcodeID = 9, Title = "HEAD FIRST DESIGN PATTERNS", Author = "ERIC FREEMAN", Subject = "A BRAIN-FRIENDLY GUIDDE", Publisher = "O'REILLY MEDIA", Edition = "1ST", Year = 2004, Pages = 692, Vol = "3", Location = "RACK3 GUIDANCE", Topic = "JAVA BOOK", ISBN = "18", Source = "MUMBAI", Class = "10TH", BillNo = 23, Date = "2005-09-05", BookNo = 2890, Cost = 520, WithdrawlNo_Date = "2009-05-10", Remarks = "NA" },
                  new Book { AccessionNo = 10, BarcodeID = 10, Title = "REFACTORING", Author = "MARTIN FOWLER", Subject = "IMPROVING THE DESIGN OF EXISTING CODE", Publisher = "ADDISION-WESLEY PROFESSIONAL", Edition = "2ND", Year = 2018, Pages = 448, Vol = "1", Location = "RACK4 DESIGN", Topic = "DESIGNING", ISBN = "19", Source = "DELHI", Class = "10TH", BillNo = 20, Date = "2019-11-09", BookNo = 3298, Cost = 360, WithdrawlNo_Date = "2020-10-09", Remarks = "NA" },
                  new Book { AccessionNo = 11, BarcodeID = 11, Title = "THE ART OF COMPUTER PROGRAMMING", Author = "DONALD E. KNUTH", Subject = "COMPUTER PROGRAMMING", Publisher = "ADDISION-WESLEY PROFESSIONAL", Edition = "1ST", Year = 2011, Pages = 3168, Vol = "1", Location = "RACK1 PROGRAMMING", Topic = "COMPUTER PROGRAMS", ISBN = "100", Source = "NASHIK", Class = "10TH", BillNo = 78, Date = "2015-09-11", BookNo = 4890, Cost = 600, WithdrawlNo_Date = "2016-09-11", Remarks = "NA" },
                  new Book { AccessionNo = 12, BarcodeID = 12, Title = "PYTHON PROGRAMMING", Author = "DR. Ms. MANISHA BHARAMBE", Subject = "PYTHON", Publisher = "NIRALI PRAKASHAN", Edition = "1ST", Year = 2021, Pages = 300, Vol = "3", Location = "RACK1 PROGRAMMING", Topic = "A INTRODUCTION OD PYTHON", ISBN = "34", Source = "PUNE", Class = "10TH", BillNo = 34, Date = "2021-10-11", BookNo = 3879, Cost = 300, WithdrawlNo_Date = "2022-01-10", Remarks = "NA" },
                  new Book { AccessionNo = 13, BarcodeID = 13, Title = "THEOROTICAL COMPUTER SCIENCE", Author = "DR. Ms. MANISHA BHARAMBE", Subject = "TCS", Publisher = "NIRALI PRAKASHAN", Edition = "2ND", Year = 2020, Pages = 500, Vol = "2", Location = "RACK1 PROGRAMMING", Topic = "REGULAR EXPRESSION AND LANGUAGE", ISBN = "12", Source = "PUNE", Class = "10TH", BillNo = 44, Date = "2021-11-11", BookNo = 3354, Cost = 400, WithdrawlNo_Date = "2022-10-09", Remarks = "NA" },
                  new Book { AccessionNo = 14, BarcodeID = 14, Title = "OBJECT-ORIENTED PROGRAMMING LANGUAGE", Author = "DR. Ms. MANISHA BHARAMBE", Subject = "JAVA", Publisher = "NIRALI PRAKASHAN", Edition = "1ST", Year = 2020, Pages = 500, Vol = "3", Location = "RACK1 PROGRAMMING", Topic = "INTRODUCTION TO JAVA", ISBN = "12", Source = "PUNE", Class = "10TH", BillNo = 55, Date = "2021-10-09", BookNo = 7469, Cost = 400, WithdrawlNo_Date = "2022-10-06", Remarks = "NA" },
                  new Book { AccessionNo = 15, BarcodeID = 15, Title = "FOUNDATION OF DATA SCIENCE", Author = "DR. HARSHA PATIL", Subject = "DATA SCIENCE", Publisher = "NIRALI PRAKASHAN", Edition = "3RD", Year = 2019, Pages = 500, Vol = "4", Location = "RACK1 PROGRAMMING", Topic = "INTRODUCTION TO DATA SCIENCE", ISBN = "15", Source = "PUNE", Class = "10TH", BillNo = 22, Date = "2021-10-05", BookNo = 8685, Cost = 450, WithdrawlNo_Date = "2022-10-03", Remarks = "NA" },
              };

          }
          public List<Book> GetBooksByAccessionNo(int AccessionNo)
          {
              return GetBooks().Where(b => b.AccessionNo == AccessionNo).ToList();
          }
          public List<Book> GetBooksByBarcodeID(int BarcodeID)
          {
              return GetBooks().Where(b => b.BarcodeID == BarcodeID).ToList();
          }
          public List<Book> GetBooksByTitle(string Title)
          {
              return GetBooks().Where(b => b.Title == Title).ToList();
          }
          public List<Book> GetBooksByAuthor(string Author)
          {
              return GetBooks().Where(b => b.Author == Author).ToList();
          }
          public List<Book> GetBooksBySubject(string Subject)
          {
              return GetBooks().Where(b => b.Subject == Subject).ToList();
          }
          public List<Book> GetBooksByPublisher(string Publisher)
          {
              return GetBooks().Where(b => b.Publisher == Publisher).ToList();
          }
          public List<Book> GetBooksByEdition(string Edition)
          {
              return GetBooks().Where(b => b.Edition == Edition).ToList();
          }
          public List<Book> GetBooksByYear(int Year)
          {
              return GetBooks().Where(b => b.Year == Year).ToList();
          }
          public List<Book> GetBooksByPages(int Pages)
          {
              return GetBooks().Where(b => b.Pages == Pages).ToList();
          }
          public List<Book> GetBooksByVol(string Vol)
          {
              return GetBooks().Where(b => b.Vol == Vol).ToList();
          }
          public List<Book> GetBooksByLocation(string Location)
          {
              return GetBooks().Where(b => b.Location == Location).ToList();
          }
          public List<Book> GetBooksByTopic(string Topic)
          {
              return GetBooks().Where(b => b.Topic == Topic).ToList();
          }
          public List<Book> GetBooksByISBN(string ISBN)
          {
              return GetBooks().Where(b => b.ISBN == ISBN).ToList();
          }
          public List<Book> GetBooksBySource(string Source)
          {
              return GetBooks().Where(b => b.Source == Source).ToList();
          }
          public List<Book> GetBooksByClass(string Class)
          {
              return GetBooks().Where(b => b.Class == Class).ToList();
          }
          public List<Book> GetBooksByBillNo(int BillNo)
          {
              return GetBooks().Where(b => b.BillNo == BillNo).ToList();
          }

          public List<Book> GetBooksByBookNo(int BookNo)
          {
              return GetBooks().Where(b => b.BookNo == BookNo).ToList();
          }
          public List<Book> GetBooksByCost(int Cost)
          {
              return GetBooks().Where(b => b.Cost == Cost).ToList();
          }

          public List<Book> GetBooksByRemarks(string Remarks)
          {
              return GetBooks().Where(b => b.Remarks == Remarks).ToList();
          }

      }*/
    }
}