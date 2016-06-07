using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KutuphaneWeb.Models
{
    public class Writer
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Biography { get; set; }
    }
}