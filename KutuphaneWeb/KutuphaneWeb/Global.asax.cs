using KutuphaneWeb.Models;
using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace KutuphaneWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        static Random random = new Random();
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            using (var context = new KutuphaneDbContext())
            {
                context.Database.Initialize(false);

                if (context.Users.Count() == 0)
                {
                    context.Users.Add(new User()
                    {
                        Username = "Admin",
                        Password = "1234"
                    });
                    context.SaveChanges();
                }

                if (context.Writers.Count() == 0)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        context.Writers.Add(new Writer()
                        {
                            Biography = "bibibiibibibib",
                            BirthDate = DateTime.Now.AddYears(-25),
                            NameSurname = RandomString(5) + " " + RandomString(6)
                        });
                    }
                }
                if (context.BookTypes.Count() == 0)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        context.BookTypes.Add(new BookType()
                        {
                            Explanation = "epxepxpepxpe",
                            Name = RandomString(8)
                        });
                    }
                }
                context.SaveChanges();
                if (context.Books.Count() == 0)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        context.Books.Add(new Book()
                        {
                            TypeId = context.BookTypes.ToList().Skip(random.Next(0, 14)).First().Id,
                            ISBN = RandomString(15),
                            Name = RandomString(6),
                            PageNumber = random.Next(100, 600),
                            Price = random.Next(20, 70),
                            Publisher = RandomString(8),
                            Summary = RandomString(120),
                            WriterId = context.Writers.ToList().Skip(random.Next(0, 13)).First().Id,
                        });
                    }
                }
                context.SaveChanges();

                if (context.Members.Count() == 0)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        context.Members.Add(new Member()
                        {
                            SSN = RandomString(15),
                            NameSurname = RandomString(6) + " " + RandomString(6),
                            BirthDate = DateTime.Now.AddYears(-40),
                            BirthPlace = RandomString(10),
                            MembershipStartDate = DateTime.Now.AddYears(-25),
                            Adress=RandomString(35),
                            TelephoneNumber=RandomString(12),
                            EMail=RandomString(10)+"@"+RandomString(5)+".com",
                        });
                    }
                }
                context.SaveChanges();

                if (context.Borrows.Count() == 0)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        context.Borrows.Add(new Borrow()
                        {
                            BorrowDate = DateTime.Now.AddYears(-30),
                            EstimatedReturnDate = DateTime.Now.AddYears(-29),
                            BookId = context.Books.ToList().Skip(random.Next(0, 50)).First().Id,
                            ReturnDate = DateTime.Now.AddMonths(-5),
                            MemberId = context.Members.ToList().Skip(random.Next(0, 14)).First().Id,
                        });
                    }
                }
                context.SaveChanges();
            }
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
