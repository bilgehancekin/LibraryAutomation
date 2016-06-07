using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KutuphaneWeb.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string SSN { get; set; }
        public string NameSurname { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime MembershipStartDate { get; set; }
        public string BirthPlace { get; set; }
        public string Adress { get; set; }
        public string TelephoneNumber { get; set; }
        public string EMail { get; set; }
    }
}

