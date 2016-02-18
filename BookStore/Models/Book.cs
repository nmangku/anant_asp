using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string BookISBN { get; set; }
        public string BookDescription { get; set; }
        

    }
}