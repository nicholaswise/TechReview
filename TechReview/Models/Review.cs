using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TechReview.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [Display(Name ="Publish Date")]
        public DateTime PublishDate { get; set; }

        [ForeignKey("Category")]

        [Display(Name ="Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get;set;}

    }
}