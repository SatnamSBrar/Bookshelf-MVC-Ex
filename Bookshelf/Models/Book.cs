using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace Bookshelf.Models
{
    public class Book
    {
        [Key]   //data annotation
        public int ID { get; set; } //key is the ID
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        [ForeignKey("Category")]    //creates another key to organize records
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}