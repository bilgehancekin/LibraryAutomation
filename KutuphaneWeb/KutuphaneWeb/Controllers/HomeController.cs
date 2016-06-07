using KutuphaneWeb.Models;
using PagedList;
using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace KutuphaneWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            using (var db = new KutuphaneDbContext())
            {
                var user = db.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
                if (user == null)
                    return RedirectToAction("Index");
            }
            FormsAuthentication.SetAuthCookie(username, false);
            return RedirectToAction("Books");
        }

        [Authorize]
        public ActionResult Books(int? page)
        {
            using (var db = new KutuphaneDbContext())
            {
                page = page ?? 1;
                var books = db.Books.Include("Writer").Include("BookType").ToList();
                return View(books.ToPagedList(page.Value, 20));
            }
        }

        [Authorize]
        public ActionResult Members(int? page)
        {
            using (var db = new KutuphaneDbContext())
            {
                page = page ?? 1;
                var members = db.Members.ToList();
                return View(members.ToPagedList(page.Value, 20));
            }
        }

        [Authorize]
        public ActionResult Borrows(int? page)
        {
            using (var db = new KutuphaneDbContext())
            {
                page = page ?? 1;
                var borrows = db.Borrows.Include("Book").Include("Member").ToList();
                return View(borrows.ToPagedList(page.Value, 20));
            }
        }

        [Authorize]
        public ActionResult Writers(int? page)
        {
            using (var db = new KutuphaneDbContext())
            {
                page = page ?? 1;
                var writers = db.Writers.ToList();
                return View(writers.ToPagedList(page.Value, 20));
            }
        }

        [Authorize]
        public ActionResult BookTypes(int? page)
        {
            using (var db = new KutuphaneDbContext())
            {
                page = page ?? 1;
                var bookTypes = db.BookTypes.ToList();
                return View(bookTypes.ToPagedList(page.Value, 20));
            }
        }

        [Authorize]
        public ActionResult AddBook()
        {
            using (var db = new KutuphaneDbContext())
            {
                ViewBag.Writers = db.Writers.ToList();
                ViewBag.Types = db.BookTypes.ToList();
                return View();        
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            using (var db = new KutuphaneDbContext())
            {
                if (book == null)
                    return HttpNotFound();

                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Books");
            }
        }

        [Authorize]
        public ActionResult AddMember()
        {
            using (var db = new KutuphaneDbContext())
            {
                return View();
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult AddMember(Member member)
        {
            using (var db = new KutuphaneDbContext())
            {
                if (member == null)
                    return HttpNotFound();

                db.Members.Add(member);
                db.SaveChanges();
                return RedirectToAction("Members");
            }
        }

        [Authorize]
        public ActionResult AddBorrow()
        {
            using (var db = new KutuphaneDbContext())
            {
                ViewBag.Members = db.Members.ToList();
                ViewBag.Books = db.Books.ToList();
                return View();
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult AddBorrow(Borrow borrow)
        {
            using (var db = new KutuphaneDbContext())
            {
                if (borrow == null)
                    return HttpNotFound();

                db.Borrows.Add(borrow);
                db.SaveChanges();
                return RedirectToAction("Borrows");
            }
        }

        [Authorize]
        public ActionResult AddWriter()
        {
            using (var db = new KutuphaneDbContext())
            {
                return View();
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult AddWriter(Writer writer)
        {
            using (var db = new KutuphaneDbContext())
            {
                if (writer == null)
                    return HttpNotFound();

                db.Writers.Add(writer);
                db.SaveChanges();
                return RedirectToAction("Writers");
            }
        }

        [Authorize]
        public ActionResult AddBookType()
        {
            using (var db = new KutuphaneDbContext())
            {
                return View();
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult AddBookType(BookType booktype)
        {
            using (var db = new KutuphaneDbContext())
            {
                if (booktype == null)
                    return HttpNotFound();

                db.BookTypes.Add(booktype);
                db.SaveChanges();
                return RedirectToAction("BookTypes");
            }
        }

        [Authorize]
        public ActionResult EditBook(int id)
        {
            using (var db = new KutuphaneDbContext())
            {
                var book = db.Books.FirstOrDefault(x => x.Id == id);
                if (book == null)
                    return HttpNotFound();
                ViewBag.Writers = db.Writers.ToList();
                ViewBag.Types = db.BookTypes.ToList();
                return View(book);
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult EditBook(Book book)
        {
            using (var db = new KutuphaneDbContext())
            {
                var bk = db.Books.FirstOrDefault(x => x.Id == book.Id);
                if (bk == null)
                    return HttpNotFound();
                bk.BookType = book.BookType;
                bk.ISBN = book.ISBN;
                bk.Name = book.Name;
                bk.PageNumber = book.PageNumber;
                bk.Price = book.Price;
                bk.Publisher = book.Publisher;
                bk.Summary = book.Summary;
                bk.TypeId = book.TypeId;
                bk.WriterId = book.WriterId;
                db.SaveChanges();
                return RedirectToAction("Books");
            }
        }

        [Authorize]
        public ActionResult EditMember(int id)
        {
            using (var db = new KutuphaneDbContext())
            {
                var member = db.Members.FirstOrDefault(x => x.Id == id);
                if (member == null)
                    return HttpNotFound();
                return View(member);
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult EditMember(Member member)
        {
            using (var db = new KutuphaneDbContext())
            {
                var mb = db.Members.FirstOrDefault(x => x.Id == member.Id);
                if (mb == null)
                    return HttpNotFound();
                mb.Adress = member.Adress;
                mb.BirthDate = member.BirthDate;
                mb.BirthPlace = member.BirthPlace;
                mb.EMail = member.EMail;
                mb.MembershipStartDate = member.MembershipStartDate;
                mb.NameSurname = member.NameSurname;
                mb.SSN = member.SSN;
                mb.TelephoneNumber = member.TelephoneNumber;
                db.SaveChanges();
                return RedirectToAction("Members");
            }
        }

        [Authorize]
        public ActionResult EditBorrow(int id)
        {
            using (var db = new KutuphaneDbContext())
            {
                var borrow = db.Borrows.FirstOrDefault(x => x.Id == id);
                if (borrow == null)
                    return HttpNotFound();
                ViewBag.Members = db.Members.ToList();
                ViewBag.Books = db.Books.ToList();
                return View(borrow);
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult EditBorrow(Borrow borrow)
        {
            using (var db = new KutuphaneDbContext())
            {
                var bw = db.Borrows.FirstOrDefault(x => x.Id == borrow.Id);
                if (bw == null)
                    return HttpNotFound();

                bw.MemberId = borrow.MemberId;
                bw.ReturnDate = borrow.ReturnDate;
                bw.EstimatedReturnDate = borrow.EstimatedReturnDate;
                bw.BorrowDate = borrow.BorrowDate;
                bw.BookId = borrow.BookId;
                db.SaveChanges();
                return RedirectToAction("Borrows");
            }
        }

        [Authorize]
        public ActionResult EditWriter(int id)
        {
            using (var db = new KutuphaneDbContext())
            {
                var writer = db.Writers.Find(id);
                if (writer == null)
                    return HttpNotFound();
                return View(writer);
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult EditWriter(Writer writer)
        {
            using (var db = new KutuphaneDbContext())
            {
                var wr = db.Writers.Find(writer.Id);
                if (wr == null)
                    return HttpNotFound();

                wr.NameSurname = writer.NameSurname;
                wr.BirthDate = writer.BirthDate;
                wr.Biography = writer.Biography;
                db.SaveChanges();
                return RedirectToAction("Writers");
            }
        }

        [Authorize]
        public ActionResult EditBookType(int id)
        {
            using (var db = new KutuphaneDbContext())
            {
                var booktype = db.BookTypes.Find(id);
                if (booktype == null)
                    return HttpNotFound();
                return View(booktype);
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult EditBookType(BookType booktype)
        {
            using (var db = new KutuphaneDbContext())
            {
                var bt = db.BookTypes.Find(booktype.Id);
                if (bt == null)
                    return HttpNotFound();

                bt.Name = booktype.Name;
                bt.Explanation = booktype.Explanation;
                db.SaveChanges();
                return RedirectToAction("BookTypes");
            }
        }

        [Authorize]
        public ActionResult DeleteMember(int id)
        {
            using (var db = new KutuphaneDbContext())
            {
                var member = db.Members.Find(id);

                if (member == null)
                    return HttpNotFound();
                var borrows = db.Borrows.Where(x => x.MemberId == id).ToList();
                db.Borrows.RemoveRange(borrows);
                db.Members.Remove(member);
                db.SaveChanges();
                return RedirectToAction("Members");
            }
        }

        [Authorize]
        public ActionResult DeleteBook(int id)
        {
            using (var db = new KutuphaneDbContext())
            {
                var book = db.Books.Find(id);
              
                if (book == null)
                    return HttpNotFound();
                var borrows = db.Borrows.Where(x => x.BookId == id).ToList();
                db.Borrows.RemoveRange(borrows);
                db.Books.Remove(book);
                db.SaveChanges();
                return RedirectToAction("Books");
            }
        }

        [Authorize]
        public ActionResult DeleteBorrow(int id)
        {
            using (var db = new KutuphaneDbContext())
            {
                var borrow = db.Borrows.Find(id);

                if (borrow == null)
                    return HttpNotFound();

                db.Borrows.Remove(borrow);
                db.SaveChanges();
                return RedirectToAction("Borrows");
            }
        }

        [Authorize]
        public ActionResult DeleteWriter(int id)
        {
            using (var db = new KutuphaneDbContext())
            {
                var writer = db.Writers.Find(id);

                if (writer == null)
                    return HttpNotFound();
                var books = db.Books.Where(x => x.WriterId == id).ToList();
                foreach (Book book in books)
                {
                    var borrows = db.Borrows.Where(x => x.BookId == book.Id).ToList();
                    db.Borrows.RemoveRange(borrows);
                }
                db.Books.RemoveRange(books);
                db.Writers.Remove(writer);
                db.SaveChanges();
                return RedirectToAction("Writers");
            }
        }

        [Authorize]
        public ActionResult DeleteBookType(int id)
        {
            using (var db = new KutuphaneDbContext())
            {
                var booktype = db.BookTypes.Find(id);

                if (booktype == null)
                    return HttpNotFound();
                var books = db.Books.Where(x => x.TypeId == id).ToList();
                foreach (Book book in books)
                {
                    var borrows = db.Borrows.Where(x => x.BookId == book.Id).ToList();
                    db.Borrows.RemoveRange(borrows);
                }
                db.Books.RemoveRange(books);
                db.BookTypes.Remove(booktype);
                db.SaveChanges();
                return RedirectToAction("BookTypes");
            }
        }

        [Authorize]
        public ActionResult RecieveBook(int id)
        {
            using (var db = new KutuphaneDbContext())
            {
                var borrow = db.Borrows.Find(id);

                if (borrow == null)
                    return HttpNotFound();

                borrow.ReturnDate = DateTime.Now;
                db.SaveChanges();
                return RedirectToAction("Borrows");
            }
        }

        [Authorize]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}