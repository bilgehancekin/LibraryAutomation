using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KutuphaneWeb.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public int PageNumber { get; set; }
        public string Publisher { get; set; }
        public string Summary { get; set; }
        public float Price { get; set; }


        public int? WriterId { get; set; }

        [ForeignKey("WriterId")]
        public virtual Writer Writer { get; set; }



        
        public int? TypeId { get; set; }

        [ForeignKey("TypeId")]
        public virtual BookType BookType { get; set; }
    }
}