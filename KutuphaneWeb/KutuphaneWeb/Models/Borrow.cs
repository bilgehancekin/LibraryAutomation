using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneWeb.Models
{
    public class Borrow
    {
        public int Id { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime EstimatedReturnDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public int? BookId { get; set; }

        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }

        public int? MemberId { get; set; }

        [ForeignKey("MemberId")]
        public virtual Member Member { get; set; }


    }
}